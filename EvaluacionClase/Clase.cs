using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace EvaluacionClase
{
    public partial class Clase : Form
    {
        public Clase()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Promedio estudiante = new Promedio(textBoxNombre.Text, Convert.ToInt32(textBoxCuenta.Text), Convert.ToInt32(textBoxNota1.Text), Convert.ToInt32(textBoxNota2.Text), Convert.ToInt32(textBoxNota3.Text), Convert.ToInt32(textBoxNota4.Text));
            
            MessageBox.Show(estudiante.devolverNombreCuenta());
            textBoxTotal.Text = (estudiante.devolverPromedio()).ToString();
            MessageBox.Show(estudiante.devolverPasar());


        }
}
}
