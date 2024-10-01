using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PROYECTO_FINAL_FÍSICA
{
    public partial class Form22 : Form
    {
        public Form22()
        {
            InitializeComponent();
        }

        private void btsalir_Click(object sender, EventArgs e)
        {
            //Permitte salir del formulario
            this.Dispose();
        }

        private void btlimpiar_Click(object sender, EventArgs e)
        {
            //Limpia los textbox para poder seguir calculando
            txt1.Text = "";
            txt2.Text = "";
            txt3.Text = "";
            txt4.Text = "";
        }

        private void btcalcular_Click(object sender, EventArgs e)
        {
            //Declaramos las variables
            double valor1, valor2, valor3, valorfinal;
            //Elegir que combobox vamos a calcular
            if (comElegir1.SelectedItem.ToString() == "Altura km")
            {
                //Le damos valor a las variables
                valor1 = Convert.ToDouble(txt1.Text);
                valor2 = Convert.ToDouble(txt2.Text);
                valor3 = Convert.ToDouble(txt3.Text);
                valorfinal = valor1 * valor2 + (valor3 * (valor2 * valor2) / 2);
                txt4.Text = (valorfinal+" km");

            }
            else if (comElegir1.SelectedItem.ToString() == "Velocidad Inicial km/h")
            {
                valor1 = Convert.ToDouble(txt1.Text);
                valor2 = Convert.ToDouble(txt2.Text);
                valor3 = Convert.ToDouble(txt3.Text);
                valorfinal = (valor1 - valor2) * valor3;
                txt4.Text = (valorfinal+" km/h");

            }
            else if (comElegir1.SelectedItem.ToString() == "Velocidad Final km/h")
            {
                valor1 = Convert.ToDouble(txt1.Text);
                valor2 = Convert.ToDouble(txt2.Text);
                valor3 = Convert.ToDouble(txt3.Text);
                valorfinal = 2*(valor1 / valor2) - valor3;
                txt4.Text = (valorfinal+" km/h");

            }
            else if (comElegir1.SelectedItem.ToString() == "Tiempo h")
            {
                valor1 = Convert.ToDouble(txt1.Text);
                valor2 = Convert.ToDouble(txt2.Text);
                valor3 = Convert.ToDouble(txt3.Text);
                valorfinal = (valor1 - valor2) / valor3;
                txt4.Text = (valorfinal+" h");

            }
            else if (comElegir1.SelectedItem.ToString() == "Gravedad m/s")
            {
                valor1 = Convert.ToDouble(txt1.Text);
                valor2 = Convert.ToDouble(txt2.Text);
                valor3 = Convert.ToDouble(txt3.Text);
                valorfinal = (valor1 - valor2) / valor3;
                txt4.Text = (valorfinal+" m/s");

            }

        }

        private void comElegir1_SelectedIndexChanged(object sender, EventArgs e)
        {
            //Elegir el combobox que se va a calcular

            if (comElegir1.SelectedItem.ToString() == "Altura km")
            {
                //Seleccionamos los datos a calcular
                lbl1.Text = "Velocidad Inicial km/h";
                lbl2.Text = "Tiempo h";
                lbl3.Text = "Gravedad m/s";
                lbl4.Text = "El Resultado es:";
                //Se utiliza para que el usuario no escriba en el textbox resultado
                txt1.BackColor = Color.White;
                txt2.BackColor = Color.White;
                txt3.BackColor = Color.White;
                txt4.BackColor = Color.White;
                //Bloqueamos las casillas que no vamos a utilizar
                txt1.ReadOnly = false;
                txt2.ReadOnly = false;
                txt3.ReadOnly = false;
                txt4.ReadOnly = true;

            }
            else if (comElegir1.SelectedItem.ToString() == "Velocidad Inicial km/h")
            {
                //Seleccionamos los datos a calcular
                lbl1.Text = "Velocidad Final km/h";
                lbl2.Text = "Gravedad m/s";
                lbl3.Text = "Tiempo h";
                lbl4.Text = "El Resultado es:";
                //Se utiliza para que el usuario no escriba en el textbox resultado
                txt1.BackColor = Color.White;
                txt2.BackColor = Color.White;
                txt3.BackColor = Color.White;
                txt4.BackColor = Color.White;
                //Bloqueamos las casillas que no vamos a utilizar
                txt1.ReadOnly = false;
                txt2.ReadOnly = false;
                txt3.ReadOnly = false;
                txt4.ReadOnly = true;

            }
            else if (comElegir1.SelectedItem.ToString() == "Velocidad Final km/h")
            {
                //Seleccionamos los datos a calcular
                lbl1.Text = "Altura km";
                lbl2.Text = "Tiempo h";
                lbl3.Text = "Velocidad Inicial km/h";
                lbl4.Text = "El Resultado es:";
                //Se utiliza para que el usuario no escriba en el textbox resultado
                txt1.BackColor = Color.White;
                txt2.BackColor = Color.White;
                txt3.BackColor = Color.White;
                txt4.BackColor = Color.White;
                //Bloqueamos las casillas que no vamos a utilizar
                txt1.ReadOnly = false;
                txt2.ReadOnly = false;
                txt3.ReadOnly = false;
                txt4.ReadOnly = true;

            }
            else if (comElegir1.SelectedItem.ToString() == "Tiempo h")
            {
                //Seleccionamos los datos a calcular
                lbl1.Text = "Velocidad Final km/h";
                lbl2.Text = "Velocidad Inicial km/h";
                lbl3.Text = "Gravedad m/s";
                lbl4.Text = "El Resultado es:";
                //Se utiliza para que el usuario no escriba en el textbox resultado
                txt1.BackColor = Color.White;
                txt2.BackColor = Color.White;
                txt3.BackColor = Color.White;
                txt4.BackColor = Color.White;
                //Bloqueamos las casillas que no vamos a utilizar
                txt1.ReadOnly = false;
                txt2.ReadOnly = false;
                txt3.ReadOnly = false;
                txt4.ReadOnly = true;

            }
            else if (comElegir1.SelectedItem.ToString() == "Gravedad m/s")
            {
                //Seleccionamos los datos a calcular
                lbl1.Text = "Velocidad Final km/h";
                lbl2.Text = "Velocidad Inicial km/h";
                lbl3.Text = "Tiempo h";
                lbl4.Text = "El Resultado es:";
                //Se utiliza para que el usuario no escriba en el textbox resultado
                txt1.BackColor = Color.White;
                txt2.BackColor = Color.White;
                txt3.BackColor = Color.White;
                txt4.BackColor = Color.White;
                //Bloqueamos las casillas que no vamos a utilizar
                txt1.ReadOnly = false;
                txt2.ReadOnly = false;
                txt3.ReadOnly = false;
                txt4.ReadOnly = true;

            }
        }

        private void btatras_Click(object sender, EventArgs e)
        {
            //Nos llevara al formularo de calculadora de Tiro Vertical
            this.Hide();

            Form12 frmTirocalculadora = new Form12();
            frmTirocalculadora.Show();
        }
    
    }
}
