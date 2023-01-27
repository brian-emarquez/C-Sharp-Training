namespace Basico
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

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            // variables
            // concatenacion
            string prueba = "Esto es na cadena";
            string prueba2 = " de ";
            string prueba3 = "Esto es una cadena" + prueba2 + "concatenacion";

            label1.Text = prueba3;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            //manejo de variables con numeros 
            int numero = 10;
            double numeroDouble = 5000.45;
            
            string prueba2 = "prueba de variable: " + numero + numeroDouble;  

            label2.Text = prueba2;

        }

        private void label1_Click_1(object sender, EventArgs e)
        {

        }
    }
}