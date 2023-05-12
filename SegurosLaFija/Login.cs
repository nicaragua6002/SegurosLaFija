using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SegurosLaFija
{
    public partial class Login : Form
    {
        int intentos = 3;
        public Login()
        {
            InitializeComponent();
        }

        private void btnAceptar_Click(object sender, EventArgs e)
        {
            if(intentos>1)
            {
                if(txtUser.Text=="Juan"&&txtPass.Text=="123456")
                {
                    this.Hide();
                    FrmMainMenu Principal = new FrmMainMenu();
                    Principal.ShowDialog();
                    this.Close();
                }
                else
                {
                    intentos--;
                    MessageBox.Show($"Credenciales no validas \nRestan: {intentos} intentos", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                   
                }
            }
            else
            {
                MessageBox.Show("Lo sentimos, se acabaron los intentos", "Confirmar", MessageBoxButtons.OK);
                Close();

            }
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Esta seguro que quiere salir?", "Confirmar", MessageBoxButtons.YesNo);
            if (result==DialogResult.Yes)
            Close();
        }
    }
}
