using CapaNegocio;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace capaPresentacion
{
    public partial class PPrin : Form
    {
        public PPrin()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void generoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            formGenero frm = new formGenero();
            frm.Show();
        }

        private void librosToolStripMenuItem_Click(object sender, EventArgs e)
        {
           
            formListaLibros frmListaLibs = new formListaLibros();
            frmListaLibs.Show();            
            
        }

        private void conexionToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Negocio negocio = new Negocio();
            if (negocio.probarConexion())
                    {
                MessageBox.Show("Conexion exitosa");
            }
            else
            { 
                MessageBox.Show("No se pudo conectar a la base de datos"); 
            }
            
        }

        private void salirToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
