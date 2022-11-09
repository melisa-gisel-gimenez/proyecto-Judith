using capa_Entidades;
using capaPresentacion;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Entidades
{
    public partial class formAutor : Form
    {
        public formAutor()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            //llamar al formautor
            Autor NuevoAutor;
            NuevoAutor = new Autor(textBox_Alta_Nombre_Autor.Text, textBox_Alta_Apellido_Autor.Text);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
            formLibros frmLib = new formLibros();
            frmLib.Show();
        }
    }
}
