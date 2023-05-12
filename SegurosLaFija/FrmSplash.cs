using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SegurosLaFija
{
    public partial class FrmSplash : Form
    {
        int tiempo = 0;
        public FrmSplash()
        {
            InitializeComponent();
        }

        private void FrmSplash_Load(object sender, EventArgs e)
        {
     
            timer1.Interval = 10;
            timer1.Start();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            if(tiempo<4000)
            {
               tiempo += 40;
                progressBar1.Value += 1;
            }else
            {
                this.Close();
                timer1.Stop();
            }
        }

        private void FrmSplash_Paint(object sender, PaintEventArgs e)
        {
           /* Graphics graphics = e.Graphics;

            //Definimos el tamano del rectangulo, con las mismas medidas del formulario
            Rectangle gradient_rectangle = new Rectangle(0, 0, Width, Height);

            //definimos las propiedades del gradiente
            //Figura, color inicio, color fin y angulo
            Brush b = new LinearGradientBrush(gradient_rectangle, Color.FromArgb(176, 218, 255), Color.FromArgb(25, 167, 206), 65);

            //Aplicamos el gradiente        
            graphics.FillRectangle(b, gradient_rectangle);*/
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}
