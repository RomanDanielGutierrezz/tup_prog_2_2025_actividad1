namespace Actividad_1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void btnDescribir_Click(object sender, EventArgs e)
        {
            Ortoedro ortoedro = new Ortoedro(7, 7, 21);
            tbDescripcion.Text += $@"
            [ 
                {ortoedro.Describir()},
            ]";

        }
    }
}
