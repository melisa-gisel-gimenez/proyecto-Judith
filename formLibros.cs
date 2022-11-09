using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using capa_Entidades;
using Entidades;

namespace capaPresentacion
{
    public partial class formLibros : Form
    {
        Libros NuevoLibro;
        Libros LibrosExistente;
        //NegLibros objNegProducto = new NegLibros();
        bool nuevo = true;
        //int fila;

        public formLibros()
        {
            InitializeComponent();
        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            //this.Close();
            //formListaLibros formLL = new formListaLibros();
            //formLL.Show();

            Libros NuevoLibro;
            NuevoLibro = new Libros(textBox_TITULO.Text, textBox_UBICACION.Text, checkBox1.Checked,dateTime_FECHAALTA.Value);

            Autor NuevoAutor;
            NuevoAutor = new Autor(comboBox_NOMBRE_AUTOR.Text, comboBox_APELLIDO_AUTOR.Text);

            Editorial NuevaEditorial;
            NuevaEditorial = new Editorial(comboBox_EDITORIAL.Text);

            Genero NuevoGenero;
            NuevoGenero = new Genero(comboBox_GENERO.Text);
        
        }

        private void btnSALIR_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void label9_Click(object sender, EventArgs e)
        {

        }

        private void boton_ALTA_AUTOR_Click(object sender, EventArgs e)
        {
            this.Close();
            //llamar al form autor
            formAutor frmAut = new formAutor();
            frmAut.Show();

        }

        private void boton_ALTA_EDITORIAL_Click(object sender, EventArgs e)
        {
            this.Close();
            //llamar al form de editorial
            formEditorial frmEdit = new formEditorial();
            frmEdit.Show();
        }

        private void boton_ALTA_GENERO_Click(object sender, EventArgs e)
        {
            this.Close();
            formGenero frmGen = new formGenero();
            frmGen.Show();
        }
    }
}
