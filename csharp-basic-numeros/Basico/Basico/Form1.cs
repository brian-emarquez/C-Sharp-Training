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
            // Preparar controles o valores iniciales.
            label1.Text = "Presione un botón para ver los ejemplos de manejo de texto y números.";
            label2.Text = "";
        }

        private void label1_Click(object sender, EventArgs e)
        {
            label1.Text = "Etiqueta activada. Usa los botones para resultados.";
        }

        private void button1_Click(object sender, EventArgs e)
        {
            // Concatenación de cadenas y uso de interpolación para legibilidad.
            string baseText = "Esto es una cadena";
            string separator = " de ";
            string resultText = $"{baseText}{separator}concatenación profesional";

            label1.Text = resultText;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            // Manipulación de números y presentación formateada.
            int integerValue = 10;
            double decimalValue = 5000.45;
            double total = integerValue + decimalValue;

            label2.Text = $"Entero: {integerValue:N0}, Decimal: {decimalValue:N2}, Total: {total:N2}";
        }

        private void label1_Click_1(object sender, EventArgs e)
        {
            // Evento nuevo enfocado a interacción adicional.
            label2.Text = "Has interactuado con la etiqueta secundaria.";
        }
    }
}