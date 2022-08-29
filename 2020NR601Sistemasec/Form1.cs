using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _2020NR601Sistemasec
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void A1_3_TextChanged(object sender, EventArgs e)
        {

        }

        private void Cargar_Click(object sender, EventArgs e)
        {
            String resultado = "";
            double[][] matriz = new double[3][];
            matriz[0] = new double[4];
            matriz[1] = new double[4];
            matriz[2] = new double[4];
            try
            {


                matriz[0][0] = Convert.ToDouble(A1_1.Text);
                matriz[0][1] = Convert.ToDouble(A1_2.Text);
                matriz[0][2] = Convert.ToDouble(A1_3.Text);
                matriz[0][3] = Convert.ToDouble(A1_4.Text);

                matriz[1][0] = Convert.ToDouble(A2_1.Text);
                matriz[1][1] = Convert.ToDouble(A2_2.Text);
                matriz[1][2] = Convert.ToDouble(A2_3.Text);
                matriz[1][3] = Convert.ToDouble(A2_4.Text);


                matriz[2][0] = Convert.ToDouble(A3_1.Text);
                matriz[2][1] = Convert.ToDouble(A3_2.Text);
                matriz[2][2] = Convert.ToDouble(A3_3.Text);
                matriz[2][3] = Convert.ToDouble(A3_4.Text);

                //DETERMINANTE EN S
                double dd = (matriz[0][0] * matriz[1][1] * matriz[2][2]) + (matriz[1][0] * matriz[2][1] * matriz[0][2]) + (matriz[2][0] * matriz[0][1] * matriz[1][2]);
                double di = (matriz[0][2] * matriz[1][1] * matriz[2][0]) + (matriz[1][2] * matriz[2][1] * matriz[0][0]) + (matriz[2][2] * matriz[0][1] * matriz[1][0]);
                double dts = dd - di;
                //FIN DE DETERMINANTE EN S

                //valores x
                double ddx = (matriz[0][3] * matriz[1][1] * matriz[2][2]) + (matriz[1][3] * matriz[2][1] * matriz[0][2]) + (matriz[2][3] * matriz[0][1] * matriz[1][2]);
                double dix = (matriz[0][2] * matriz[1][1] * matriz[2][3]) + (matriz[1][2] * matriz[2][1] * matriz[0][3]) + (matriz[2][2] * matriz[0][1] * matriz[1][3]);
                double diagonalesx = ddx - dix;
                //FIN VALOR EN X
                //valores de respuesta en y
                double ddy = (matriz[0][0] * matriz[1][3] * matriz[2][2]) + (matriz[1][0] * matriz[2][3] * matriz[0][2]) + (matriz[2][0] * matriz[0][3] * matriz[1][2]);
                double diy = (matriz[0][2] * matriz[1][3] * matriz[2][0]) + (matriz[1][2] * matriz[2][3] * matriz[0][0]) + (matriz[2][2] * matriz[0][3] * matriz[1][0]);
                double diagonalesy = ddy - diy;
                //FIN DE VALORES EN Y
                //valores de respuesta en y
                double ddz = (matriz[0][0] * matriz[1][1] * matriz[2][3]) + (matriz[1][0] * matriz[2][1] * matriz[0][3]) + (matriz[2][0] * matriz[0][1] * matriz[1][3]);
                double diz = (matriz[0][3] * matriz[1][1] * matriz[2][0]) + (matriz[1][3] * matriz[2][1] * matriz[0][0]) + (matriz[2][3] * matriz[0][1] * matriz[1][0]);
                double diagonalesz = ddz - diz;
                //FIN VALORES DE RESPUESTA EN Y

                //calculando valores finales de variables
                double x = diagonalesx / dts;
                double y = diagonalesy / dts;
                double z = diagonalesz / dts;


                //llenando de de respuesta en x y y z

                label10.Text = "El valor de X = " + x;
                label11.Text = "El valor de Y = " + y;
                label12.Text = "El valor de Z = " + z;
                //determinatnte
                label13.Text = "Determinante del sistema= " + dts;
                //determinates en x y y z
                label14.Text = "Determinante de x= " + diagonalesx;
                label15.Text = "Determinante de y= " + diagonalesy;
                label16.Text = "Determinante de z= " + diagonalesz;

                //respuesta satisfactoria
                resultado = "Resultado generado con exito";
                MessageBox.Show(resultado);



            }
            catch 
            {
                resultado = "Por favor, revisa los valores."
                + "\nHaz agregado un dato invalido o los campos estan vacios";
                MessageBox.Show(resultado);


            }





        }

        private void label10_Click(object sender, EventArgs e)
        {

        }

        private void label11_Click(object sender, EventArgs e)
        {

        }

        private void Limpiar_Click(object sender, EventArgs e)
        {
            label10.Text = "El valor de X = ";
            label11.Text = "El valor de Y = ";
            label12.Text = "El valor de Z = ";
            label13.Text = "Determinante del sistema= ";
            label14.Text = "Determinante de x= ";
            label15.Text = "Determinante de y= ";
            label16.Text = "Determinante de z= ";
            A1_1.Text = "";
            A1_2.Text = "";
            A1_3.Text = "";
            A1_4.Text = "";
            A2_1.Text = "";
            A2_2.Text = "";
            A2_3.Text = "";
            A2_4.Text = "";
            A3_1.Text = "";
            A3_2.Text = "";
            A3_3.Text = "";
            A3_4.Text = "";


        }
    }
}
