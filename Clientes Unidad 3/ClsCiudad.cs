using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data; //para tarbajar con BD
using System.Data.OleDb;//para tarbajar con BD
using System.Windows.Forms;//para tarbajar con BD


namespace Clientes_Unidad_3
{
    internal class ClsCiudad
    {
        //¿Que son objetos? //Son tres objetos:
        private OleDbConnection conexion = new OleDbConnection(); // Permite conectar con la base de datos 
        private OleDbCommand comando = new OleDbCommand(); //Envia orden a la Db
        private OleDbDataAdapter adaptador = new OleDbDataAdapter(); //Adapta los datos de la deb a datros recocnocidos por .Net

        //Variables tipo string:
        private string cadenaDeConexion = "Provider=Microsoft.Jet.OLEDB.4.0;Data Source=Clientes.mdb";
        private string Tabla = "Ciudad"; // se indica a que tabla se apunta para trabajar (para procesar). Tiene que ser exacto el nombre 


        public void Listar(DataGridView Grilla)
        {
            try
            {
                conexion.ConnectionString = cadenaDeConexion; //Instrucción 1
                conexion.Open();//Instrucción 2

                //Son ordenes:
                comando.Connection = conexion; // Orden que trae los datos de clientes
                comando.CommandType = CommandType.TableDirect;//TableDirect pide una tabla directa 
                comando.CommandText = Tabla;

                //Reciben los datos de las ordenes:
                adaptador = new OleDbDataAdapter(comando);
                //Crear Obleto
                DataSet DS = new DataSet(); // Se llama instanciar un objeto
                adaptador.Fill(DS, Tabla); //DS memoria virtual 

                Grilla.DataSource = DS.Tables[Tabla];

                conexion.Close();//Instruccion final 
            }
            catch (Exception e)
            {
                MessageBox.Show(e.ToString());
            }

        }

        public void Listar(ComboBox Combo)
        {
            try
            {
                conexion.ConnectionString = cadenaDeConexion; //Instrucción 1
                conexion.Open();//Instrucción 2

                //Son ordenes:
                comando.Connection = conexion; // Orden que trae los datos de clientes
                comando.CommandType = CommandType.TableDirect;//TableDirect pide una tabla directa 
                comando.CommandText = Tabla;

                //Reciben los datos de las ordenes:
                adaptador = new OleDbDataAdapter(comando);
                //Crear Obleto
                DataSet DS = new DataSet(); // Se llama instanciar un objeto
                adaptador.Fill(DS, Tabla); //DS memoria virtual 

                Combo.DataSource = DS.Tables[Tabla];
                Combo.DisplayMember = "Nombre"; // el nombre que tiene la columna con los datos que queremos que se vean 
                Combo.ValueMember = "idCiudad";

                conexion.Close();//Instruccion final 
            }
            catch (Exception e)
            {
                MessageBox.Show(e.ToString());
            }

        }

        public string Buscar (Int32 idCiudad)
        {

            try
            {
                conexion.ConnectionString = cadenaDeConexion; //Instrucción 1
                conexion.Open();//Instrucción 2

                //Son ordenes:
                comando.Connection = conexion; // Orden que trae los datos de clientes
                comando.CommandType = CommandType.TableDirect;//TableDirect pide una tabla directa 
                comando.CommandText = Tabla;

                OleDbDataReader DR = comando.ExecuteReader(); // Tomar lo del comando una vez que se haya ejecutado 

                string Resultado = "";


                if (DR.HasRows) // si tenemos filas resultantes, entonces leemos  (while), si no se cierra conexión (conexion.Close();)
                {
                    while (DR.Read())
                    {
                        if (DR.GetInt32(0) == idCiudad)
                        {
                            Resultado = DR.GetString(1);
                        }
                    }
                }
                conexion.Close();//Instruccion final 

                return Resultado;
            }

            catch (Exception e)
            {

                return e.ToString();
            }
        }
    


    }
}
