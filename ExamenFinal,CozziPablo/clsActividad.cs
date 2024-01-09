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

namespace ExamenFinal_CozziPablo
{
    internal class clsActividad
    {

        private Int32 idAct;
        private string nom;

        public Int32 idActividadSeleccionado;
        public string nombreActividadSeleccionado;

        public Int32 idActividad
        {
            get { return idAct; }
            set { idAct = value; }
        }
        public string Nombre
        {
            get { return nom; }
            set { nom = value; }
        }


        private OleDbConnection conexion = new OleDbConnection();
        private OleDbCommand comando = new OleDbCommand();
        private OleDbDataAdapter adaptador = new OleDbDataAdapter();

        private string CadenaConexion = "Provider=Microsoft.Jet.OLEDB.4.0;Data Source=BD_Clientes.mdb";
        private string Tabla = "Actividad";

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


                combo.DataSource = DS.Tables[0];
                combo.DisplayMember = "Nombre";
                combo.ValueMember = "idActividad";

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
                idAct = 0;
                if (DR.HasRows)
                {
                    while (DR.Read())
                    {
                        if (DR.GetInt32(0) == Cliente)
                        {

                            idAct = DR.GetInt32(0);
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
                combo.ValueMember = "idActividad";

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

                idActividadSeleccionado = (int)datoCombo["idActividad"];
                nombreActividadSeleccionado = (string)datoCombo["Nombre"];
            }
        }

    }
}
