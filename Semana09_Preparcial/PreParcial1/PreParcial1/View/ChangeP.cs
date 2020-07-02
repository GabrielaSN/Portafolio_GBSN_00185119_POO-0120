using System;
using System.Windows.Forms;
using PreParcial1.Controlador;
using PreParcial1.Modelo;

namespace PreParcial1
{
    public partial class ChangeP : Form
    {
        public ChangeP()
        {
            InitializeComponent();
        }

        private void ChangeP_Load(object sender, EventArgs e)
        {
             comboBox1.DataSource = null;
             comboBox1.ValueMember = "password";
             comboBox1.DisplayMember = "user";
             comboBox1.DataSource = U.getLista();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            bool actE = Encriptar.CompararMD5(textBox1.Text, comboBox1.SelectedValue.ToString());
            bool newE = textBox2.Text.Equals(textBox3.Text);
            bool newCV = textBox2.Text.Length > 0;
            
            if (actE && newE && newCV)
            {
                try
                {
                    U.actPassword(comboBox1.Text, Encriptar.CrearMD5(textBox2.Text));
                                
                    MessageBox.Show("SE HA ACTUAIZADO LA CONTRASEÑA", 
                        "PreParcial1", MessageBoxButtons.OK, MessageBoxIcon.Information);
                                
                    this.Close();
                }
                catch (Exception)
                {
                    MessageBox.Show("NO SE PUDO ACTUALIZAR LA CONTRASEÑA", 
                        "PreParcial1", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else
                MessageBox.Show("ERROR DATOS INCORRECTOS", 
                    "PreParcial1", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}