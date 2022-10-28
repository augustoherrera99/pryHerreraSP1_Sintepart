using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace pryHerreraSP1_Sintepart
{
    public partial class frmLogin : Form
    {
        public frmLogin()
        {
            InitializeComponent();
        }

        public int contador = 0;

        private void btnAceptar_Click(object sender, EventArgs e)
        {
            string nombre = txtUsuario.Text;
            string contraseña = txtContrasena.Text;
            string modulo = cmbModulo.Text;
            bool a = false;


            if (nombre == "Adm" && contraseña == "1")
            {
                a = true;

                if (modulo == "ADM" || modulo == "COM" || modulo == "VTA")
                {
                    this.Hide();
                    frmBienvenida f = new frmBienvenida();
                    f.ShowDialog();
                    this.Close();
                }
                else
                {
                    MessageBox.Show("Usuario y/o contraseña incorrectos para el módulo seleccionado");
                    cmbModulo.SelectedIndex = -1;
                    contador++;
                    if (contador == 2)
                    {
                        this.Close();
                    }
                }
            }

            if (nombre == "John" && contraseña == "*2b")
            {
                a = true;

                if (modulo == "SIST")
                {
                    this.Hide();
                    frmBienvenida f = new frmBienvenida();
                    f.ShowDialog();
                    this.Close();
                }
                else
                {
                    MessageBox.Show("Usuario y/o contraseña incorrectos para el módulo seleccionado");
                    cmbModulo.SelectedIndex = -1;
                    contador++;
                    if (contador == 2)
                    {
                        this.Close();
                    }
                }
            }

            if (nombre == "Ceci" && contraseña == "*@3c")
            {
                a = true;

                if (modulo == "ADM" || modulo == "VTA")
                {
                    this.Hide();
                    frmBienvenida f = new frmBienvenida();
                    f.ShowDialog();
                    this.Close();
                }
                else
                {
                    MessageBox.Show("Usuario y/o contraseña incorrectos para el módulo seleccionado");
                    cmbModulo.SelectedIndex = -1;
                    contador++;
                    if (contador == 2)
                    {
                        this.Close();
                    }
                }
            }

            if (nombre == "God" && contraseña == "*@#4d")
            {
                a = true;

                this.Hide();
                frmBienvenida f = new frmBienvenida();
                f.ShowDialog();
                this.Close();
            }

            if ( a == false)
            {
                MessageBox.Show("Usario o Contraseña Incorrecto");
                contador++;
                if (contador == 2)
                {
                    this.Close();
                }
            }
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void frmLogin_Load(object sender, EventArgs e)
        {

        }

        private void cmbModulo_SelectedIndexChanged(object sender, EventArgs e)
        {
            btnAceptar.Enabled = true;
        }

        private void txtContrasena_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtUsuario_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
