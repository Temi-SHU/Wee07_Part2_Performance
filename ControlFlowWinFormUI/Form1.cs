namespace StructureOfWinFormsProj
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnNoneModal_Click(object sender, EventArgs e)
        {
            Form2 form = new Form2();
            form.Text = "None Modal Form";

            form.Owner = this;

            form.Show();
        }

        private void btnModal_Click(object sender, EventArgs e)
        {
            Form2 form = new Form2();
            form.Text = "Modal Form";
            form.ShowDialog();
        }

        private void btnModalWithUpdate_Click(object sender, EventArgs e)
        {
            Form2 form = new Form2();
            form.Text = "Modal Form 2";

            form.Show   ();

            UpdateUIContinously();
        }

        private void UpdateUIContinously()
        {
            for (int i = 0; i < 1000000; i++)
            {
                txtDummy.Text = i.ToString();
            }
        }
    }
}