using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace calculando_edad
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Btnsalir_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void Btnlimpiar_Click(object sender, EventArgs e)
        {
            lbledad.Text="";
        }

        private void Btncalcular_Click(object sender, EventArgs e)
        {
            DateTime fechana = fechadenacimiento.Value;
            int años = System.DateTime.Now.Year - fechana.Year;
            if (System.DateTime.Now.Subtract(fechana.AddYears(años)).TotalDays < 0)
                lbledad.Text = Convert.ToString(años - 1);
            else
                lbledad.Text = Convert.ToString(años);

        }
    }
}
