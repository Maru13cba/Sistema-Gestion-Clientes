using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
//Para que sirven estos nombres
using System.Data;
using System.Data.OleDb;
using System.Windows.Forms;
using System.IO;


namespace Clientes_Unidad_3
{
    internal class ClsCliente
    {
        //¿Que son objetos? //Son tres objetos:
        private OleDbConnection conexion = new OleDbConnection(); // Permite conectar con la base de datos 
        private OleDbCommand comando = new OleDbCommand(); //Envia orden a la Db
        private OleDbDataAdapter adaptador = new OleDbDataAdapter(); //Adapta los datos de la deb a datros recocnocidos por .Net

        //Variables tipo string:
        private string cadenaDeConexion = "Provider=Microsoft.Jet.OLEDB.4.0;Data Source=Clientes.mdb";
        private string Tabla = "Cliente"; // se indica a que tabla se apunta para trabajar (para procesar). Tiene que ser exacto el nombre 

        private Decimal deuda;
        private Int32 cantidad;

        private Int32 idCli;
        private String nom;
        private Decimal deudaBC;
        private Decimal LimiteBC;
        private Int32 idCiu;

        //Declarar propiedades

        public Int32 idCliente
        {
            get { return idCli; }
            set { idCli = value; }
        }

        public String Nombre
        {
            get { return nom; }
            set { nom = value; }
        }

        public Decimal Deuda //propiedad publica
        {
            get { return deudaBC; }
            set { deudaBC = value; }
        }

        public Decimal Limite //propiedad publica
        {
            get { return LimiteBC; }
            set { LimiteBC = value; }
        }

        public Int32 idCiudad
        {
            get { return idCiu; }
            set { idCiu = value; }
        }

        /// <summary>
        ///Esto es lo anterior
        /// </summary>
        public Decimal TotalDeuda //propiedad publica
        {
            get { return deuda; }
        }

        public Int32 CantidadDeudores
        {
            get { return cantidad; }
        }

        public Decimal PromedioDeuda
        {
            get { return deuda / cantidad; }
        }


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
                adaptador.Fill(DS); //DS memoria virtual 

                Grilla.DataSource = DS.Tables[0];

                conexion.Close();//Instruccion final 
            }
            catch (Exception e)
            {
                MessageBox.Show(e.ToString());
            }

        }


        public void ListarClientesDeudores(DataGridView GrillaDeudores)
        {
            try
            {
                conexion.ConnectionString = cadenaDeConexion; //Instrucción 1
                conexion.Open();//Instrucción 2

                //Son ordenes:
                comando.Connection = conexion; // Orden que trae los datos de clientes
                comando.CommandType = CommandType.TableDirect;//TableDirect pide una tabla directa 
                comando.CommandText = "Cliente";

                OleDbDataReader DR = comando.ExecuteReader(); // Tomar lo del comando una vez que se haya ejecutado 

                GrillaDeudores.Rows.Clear();
                cantidad = 0;
                deuda = 0;

                if (DR.HasRows) // si tenemos filas resultantes, entonces leemos  (while), si no se cierra conexión (conexion.Close();)
                {
                    while (DR.Read()) //
                    {
                        if (DR.GetDecimal(2) > 0)
                        {

                            GrillaDeudores.Rows.Add(DR.GetInt32(0), DR.GetString(1), DR.GetDecimal(2));
                            cantidad++;
                            deuda = deuda + DR.GetDecimal(2);

                        }

                    }
                }
                conexion.Close();//Instruccion final 
            }
            catch (Exception e)
            {
                MessageBox.Show(e.ToString());

            }


        }


        public void ReporteClientes()
        {
            try
            {
                conexion.ConnectionString = cadenaDeConexion; //Instrucción 1
                conexion.Open();//Instrucción 2

                //Son ordenes:
                comando.Connection = conexion; // Orden que trae los datos de clientes
                comando.CommandType = CommandType.TableDirect;//TableDirect pide una tabla directa 
                comando.CommandText = "Cliente";

                OleDbDataReader DR = comando.ExecuteReader(); // Tomar lo del comando una vez que se haya ejecutado 

                StreamWriter AD = new StreamWriter("ReporteClientes.csv", false, new UTF8Encoding(true));
                AD.WriteLine("Listado de clientes \n");
                AD.WriteLine("Código; Nombre; Deuda");


                cantidad = 0;
                deuda = 0;

                if (DR.HasRows) // si tenemos filas resultantes, entonces leemos  (while), si no se cierra conexión (conexion.Close();)
                {
                    while (DR.Read()) //
                    {



                        AD.Write(DR.GetInt32(0)); //No WriteLine para que no baje a la fila de abajo en el archivo.
                        AD.Write(";"); //Separa columnas
                        AD.Write(DR.GetString(1));
                        AD.Write(";");
                        AD.WriteLine(DR.GetDecimal(2));
                        cantidad++;
                        deuda = deuda + DR.GetDecimal(2);



                    }

                    AD.Write("\n Cantidad de clientes: ;; ");
                    AD.WriteLine(cantidad);
                    AD.Write("Deuda de los clientes: ;; ");
                    AD.WriteLine(deuda);
                }
                conexion.Close();//Instruccion final 
                AD.Close();
            }
            catch (Exception e)
            {
                MessageBox.Show(e.ToString());

            }


        }

        public void Buscar(Int32 IdCliente)
        {
            try
            {
                conexion.ConnectionString = cadenaDeConexion; //Instrucción 1
                conexion.Open();//Instrucción 2

                //Son ordenes:
                comando.Connection = conexion; // Orden que trae los datos de clientes
                comando.CommandType = CommandType.TableDirect;//TableDirect pide una tabla directa 
                comando.CommandText = "Cliente";

                OleDbDataReader DR = comando.ExecuteReader(); // Tomar lo del comando una vez que se haya ejecutado 

                idCli = 0;

                if (DR.HasRows) // si tenemos filas resultantes, entonces leemos  (while), si no se cierra conexión (conexion.Close();)
                {
                    while (DR.Read()) //
                    {

                        if (DR.GetInt32(0) == IdCliente)
                        {
                            idCli = DR.GetInt32(0);
                            nom = DR.GetString(1);
                            deudaBC = DR.GetDecimal(2);
                            LimiteBC = DR.GetDecimal(3);
                            idCiu = DR.GetInt32(4);
                        }

                    }

                }

                conexion.Close();//Instruccion final
            }
            catch (Exception e)
            {
                MessageBox.Show(e.ToString());
            }

        }


        public void AgregarClienete()
        {
            try
            {
                conexion.ConnectionString = cadenaDeConexion; //Instrucción 1
                conexion.Open();//Instrucción 2

                //Son ordenes:
                comando.Connection = conexion; // Orden que trae los datos de clientes
                comando.CommandType = CommandType.TableDirect;//TableDirect pide una tabla directa 
                comando.CommandText = Tabla;

                adaptador = new OleDbDataAdapter(comando);
                //OleDbDataReader DR = comando.ExecuteReader(); // Tomar lo del comando una vez que se haya ejecutado 
                DataSet DS = new DataSet();
                adaptador.Fill(DS, Tabla); // trae datos de tabla para RAM (para el DataSet - DS) y luego del data set para la DB

                DataTable tabla = DS.Tables[Tabla]; //recibe lo del data set. En caso de no tener nombre va 0
                DataRow fila = tabla.NewRow(); //le asigna una nueva fila vacia de la tabla que corresponda

                //Se llena la fila

                fila["Nombre"] = nom;
                fila["Deuda"] = 0;
                fila["Limite"] = LimiteBC;
                fila["idCiudad"] = idCiu;

                tabla.Rows.Add(fila);
                OleDbCommandBuilder ConciliaCambios = new OleDbCommandBuilder(adaptador);// concilia los campos entre memoria y BD
                adaptador.Update(DS, Tabla); // hace efectivo los cambios 

                conexion.Close();//Instruccion final
            }
            catch (Exception e)
            {
                MessageBox.Show(e.ToString());
            }

        }

        public void Modificar(Int32 IdCliente)
        {
            try
            {
                String sql = "";
                sql = "UPDATE CLIENTE SET LIMITE = ";
                sql = sql + LimiteBC.ToString();
                sql = sql + " WHERE IDCLIENTE = ";
                sql = sql + IdCliente.ToString();
                conexion.ConnectionString = cadenaDeConexion; //Instrucción 1
                conexion.Open();//Instrucción 2

                //Son ordenes:
                comando.Connection = conexion; // Orden que trae los datos de clientes
                comando.CommandType = CommandType.Text;//TableDirect pide una tabla directa 
                comando.CommandText = sql;
                comando.ExecuteNonQuery();
                conexion.Close();//Instruccion final 
            }
            catch (Exception e)
            {
                MessageBox.Show(e.ToString());
            }

        }

        public void Eliminar(Int32 IdCliente)
        {
            try
            {
                String sql = "DELETE * FROM CLIENTE WHERE IdCliente = " + IdCliente.ToString();
                conexion.ConnectionString = cadenaDeConexion; //Instrucción 1
                conexion.Open();//Instrucción 2

                //Son ordenes:
                comando.Connection = conexion; // Orden que trae los datos de clientes
                comando.CommandType = CommandType.Text;//TableDirect pide una tabla directa 
                comando.CommandText = sql;
                comando.ExecuteNonQuery();
                conexion.Close();//Instruccion final 
            }
            catch (Exception e)
            {
                MessageBox.Show(e.ToString());
            }

        }

        public void AgregarNuevoRegistro()
        {
            try
            {
                String sql = "";
                sql = "INSERT INTO CLIENTE (Nombre, Deuda, Limite, IdCiudad) ";
                sql = sql + "VALUES (' " + nom + "', 0, " + LimiteBC.ToString() + " ," + idCiu.ToString() + ")";
                conexion.ConnectionString = cadenaDeConexion; //Instrucción 1
                conexion.Open();//Instrucción 2

                //Son ordenes:
                comando.Connection = conexion; // Orden que trae los datos de clientes
                comando.CommandType = CommandType.Text;//TableDirect pide una tabla directa 
                comando.CommandText = sql;
                comando.ExecuteNonQuery();
                conexion.Close();//Instruccion final 
            }
            catch (Exception e)
            {
                MessageBox.Show(e.ToString());
            }

        }

        public void ListarClientes(DataGridView GrillaDeudores)
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

                GrillaDeudores.Rows.Clear();

                cantidad = 0;
                deuda = 0;

                ClsCiudad ciu = new ClsCiudad();
                String NomCiu = "";

                if (DR.HasRows) // si tenemos filas resultantes, entonces leemos  (while), si no se cierra conexión (conexion.Close();)
                {
                    while (DR.Read())
                    {
                        NomCiu = ciu.Buscar(DR.GetInt32(4));

                        GrillaDeudores.Rows.Add(
                        DR.GetInt32(0),
                        DR.GetString(1),
                        NomCiu,
                        DR.GetDecimal(3),
                        DR.GetDecimal(2));

                        cantidad++;
                        deuda = deuda + DR.GetDecimal(2);
                    }
                }
                conexion.Close();//Instruccion final 
            }
            catch (Exception e)
            {
                MessageBox.Show(e.ToString());

            }


        }

        public void ListarClientesDeUnaCiudad(DataGridView GrillaDeudores, Int32 IdCiudad)
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

                GrillaDeudores.Rows.Clear();


                if (DR.HasRows) // si tenemos filas resultantes, entonces leemos  (while), si no se cierra conexión (conexion.Close();)
                {
                    while (DR.Read()) //
                    {
                        if (DR.GetInt32 (4) == IdCiudad)
                        {
                            GrillaDeudores.Rows.Add(DR.GetInt32(0), DR.GetString(1));
                        }

                    }
                }
                conexion.Close();//Instruccion final 
            }
            catch (Exception e)
            {
                MessageBox.Show(e.ToString());

            }


        }

        public void ReporteClientesDeCiudad(Int32 IdCiudad)
        {
            try
            {
                conexion.ConnectionString = cadenaDeConexion; //Instrucción 1
                conexion.Open();//Instrucción 2

                //Son ordenes:
                comando.Connection = conexion; // Orden que trae los datos de clientes
                comando.CommandType = CommandType.TableDirect;//TableDirect pide una tabla directa 
                comando.CommandText = "Cliente";

                OleDbDataReader DR = comando.ExecuteReader(); // Tomar lo del comando una vez que se haya ejecutado 

                StreamWriter AD = new StreamWriter("ReporteClientesPorCiudad.csv", false, new UTF8Encoding(true));

                AD.WriteLine("sep=;");
                AD.WriteLine("Listado de clientes por ciudad");
                AD.WriteLine("");
                AD.WriteLine("Código;Nombre");

                if (DR.HasRows) // si tenemos filas resultantes, entonces leemos  (while), si no se cierra conexión (conexion.Close();)
                {
                    while (DR.Read()) //
                    {


                        if (DR.GetInt32 (4) == IdCiudad)
                        {
                            AD.WriteLine(DR.GetInt32(0) + ";" + DR.GetString(1));

                            cantidad++;
                            deuda = deuda + DR.GetDecimal(2);
                        }


                    }

                    AD.Write("\n Cantidad de clientes: ;; ");
                    AD.WriteLine(cantidad);
                    AD.Write("Deuda de los clientes: ;; ");
                    AD.WriteLine(deuda);
                }
                conexion.Close();//Instruccion final 
                AD.Close();
            }
            catch (Exception e)
            {
                MessageBox.Show(e.ToString());

            }
        }


    }   
}





 
