using capa_Entidades;
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
    public partial class formEditorial : Form
    {
        public formEditorial()
        {
            InitializeComponent();
        }
                

        private void button_ALTA_EDITORIAL(object sender, EventArgs e)
        {
            Editorial AltaEditorial;
            AltaEditorial = new Editorial (textBox_Nombre_Alta_Editorial.Text, textBox_Editorial_Alta_Direccion.Text, int.Parse(textBox_Editorial_Telefono.Text), textBox_Editorial_email.Text);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
            formLibros frmLib = new formLibros();
            frmLib.Show();
        }
    }
}
