namespace WPC_1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }


        private void buttonEntra_Click(object sender, EventArgs e)
        {
            // textBoxUsuari.Text = "Pinto el maquina";
            usuari_Menu frm3 = new usuari_Menu();
            frm3.ShowDialog();

        }


        private void labelDonaAlta_Click(object sender, EventArgs e)
        {
            register_Menu frm2 = new register_Menu();
            frm2.ShowDialog();
        }

    }
}