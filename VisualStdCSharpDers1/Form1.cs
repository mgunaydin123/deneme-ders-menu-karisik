namespace VisualStdCSharpDers1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void buttonMesajGoruntule_Click(object sender, EventArgs e)
        {
            textBoxMesaj.Text = "Ders1: GUI Tasar�m";
        }

        private void buttonMetniSil_Click(object sender, EventArgs e)
        {
            textBoxMesaj.Text = "";
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void buttonIsimekle_Click(object sender, EventArgs e)
        {
            comboBox�simler.Items.Add(textBoxMesaj.Text);
            listBoxDersler.Items.Add(textBoxMesaj.Text);

        }

        private void buttonLabelDegistir_Click(object sender, EventArgs e)
        {
            labelYaz�lan�sim.Text = textBoxMesaj.Text;
        }

        private void buttonRichTextBox_Click(object sender, EventArgs e)
        {
            richTextBoxMetin.Text = richTextBoxMetin.Text + "\n " +trackBarVolume.Value;
        }
    }
}