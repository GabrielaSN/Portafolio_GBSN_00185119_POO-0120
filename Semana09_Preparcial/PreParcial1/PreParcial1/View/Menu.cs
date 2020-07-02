using System.Windows.Forms;
using PreParcial1.Modelo;

namespace PreParcial1
{ 
    public partial class Menu : Form
    { 
        public partial class frmPrincipal : Form
        {
            private User user;
               
            public Menu(User pUser)
               { 
                   InitializeComponent();
                   user = pUser;
               }

            private void Menu_Load(object sender, EventArgs e)
               { 
                   label1.Text = 
                       "BIENVENIDO" + user.nombreuser + " [" + (user.administrador ? "Administrador" : "User") + "]";
       
                   if (user.administrador)
                   {
                       tabControl1.TabPages[6].Parent= null;
                       tabControl1.TabPages[6].Parent= null;
                       actualizarControles();
                   }
                   else
                   {
                       tabControl1.TabPages[1].Parent = null;
                       tabControl1.TabPages[1].Parent = null;
                       tabControl1.TabPages[1].Parent = null;
                       tabControl1.TabPages[1].Parent = null;
                       tabControl1.TabPages[1].Parent = null;
                       actualizarControles();
                   }
               }


            private void actualizarControles()
               {
                   List<User> lista = U.getLista();
                   List<Inventario> list = I.getLista();
                   List<Ordenes> lis = O.getLista();
                   dataGridView1.DataSource = null;
                   dataGridView1.DataSource = lista;
                   comboBox1.DataSource = null;
                   comboBox1.ValueMember = "password";
                   comboBox1.DisplayMember = "username";
                   comboBox1.DataSource = lista;
                   comboBox3.DataSource = null;
                   comboBox3.DisplayMember = "product";
                   comboBox3.DataSource = list;
                   comboBox2.DataSource = null;
                   comboBox2.DisplayMember = "product";
                   comboBox2.DataSource = list;
                   dataGridView2.DataSource = null;
                   dataGridView2.DataSource = lis;
               }
       
       
            private void Menu_FormClose(object sender, FormClosingEventArgs e)
               { 
                   if (MessageBox.Show("¿DESEA SALIR, " + user.nombreuser + "?", 
                         "PreParcial1", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.No)
                   {
                       e.Cancel = true;
                   }
                   else
                   { 
                       try
                       {
                           e.Cancel = false;
                       }
                       catch (Exception)
                       { 
                           MessageBox.Show("ERROR", 
                               "PreParcial1", MessageBoxButtons.OK, MessageBoxIcon.Error);
                       }
                   }
               }
       
               private void Menu_FormClosed(object sender, FormClosedEventArgs e)
               {
                   
                   Application.Exit();
               }
       
               private void button1_Click(object sender, EventArgs e)
               {
                   try
                   {
                       if (textBox1.Text.Length >= 5)
                       {
                           U.New(textBox1.Text);
                           
                           MessageBox.Show("SE HA AGREGADO USUARIO" , 
                               "PreParcial1", MessageBoxButtons.OK, MessageBoxIcon.Information);
                           
                           textBox1.Clear();
                           actualizarControles();
                       }
                       else
                           MessageBox.Show("DIGITE USUARIO", 
                               "PreParcial1", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                   }
                   catch (Exception)
                   {
                       MessageBox.Show("NO DISPONIBLE", 
                           "PreParcial1", MessageBoxButtons.OK, MessageBoxIcon.Error);
                   }
               }
       
               private void button2_Click(object sender, EventArgs e)
               {
                   actualizarControles();
               }
       
               private void button3_Click(object sender, EventArgs e)
               {
                   U.Pass(comboBox1.Text, sButton1.Checked, sButton3.Checked);
                   
                   MessageBox.Show("ACTUALIZADO EXITOSAMENTE", 
                       "Preparcial1", MessageBoxButtons.OK, MessageBoxIcon.Information);
                   
                   actualizarControles();
               }
               
               private void button4_Click(object sender, EventArgs e)
               {
                   if (MessageBox.Show("DESEA ELIMINAR USUARIO " + comboBox1.Text + "?", 
                       "", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                   {
                       U.delete(comboBox1.Text);
                       
                       MessageBox.Show("USUARIO ELIMINADO", 
                           "PreParcial1", MessageBoxButtons.OK, MessageBoxIcon.Information);
                   
                       actualizarControles();
                   }
               }
       
               private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
               {
                   User u = (User) comboBox1.SelectedItem;
       
                   if (u.administrador)
                       sButton1.Checked = true;
                   else
                       sButton2.Checked = true;
                   
                   if (u.act)
                       sButton3.Checked = true;
                   else
                       sButton4.Checked = true;
               }
       
       
               private void button5_Click(object sender, EventArgs e)
               {
                   try
                   {
                       if (textBox2.Text.Length > 0 && textBox3.Text.Length > 0 && textBox4.Text.Length > 0 &&
                           textBox5.Text.Length > 0)
                       {
                           I.crearNuevo(textBox2.Text, textBox3.Text, textBox4.Text, textBox5.Text);
                           MessageBox.Show("SE AGREGO PRODUCTO",
                               "PreParcial", MessageBoxButtons.OK, MessageBoxIcon.Information);
       
                           textBox2.Clear();
                           textBox3.Clear();
                           textBox4.Clear();
                           textBox5.Clear();
                           actualizarControles();
       
                       }
                       else
                           MessageBox.Show("ERROR,ESPACIO EN BLANCO",
                               "PreParcial1", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                   }
                   catch (Exception)
                   {
                       MessageBox.Show("ERROR", 
                           "PreParcial1", MessageBoxButtons.OK, MessageBoxIcon.Error); 
                   }
               }

               private void button6_Click(object sender, EventArgs e)
               {
                    I.enStock(comboBox2.Text, textBox6.Text);
                               
                    MessageBox.Show("¡STOCK ACTULIZADO", 
                        "PreParcial1", MessageBoxButtons.OK, MessageBoxIcon.Information);
                               
                    actualizarControles();
               }
               
               private void button7_Click(object sender, EventArgs e)
               {
                   if (MessageBox.Show("¿ELIMINAR" + comboBox2.Text + "?", 
                       "PreParcial1", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                   {
                       I.eliminar(comboBox2.Text);
                       
                       MessageBox.Show("SE HA ELIMINADO", 
                           "PreParcial1", MessageBoxButtons.OK, MessageBoxIcon.Information);
                       
                       actualizarControles();
                   }
               }
               
               private void button8_Click(object sender, EventArgs e)
               {
                   actualizarControles();
               }
       
               private void button9_Click(object sender, EventArgs e)
               {
                   try
                   {
                       if (textBox7.Text.Length > 0)
                       {
                           O.add(user.nombreuser, comboBox3.Text,  textBox7.Text);
                           
                           MessageBox.Show("PEDIDO REALIZADO" , 
                               "PreParcial1", MessageBoxButtons.OK, MessageBoxIcon.Information);
                           
                           textBox7.Clear();
                           actualizarControles();
                       }
                       else
                           MessageBox.Show("ERROR", 
                               "PreParcial1", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                   }
                   catch (Exception)
                   {
                       MessageBox.Show("NO HAY EN ESTOS MOMENTOS", 
                           "PreParcial1", MessageBoxButtons.OK, MessageBoxIcon.Error);
                   }
               }
        }
    }
}