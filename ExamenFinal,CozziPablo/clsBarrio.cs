using System;
using System.Collections.Generic;
using System.Data.OleDb;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Security.Cryptography.X509Certificates;
using System.IO;
using System.Security.Cryptography;

namespace ExamenFinal_CozziPablo
{
    internal class clsBarrio
    {

        private Int32 idBarr;
        private string nom;

        public Int32 idBarrio
        {
            get { return idBarr; }
            set { idBarr = value; }
        }
        public string Nombre
        {
            get { return nom; }
            set { nom = value; }
        }

        public Int32 idBarrioSeleccionado;
        public string nombreBarrioSeleccionado;

        private OleDbConnection conexion = new OleDbConnection();
        private OleDbCommand comando = new OleDbCommand();
        private OleDbDataAdapter adaptador = new OleDbDataAdapter();

        private string CadenaConexion = "Provider=Microsoft.Jet.OLEDB.4.0;Data Source=BD_Clientes.mdb";
        private string Tabla = "Barrio";

        public void Cargar(ComboBox combo)
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
                combo.ValueMember = "idBarrio";

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
                idBarr = 0;
                if (DR.HasRows)
                {
                    while (DR.Read())
                    {
                        if (DR.GetInt32(0) == Cliente)
                        {

                            idBarr = DR.GetInt32(0);
                            nom = DR.GetString(1);

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

        public void CargarCombo(ComboBox combo)
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
                combo.ValueMember = "idBarrio";

                conexion.Close();
            }
            catch (Exception e)
            {
                MessageBox.Show(e.ToString());
            }
        }

        public void ObtenerSeleccionCombo(ComboBox combo)
        {
            if (combo.SelectedItem != null)
            {
                DataRowView datoCombo = (DataRowView)combo.SelectedItem;

                idBarrioSeleccionado = (int)datoCombo["idBarrio"];
                nombreBarrioSeleccionado = (string)datoCombo["Nombre"];
            }
        }




    }

}   


