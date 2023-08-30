using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Calculadora
{
    //Calculadora Simple
    //Chocobar Matias Sebastian
    //Estudiante de Programador Universitario - UTN - Tucuman -Argentina
    public partial class Form1 : Form
    {
        private double Numero1;
        private double Numero2;
        private double Resultado;
        private int opcion;
        private double porcentaje;

        public Form1()
        {
            InitializeComponent();
        }

        public void Igualdad()
        {
          
        }
        private void button18_Click(object sender, EventArgs e)
        {
            //boton + suma
            Numero1 = Convert.ToDouble(label1.Text);
            opcion = 1;           
            label1.Text= "";
            
        }

        private void button6_Click(object sender, EventArgs e)
        {
            //Boton numero 1
            label1.Text = label1.Text+ "1";
        }

        private void button3_Click(object sender, EventArgs e)
        {
            //boton numero 2
            label1.Text = label1.Text+ "2";
        }

        private void button16_Click(object sender, EventArgs e)
        {
            //boton nummero 3
            label1.Text = label1.Text+ "3";
        }

        private void button11_Click(object sender, EventArgs e)
        {
            //boton numero 4
            label1.Text = label1.Text+"4";
        }

        private void button2_Click(object sender, EventArgs e)
        {
            //boton numero 5
            label1.Text = label1.Text+ "5";
        }

        private void button15_Click(object sender, EventArgs e)
        {
            //boton numero 6
            label1.Text = label1.Text+"6";
        }

        private void button12_Click(object sender, EventArgs e)
        {
            //boton numero 7
            label1.Text = label1.Text+ "7";
        }

        private void button1_Click(object sender, EventArgs e)
        {
            //boton numero 8
            label1.Text = label1.Text+"8";
        }

        private void button14_Click(object sender, EventArgs e)
        {
            //boton numero 9
            label1.Text = label1.Text+ "9";
        }

        private void button5_Click(object sender, EventArgs e)
        {
            //boton numero 0
            label1.Text = "0";
        }

        private void button4_Click(object sender, EventArgs e)
        {
            //boton .
            label1.Text = label1.Text+",";
            //label3.Text = label1.Text;
        }

        private void button17_Click(object sender, EventArgs e)
        {
            //boton con los dos decimales
            label1.Text = label1.Text + "00";
        }

        private void button20_Click(object sender, EventArgs e)
        {
            //boton = igual
            Numero2 = Convert.ToDouble(label1.Text);
            do {
                switch (opcion)
                {
                    case 1:
                        //Suma
                        Resultado = Numero1 + Numero2;
                        label3.Text = $"{Numero1} + {Numero2}";
                        break;
                    case 2:
                        //Resta
                        Resultado = Numero1 - Numero2;
                        label3.Text = $"{Numero1} - {Numero2}";
                        break;
                    case 3:
                        //Producto
                        Resultado = Numero1 * Numero2;
                        label3.Text = $"{Numero1} x {Numero2}";
                        break;
                    case 4:
                        //Division
                        Resultado = Numero1 / Numero2;
                        label3.Text = $"{Numero1} / {Numero2}";
                        break;
                    case 5:
                        //Calculo de Raiz cuadrada
                        double raizCuadrada = Math.Sqrt(Numero1);
                        Resultado = raizCuadrada;
                        break;
                    case 6:
                        //Calculo de Potencia de un numero1 y numero 2 es la potencia
                        double potencia = Math.Pow(Numero1, Numero2);
                        Resultado = potencia;
                        label3.Text = $"{Numero1} ^ {Numero2}";
                        break;
                    case 0:
                        break;
                }
                opcion = 0;
            } while (opcion!=0);
            label2.Text = Resultado.ToString();
        }
        private void button19_Click(object sender, EventArgs e)
        {
            //boton X producto
            opcion = 3;
            Numero1 = Convert.ToDouble(label1.Text);
            label1.Text = "";
        }

        private void button9_Click(object sender, EventArgs e)
        {
            //boton - resta
            opcion = 2;
            Numero1 = Convert.ToDouble(label1.Text);
            label1.Text = "";
        }

        private void button13_Click(object sender, EventArgs e)
        {
            //boton / division
            opcion = 4;
            Numero1 = Convert.ToDouble(label1.Text);
            label1.Text = "";
        }

        private void button10_Click(object sender, EventArgs e)
        {
            //boton % porcentaje
            Numero1 = Convert.ToDouble(label1.Text);
            label3.Text = $"{Numero1} %";
            label1.Text = "";
            porcentaje = Numero1 / 100;
            label2.Text = $"{porcentaje}";
        }

        private void button23_Click(object sender, EventArgs e)
        {
            //AC - ALL CLEAR (Borra todo)
            label1.Text = "";
            label2.Text = "";
            label3.Text = "";
            label4.Text = "";
       
        }

        private void button22_Click(object sender, EventArgs e)
        {
            //C - Clear (boton borrar)
            label1.Text = "";
            label3.Text = "";
            label4.Text = "";
        }

        private void button21_Click(object sender, EventArgs e)
        {
            //boton raiz cuadrada
            opcion = 5;
            Numero1 = Convert.ToDouble(label1.Text);
            label3.Text = "√ " + label1.Text;
        }

        private void button8_Click(object sender, EventArgs e)
        {
            //Boton de +/- 
            label1.Text = "-" + label1.Text;
            Numero1 = Convert.ToDouble(label1.Text);    
            label3.Text = $"{Numero1}";
          
        }

        private void button7_Click(object sender, EventArgs e)
        {
            //boton potencia
            opcion = 6;
            Numero1 = Convert.ToDouble(label1.Text);
            label1.Text = "";            
        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void button18_ClientSizeChanged(object sender, EventArgs e)
        {

        }
    }
}
