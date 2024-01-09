using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.OleDb;
using System.Windows.Forms;
using System.Security.Cryptography.X509Certificates;
using System.IO;
//para enviar los archivos a imprimir
using System.Drawing;
using System.Drawing.Text;
using System.Drawing.Printing;

namespace ExamenFinal_CozziPablo
{
    internal class clsCliente
    {
        
        private OleDbConnection conexion = new OleDbConnection();
        private OleDbCommand comando = new OleDbCommand();
        private OleDbDataAdapter adaptador = new OleDbDataAdapter();
        private string CadenaConexion = "Provider=Microsoft.Jet.OLEDB.4.0;Data Source=BD_Clientes.mdb";
        private string Tabla = "Socio";

        clsBarrio barrio = new clsBarrio();
        clsActividad actividad = new clsActividad();


        private Int32 idSoc;
        private string nom;
        private string direc;
        private Int32 idBarr;
        private Int32 idAct;
        private Decimal deu;

        public Decimal Deuda;
        public Decimal Promedio;
        public Decimal DeudaMayor;
        public Decimal DeudaMenor;
        public Int32 Cantidad;
        public string actividadElegida = "";
        public string barrioElegido = "";

        public Int32 idSocio
        {
            get { return idSoc; }
            set { idSoc = value; }
        }
        public string Nombre
        {
            get { return nom; }
            set { nom = value; }
        } 
        public string Direccion
        {
            get { return direc; }
            set { direc = value; }
        }
        public Int32 idBarrio
        {
            get { return idBarr; }
            set { idBarr = value; }
        }
        public Int32 idActividad
        {
            get { return idAct; }
            set { idAct = value; }
        }
        public Decimal DeudaCliente
        {
            get { return deu; }
            set { deu = value; }
        }

        public void AgregarClienteNuevo()
        {
            try
            {
                conexion.ConnectionString = CadenaConexion;
                conexion.Open();
                comando.Connection = conexion;
                comando.CommandType = CommandType.TableDirect;
                comando.CommandText = Tabla;
                adaptador = new OleDbDataAdapter(comando);
                DataSet DS = new DataSet();
                adaptador.Fill(DS, Tabla);
                DataTable tabla = DS.Tables[Tabla];
                DataRow fila = tabla.NewRow();
                fila["IdSocio"] = idSoc;
                fila["Nombre"] = nom;
                fila["Direccion"] = direc;
                fila["idBarrio"] = idBarr;
                fila["idActividad"] = idAct;
                fila["Deuda"] = deu;
                tabla.Rows.Add(fila);
                OleDbCommandBuilder ConciliaCampos = new OleDbCommandBuilder(adaptador);
                adaptador.Update(DS, Tabla);
                conexion.Close();
            }
            catch (Exception e)
            {

                MessageBox.Show(e.ToString());
            }
        }
        public void Buscar(Int32 Cliente)
        {
            try
            {
                conexion.ConnectionString = CadenaConexion;
                conexion.Open();
                comando.Connection = conexion;
                comando.CommandType = CommandType.TableDirect;
                comando.CommandText = Tabla;
                OleDbDataReader DR = comando.ExecuteReader();
                idSoc = 0; 
                if (DR.HasRows)
                {
                    while (DR.Read())
                    {
                        if (DR.GetInt32(0) == Cliente) 
                        {

                            idSoc = DR.GetInt32(0);
                            nom = DR.GetString(1);
                            direc = DR.GetString(2);
                            idBarr = DR.GetInt32(3);
                            idAct = DR.GetInt32(4);
                            deu = DR.GetDecimal(5);

                        }

                    }
                }
                conexion.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }
        public void ModificarNombre(Int32 Socio)
        {
            try
            {
                string sqlNombre = "";
                sqlNombre = "UPDATE Socio SET Nombre = '" + Nombre.ToString() + "' WHERE IdSocio = " + Socio;

                conexion.ConnectionString = CadenaConexion;
                conexion.Open();
                comando.Connection = conexion;
                comando.CommandType = CommandType.Text;
                comando.CommandText = sqlNombre;
                //MessageBox.Show(sqlNombre); utilizo para saber si la instruccion sql es correcta
                comando.ExecuteNonQuery();
                conexion.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        public void ModificarDireccion(Int32 Socio)
        {
            try
            {
                string sqlNombre = "";
                sqlNombre = "UPDATE Socio SET Direccion = '" + Direccion.ToString() + "' WHERE IdSocio = " + Socio;

                conexion.ConnectionString = CadenaConexion;
                conexion.Open();
                comando.Connection = conexion;
                comando.CommandType = CommandType.Text;
                comando.CommandText = sqlNombre;
                //MessageBox.Show(sqlNombre); utilizo para saber si la instruccion sql es correcta
                comando.ExecuteNonQuery();
                conexion.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        public void ModificarBarrio(Int32 socio, Int32 idbarrio)
        {
            try
            {
                string sqlNombre = "";
                sqlNombre = "UPDATE Socio SET idBarrio = '" + idbarrio.ToString() + "' WHERE IdSocio = " + socio;

                conexion.ConnectionString = CadenaConexion;
                conexion.Open();
                comando.Connection = conexion;
                comando.CommandType = CommandType.Text;
                comando.CommandText = sqlNombre;
                //MessageBox.Show(sqlNombre); utilizo para saber si la instruccion sql es correcta
                comando.ExecuteNonQuery();
                conexion.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        public void ModificarActividad(Int32 socio, Int32 idactividad)
        {
            try
            {
                string sqlNombre = "";
                sqlNombre = "UPDATE Socio SET idActividad = '" + idactividad.ToString() + "' WHERE IdSocio = " + socio;

                conexion.ConnectionString = CadenaConexion;
                conexion.Open();
                comando.Connection = conexion;
                comando.CommandType = CommandType.Text;
                comando.CommandText = sqlNombre;
                //MessageBox.Show(sqlNombre); utilizo para saber si la instruccion sql es correcta
                comando.ExecuteNonQuery();
                conexion.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        public void ModificarDeuda(Int32 Socio)
        {
            try
            {
                string sqlNombre = "";
                sqlNombre = "UPDATE Socio SET Deuda = " + DeudaCliente.ToString() + " WHERE IdSocio = " + Socio;

                conexion.ConnectionString = CadenaConexion;
                conexion.Open();
                comando.Connection = conexion;
                comando.CommandType = CommandType.Text;
                comando.CommandText = sqlNombre;
                //MessageBox.Show(sqlNombre); utilizo para saber si la instruccion sql es correcta
                comando.ExecuteNonQuery();
                conexion.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        public void Eliminar(Int32 Socio)
        {
            try
            {
                String sqlnombre = "";
                sqlnombre = "DELETE * FROM Socio WHERE IdSocio =" + Socio.ToString();

                conexion.ConnectionString = CadenaConexion;
                conexion.Open();
                comando.Connection = conexion;
                comando.CommandType = CommandType.Text;
                comando.CommandText = sqlnombre;
                comando.ExecuteNonQuery();
                conexion.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        public void CargarComboNombre(ComboBox combo)
        {

            try
            {
                conexion.ConnectionString = CadenaConexion;
                conexion.Open();
                comando.Connection = conexion;
                comando.CommandType = CommandType.TableDirect;
                comando.CommandText = Tabla;
                adaptador = new OleDbDataAdapter(comando);
                DataSet DS = new DataSet();
                adaptador.Fill(DS, Tabla);

                combo.DataSource = DS.Tables[Tabla];
                combo.DisplayMember = "Nombre";
                combo.ValueMember = "IdSocio";

                conexion.Close();
            }
            catch (Exception e)
            {
                MessageBox.Show(e.ToString());
            }
        }     
        public void BuscarPorNombre(String Cliente)
        {
            try
            {
                conexion.ConnectionString = CadenaConexion;
                conexion.Open();
                comando.Connection = conexion;
                comando.CommandType = CommandType.TableDirect;
                comando.CommandText = Tabla;
                OleDbDataReader DR = comando.ExecuteReader();
                idSoc = 0;
                if (DR.HasRows)
                {
                    while (DR.Read())
                    {
                        if (Cliente == DR.GetString(1))
                        {

                            idSoc = DR.GetInt32(0);
                            nom = DR.GetString(1);
                            direc = DR.GetString(2);
                            idBarr = DR.GetInt32(3);
                            idAct = DR.GetInt32(4);
                            deu = DR.GetDecimal(5);

                        }
                    }
                }
                conexion.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }
        public void ListarClientes(DataGridView Grilla)
        {
            try
            {
                conexion.ConnectionString = CadenaConexion;
                conexion.Open();
                comando.Connection = conexion;
                comando.CommandType = CommandType.TableDirect;
                comando.CommandText = Tabla;

                OleDbDataReader DR = comando.ExecuteReader();
                Grilla.Rows.Clear();
                Promedio = 0;
                Deuda = 0;
                DeudaMayor = 0;
                DeudaMenor = 0;
                Cantidad = 0;
                if (DR.HasRows)
                {
                    while (DR.Read())
                    {                        
                        Grilla.Rows.Add(DR.GetInt32(0), DR.GetString(1), DR.GetDecimal(5));
                        
                        if (DR.GetDecimal(5) > DeudaMayor)
                        {
                            DeudaMayor = DR.GetDecimal(5);
                        }
                        if (DR.GetDecimal(5) < DeudaMenor)
                        {
                            DeudaMenor = DR.GetDecimal(5);
                        }
                        Deuda = Deuda + DR.GetDecimal(5);
                        Cantidad++;

                    }
                }
                Promedio = Deuda / Cantidad;
                conexion.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        public void GenerarReporte()
        {
            try
            {
                conexion.ConnectionString = CadenaConexion;
                conexion.Open();
                comando.Connection = conexion;
                comando.CommandType = CommandType.TableDirect;
                comando.CommandText = Tabla;
                OleDbDataReader DR = comando.ExecuteReader();

                StreamWriter AD = new StreamWriter("ReporteSocios.csv", false, Encoding.UTF8);
                AD.WriteLine("Listado de socios\n"); 
                AD.WriteLine("Codigo; Nombre; Deuda");

                Cantidad = 0;
                Deuda = 0;
                if (DR.HasRows)
                {
                    while (DR.Read())
                    {

                        AD.Write(DR.GetInt32(0));
                        AD.Write(";");
                        AD.Write(DR.GetString(1));
                        AD.Write(";");
                        AD.WriteLine(DR.GetDecimal(5));

                        if (DR.GetDecimal(5) > DeudaMayor)
                        {
                            DeudaMayor = DR.GetDecimal(5);
                        }
                        if (DR.GetDecimal(5) < DeudaMenor)
                        {
                            DeudaMenor = DR.GetDecimal(5);
                        }
                        Deuda = Deuda + DR.GetDecimal(5);
                        Cantidad++;
                        Promedio = Deuda / Cantidad;

                    }
                    AD.Write("\nCantidad de clientes: ; ");
                    AD.WriteLine(Cantidad);
                    AD.Write("Cantidad de deuda: ; ");
                    AD.WriteLine(Deuda);
                    AD.Write("Promedio de deuda: ; ");
                    AD.WriteLine(Promedio);
                    AD.Write("Deuda mayor: ; ");
                    AD.WriteLine(DeudaMayor);
                    AD.Write("Deuda Menor: ; ");
                    AD.WriteLine(DeudaMenor);
                }

                conexion.Close();
                AD.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }
        public void ListarClientesDeudores(DataGridView Grilla)
        {
            try
            {
                conexion.ConnectionString = CadenaConexion;
                conexion.Open();
                comando.Connection = conexion;
                comando.CommandType = CommandType.TableDirect;
                comando.CommandText = Tabla;

                OleDbDataReader DR = comando.ExecuteReader();
                Grilla.Rows.Clear();
                Promedio = 0;
                Deuda = 0;
                DeudaMayor = 0;
                DeudaMenor = 0;
                Cantidad = 0;
                if (DR.HasRows)
                {
                    while (DR.Read())
                    {
                        if (DR.GetDecimal(5) > 0)
                        {
                            Grilla.Rows.Add(DR.GetInt32(0), DR.GetString(1), DR.GetDecimal(5));

                            if (DR.GetDecimal(5) > DeudaMayor)
                            {
                                DeudaMayor = DR.GetDecimal(5);
                            }
                            if (DR.GetDecimal(5) < DeudaMenor)
                            {
                                DeudaMenor = DR.GetDecimal(5);
                            }
                            Deuda = Deuda + DR.GetDecimal(5);
                            Cantidad++;
                        }
                    }
                }
                Promedio = Deuda / Cantidad;
                conexion.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        public void GenerarReporteDeudores()
        {
            try
            {
                conexion.ConnectionString = CadenaConexion;
                conexion.Open();
                comando.Connection = conexion;
                comando.CommandType = CommandType.TableDirect;
                comando.CommandText = Tabla;
                OleDbDataReader DR = comando.ExecuteReader();

                StreamWriter AD = new StreamWriter("ReporteSociosDeudores.csv", false, Encoding.UTF8);
                AD.WriteLine("Listado de socios Deudores\n"); 
                AD.WriteLine("Codigo; Nombre; Deuda");

                Cantidad = 0;
                Deuda = 0;
                if (DR.HasRows)
                {
                    while (DR.Read())
                    {
                        if (DR.GetDecimal(5) > 0)
                        {
                            AD.Write(DR.GetInt32(0));
                            AD.Write(";");
                            AD.Write(DR.GetString(1));
                            AD.Write(";");
                            AD.WriteLine(DR.GetDecimal(5));

                            if (DR.GetDecimal(5) > DeudaMayor)
                            {
                                DeudaMayor = DR.GetDecimal(5);
                            }
                            if (DR.GetDecimal(5) < DeudaMenor)
                            {
                                DeudaMenor = DR.GetDecimal(5);
                            }
                            Deuda = Deuda + DR.GetDecimal(5);
                            Cantidad++;
                            Promedio = Deuda / Cantidad;
                        }

                    }
                    AD.Write("\nCantidad de clientes: ; ");
                    AD.WriteLine(Cantidad);
                    AD.Write("Cantidad de deuda: ; ");
                    AD.WriteLine(Deuda);
                    AD.Write("Promedio de deuda: ; ");
                    AD.WriteLine(Promedio.ToString("0.00"));
                    AD.Write("Deuda mayor: ; ");
                    AD.WriteLine(DeudaMayor);
                    AD.Write("Deuda Menor: ; ");
                    AD.WriteLine(DeudaMenor);
                }

                conexion.Close();
                AD.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }
        public void ListarClienteActividad(DataGridView Grilla, Int32 idActividad)
        {
            try
            {
                conexion.ConnectionString = CadenaConexion;
                conexion.Open();
                comando.Connection = conexion;
                comando.CommandType = CommandType.TableDirect;
                comando.CommandText = Tabla;
                OleDbDataReader DR = comando.ExecuteReader();
                Grilla.Rows.Clear();
                if (DR.HasRows)
                {
                    while (DR.Read())
                    {
                        if (DR.GetInt32(4) == idActividad)
                        {
                            Grilla.Rows.Add(DR.GetInt32(0), DR.GetString(1), DR.GetDecimal(5));

                            if (DR.GetDecimal(5) > DeudaMayor)
                            {
                                DeudaMayor = DR.GetDecimal(5);
                            }
                            if (DR.GetDecimal(5) < DeudaMenor)
                            {
                                DeudaMenor = DR.GetDecimal(5);
                            }
                            Deuda = Deuda + DR.GetDecimal(5);
                            Cantidad++;
                        }

                    }
                }
                Promedio = Deuda / Cantidad;
                conexion.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        public void GenerarReporteActividad(Int32 idActividad, string nombreActividad)
        {
            try
            {
                conexion.ConnectionString = CadenaConexion;
                conexion.Open();
                comando.Connection = conexion;
                comando.CommandType = CommandType.TableDirect;
                comando.CommandText = Tabla;
                OleDbDataReader DR = comando.ExecuteReader();
                StreamWriter AD = new StreamWriter("ReporteSociosPorActividad.csv", false, Encoding.UTF8);
                                
                Cantidad = 0;
                Deuda = 0;         
                actividadElegida = nombreActividad;
                

                AD.WriteLine("Listado de socios de " + actividadElegida);
                AD.Write("\n");
                AD.WriteLine("Codigo; Nombre; Deuda");
                if (DR.HasRows)
                {
                    while (DR.Read())
                    {
                        if (DR.GetInt32(4) == idActividad)
                        {
                            
                            AD.Write(DR.GetInt32(0));
                            AD.Write(";");
                            AD.Write(DR.GetString(1));
                            AD.Write(";");
                            AD.WriteLine(DR.GetDecimal(5));

                            if (DR.GetDecimal(5) > DeudaMayor)
                            {
                                DeudaMayor = DR.GetDecimal(5);
                            }
                            if (DR.GetDecimal(5) < DeudaMenor)
                            {
                                DeudaMenor = DR.GetDecimal(5);
                            }
                            Deuda = Deuda + DR.GetDecimal(5);
                            Cantidad++;
                            Promedio = Deuda / Cantidad;
                        }

                    }
                    AD.Write("\nCantidad de clientes: ; ");
                    AD.WriteLine(Cantidad);
                    AD.Write("Cantidad de deuda: ; ");
                    AD.WriteLine(Deuda);
                    AD.Write("Promedio de deuda: ; ");
                    AD.WriteLine(Promedio.ToString("0.00"));
                    AD.Write("Deuda mayor: ; ");
                    AD.WriteLine(DeudaMayor);
                    AD.Write("Deuda Menor: ; ");
                    AD.WriteLine(DeudaMenor);
                }

                conexion.Close();
                AD.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        public void ListarClienteBarrio(DataGridView Grilla, Int32 idBarrio)
        {
            try
            {
                conexion.ConnectionString = CadenaConexion;
                conexion.Open();
                comando.Connection = conexion;
                comando.CommandType = CommandType.TableDirect;
                comando.CommandText = Tabla;
                OleDbDataReader DR = comando.ExecuteReader();
                Grilla.Rows.Clear();
                if (DR.HasRows)
                {
                    while (DR.Read())
                    {
                        if (DR.GetInt32(3) == idBarrio)
                        {
                            Grilla.Rows.Add(DR.GetInt32(0), DR.GetString(1), DR.GetDecimal(5));

                            if (DR.GetDecimal(5) > DeudaMayor)
                            {
                                DeudaMayor = DR.GetDecimal(5);
                            }
                            if (DR.GetDecimal(5) < DeudaMenor)
                            {
                                DeudaMenor = DR.GetDecimal(5);
                            }
                            Deuda = Deuda + DR.GetDecimal(5);
                            Cantidad++;

                        }

                    }
                }
              
                Promedio = Deuda / Cantidad;
                conexion.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        public void GenerarReporteBarrio(Int32 idBarrio, string nombreBarrio)
        {
            try
            {
                conexion.ConnectionString = CadenaConexion;
                conexion.Open();
                comando.Connection = conexion;
                comando.CommandType = CommandType.TableDirect;
                comando.CommandText = Tabla;
                OleDbDataReader DR = comando.ExecuteReader();
                StreamWriter AD = new StreamWriter("ReporteSociosPorBarrio.csv", false, Encoding.UTF8);

                Cantidad = 0;
                Deuda = 0;
                barrioElegido = nombreBarrio;


                AD.WriteLine("Listado de socios de barrio " + barrioElegido);
                AD.Write("\n");
                AD.WriteLine("Codigo; Nombre; Deuda");
                if (DR.HasRows)
                {
                    while (DR.Read())
                    {
                        if (DR.GetInt32(3) == idBarrio)
                        {

                            AD.Write(DR.GetInt32(0));
                            AD.Write(";");
                            AD.Write(DR.GetString(1));
                            AD.Write(";");
                            AD.WriteLine(DR.GetDecimal(5));

                            if (DR.GetDecimal(5) > DeudaMayor)
                            {
                                DeudaMayor = DR.GetDecimal(5);
                            }
                            if (DR.GetDecimal(5) < DeudaMenor)
                            {
                                DeudaMenor = DR.GetDecimal(5);
                            }
                            Deuda = Deuda + DR.GetDecimal(5);
                            Cantidad++;
                            Promedio = Deuda / Cantidad;
                        }

                    }
                    AD.Write("\nCantidad de clientes: ; ");
                    AD.WriteLine(Cantidad);
                    AD.Write("Cantidad de deuda: ; ");
                    AD.WriteLine(Deuda);
                    AD.Write("Promedio de deuda: ; ");
                    AD.WriteLine(Promedio.ToString("0.00"));
                    AD.Write("Deuda mayor: ; ");
                    AD.WriteLine(DeudaMayor);
                    AD.Write("Deuda Menor: ; ");
                    AD.WriteLine(DeudaMenor);
                }

                conexion.Close();
                AD.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        public void Imprimir(PrintPageEventArgs reporte)//mismo que el del formulario 
        {
            try
            {
                Font LetraTitulo = new Font("Arial", 26);
                Font LetraSubtitulo = new Font("Arial", 18);
                Font tipoLetra = new Font("Arial", 14);
                Int32 filaRecorrido = 200;
                reporte.Graphics.DrawString("Listado de socios", LetraTitulo, Brushes.Blue, 100, 100);
                reporte.Graphics.DrawString("ID Socio", LetraSubtitulo, Brushes.Red, 100, 160);
                reporte.Graphics.DrawString("Nombre de socio", LetraSubtitulo, Brushes.Red, 220, 160);
                reporte.Graphics.DrawString("Deuda de socio", LetraSubtitulo, Brushes.Red, 450, 160);
                conexion.ConnectionString = CadenaConexion;
                conexion.Open();
                comando.Connection = conexion;
                comando.CommandType = CommandType.TableDirect;
                comando.CommandText = Tabla;
                adaptador = new OleDbDataAdapter(comando);
                DataSet DS = new DataSet();
                adaptador.Fill(DS, Tabla);
                if (DS.Tables[Tabla].Rows.Count >0 )
                {
                    foreach (DataRow fila in DS.Tables[Tabla].Rows)
                    {
                        reporte.Graphics.DrawString(fila["IdSocio"].ToString(), tipoLetra, Brushes.Black, 100, filaRecorrido);
                        reporte.Graphics.DrawString(fila["Nombre"].ToString(), tipoLetra, Brushes.Black, 220, filaRecorrido);
                        reporte.Graphics.DrawString(fila["Deuda"].ToString(), tipoLetra, Brushes.Black, 450, filaRecorrido);
                        filaRecorrido = filaRecorrido + 22;
                    }
                }                
                conexion.Close();
            }
            catch (Exception e)
            {

                MessageBox.Show(e.Message);
            }
        }
        public void ImprimirDeudores (PrintPageEventArgs reporte, DataGridView Grilla)
        {
            try
            {
                Font LetraTitulo = new Font("Arial", 26);
                Font LetraSubtitulo = new Font("Arial", 18);
                Font tipoLetra = new Font("Arial", 14);
                Int32 filaRecorrido = 200;
                reporte.Graphics.DrawString("Listado de socios deudores", LetraTitulo, Brushes.Blue, 100, 100);
                reporte.Graphics.DrawString("ID Socio", LetraSubtitulo, Brushes.Red, 100, 160);
                reporte.Graphics.DrawString("Nombre de socio", LetraSubtitulo, Brushes.Red, 220, 160);
                reporte.Graphics.DrawString("Deuda de socio", LetraSubtitulo, Brushes.Red, 450, 160);
                conexion.ConnectionString = CadenaConexion;
                conexion.Open();
                comando.Connection = conexion;
                comando.CommandType = CommandType.TableDirect;
                comando.CommandText = Tabla;
                OleDbDataReader DR = comando.ExecuteReader();
                Grilla.Rows.Clear();
                if (DR.HasRows)
                {
                    while (DR.Read())
                    {
                        if (DR.GetDecimal(5) > 0)
                        {

                            reporte.Graphics.DrawString(DR.GetInt32(0).ToString(), tipoLetra, Brushes.Black, 100, filaRecorrido);
                            reporte.Graphics.DrawString(DR.GetString(1).ToString(), tipoLetra, Brushes.Black, 220, filaRecorrido);
                            reporte.Graphics.DrawString(DR.GetDecimal(5).ToString(), tipoLetra, Brushes.Black, 450, filaRecorrido);
                            filaRecorrido = filaRecorrido + 22;
                        }
                    }
                }
                
                conexion.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        public void ImprimirSocioActividad(PrintPageEventArgs reporte, DataGridView Grilla, Int32 idActividad, String nombreActividad)
        {
            try
            {
                Font LetraTitulo = new Font("Arial", 26);
                Font LetraSubtitulo = new Font("Arial", 18);
                Font tipoLetra = new Font("Arial", 14);
                Int32 filaRecorrido = 240;
                reporte.Graphics.DrawString("Listado de socios por actividad:", LetraTitulo, Brushes.Blue, 100, 100);
                reporte.Graphics.DrawString(nombreActividad, LetraTitulo, Brushes.Green, 100, 140);
                reporte.Graphics.DrawString("ID Socio", LetraSubtitulo, Brushes.Red, 100, 200);
                reporte.Graphics.DrawString("Nombre de socio", LetraSubtitulo, Brushes.Red, 220, 200);
                reporte.Graphics.DrawString("Deuda de socio", LetraSubtitulo, Brushes.Red, 450, 200);
                conexion.ConnectionString = CadenaConexion;
                conexion.Open();
                comando.Connection = conexion;
                comando.CommandType = CommandType.TableDirect;
                comando.CommandText = Tabla;
                OleDbDataReader DR = comando.ExecuteReader();
                Grilla.Rows.Clear();
                if (DR.HasRows)
                {
                    while (DR.Read())
                    {
                        if (DR.GetInt32(4) == idActividad)
                        {

                            reporte.Graphics.DrawString(DR.GetInt32(0).ToString(), tipoLetra, Brushes.Black, 100, filaRecorrido);
                            reporte.Graphics.DrawString(DR.GetString(1).ToString(), tipoLetra, Brushes.Black, 220, filaRecorrido);
                            reporte.Graphics.DrawString(DR.GetDecimal(5).ToString(), tipoLetra, Brushes.Black, 450, filaRecorrido);
                            filaRecorrido = filaRecorrido + 22;

                        }                        
                    }
                }

                conexion.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        public void ImprimirSocioBarrio(PrintPageEventArgs reporte, DataGridView Grilla, Int32 idBarrio, String nombreBarrio)
        {
            try
            {
                Font LetraTitulo = new Font("Arial", 26);
                Font LetraSubtitulo = new Font("Arial", 18);
                Font tipoLetra = new Font("Arial", 14);
                Int32 filaRecorrido = 240;
                reporte.Graphics.DrawString("Listado de socios por barrio:", LetraTitulo, Brushes.Blue, 100, 100);
                reporte.Graphics.DrawString(nombreBarrio, LetraTitulo, Brushes.Green, 100, 140);
                reporte.Graphics.DrawString("ID Socio", LetraSubtitulo, Brushes.Red, 100, 200);
                reporte.Graphics.DrawString("Nombre de socio", LetraSubtitulo, Brushes.Red, 220, 200);
                reporte.Graphics.DrawString("Deuda de socio", LetraSubtitulo, Brushes.Red, 450, 200);
                conexion.ConnectionString = CadenaConexion;
                conexion.Open();
                comando.Connection = conexion;
                comando.CommandType = CommandType.TableDirect;
                comando.CommandText = Tabla;
                OleDbDataReader DR = comando.ExecuteReader();
                Grilla.Rows.Clear();
                if (DR.HasRows)
                {
                    while (DR.Read())
                    {
                        if (DR.GetInt32(3) == idBarrio)
                        {

                            reporte.Graphics.DrawString(DR.GetInt32(0).ToString(), tipoLetra, Brushes.Black, 100, filaRecorrido);
                            reporte.Graphics.DrawString(DR.GetString(1).ToString(), tipoLetra, Brushes.Black, 220, filaRecorrido);
                            reporte.Graphics.DrawString(DR.GetDecimal(5).ToString(), tipoLetra, Brushes.Black, 450, filaRecorrido);
                            filaRecorrido = filaRecorrido + 22;

                        }
                    }
                }

                conexion.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

    }
}
