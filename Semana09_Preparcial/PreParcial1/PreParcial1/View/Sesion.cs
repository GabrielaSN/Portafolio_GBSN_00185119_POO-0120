using System.Windows.Forms;

namespace PreParcial1
{
    public partial class Sesion : Form
    {
         public Sesion()
         {
             InitializeComponent();
         }
        
         private void Sesion_Load(object sender, EventArgs e)
         {
             PoblarControles();
         }
         private void PoblarControles()
         { 
             cmbUser.DataSource = null;
             cmbUser.ValueMember = "password";
             cmbUser.DisplayMember = "username";
             cmbUser.DataSource = U.getLista();
         }
                
                
        
         private void button1_Click(object sender, EventArgs e)
         {
             ChangeP unaVentana = new ChangeP();
             unaVentana.ShowDialog();
             PoblarControles();
         }
        
         private void button2_Click(object sender, EventArgs e)
         {
             if (Encriptar.CompararMD5(textBox2.Text, cmbUser.SelectedValue.ToString()))
             {
                 User u = (User) cmbUsers.SelectedItem;
                 if (u.activo)
                 { 
                     MessageBox.Show("BIEVENIDO", 
                         "PreParcial1", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            
                     Menu ventana = new Menu(u);
                     ventana.Show();
                     this.Hide();
                 }
                 else
                     MessageBox.Show("ERRO", 
                         "PreParcial1", MessageBoxButtons.OK, MessageBoxIcon.Error);
             }
             else
                 MessageBox.Show("CONTRASEÑA INCORRECTA", "PreParcial1",
                     MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
         }
        
         private void textBox2_KeyDown(object sender, KeyEventArgs e)
         {
             if (e.KeyCode == Keys.Enter) button2_Click(sender, e);
         }
    }
}