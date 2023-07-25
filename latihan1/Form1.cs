namespace latihan1
{
    public partial class titleApp : Form
    {
        public titleApp()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            headerDataTampilkan.Visible = true;
            lblTampilkanData.Text = "Nama mu adalah " + txtNama.Text + ". \nHobi Kamu " + txtHobi.Text + ". \nAsal Kamu dari " + txtAsal.Text + ".";
        }

        private void groupBox5_Enter(object sender, EventArgs e)
        {

        }

        private void label1_Click_1(object sender, EventArgs e)
        {

        }

        private void btnReset_Click(object sender, EventArgs e)
        {
            txtNama.Text = "";
            txtHobi.Text = "";
            txtAsal.Text = "";
            lblTampilkanData.Text = "";
            headerDataTampilkan.Text = "";
        }
    }
}