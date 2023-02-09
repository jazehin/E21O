namespace EletjatekGUI
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            cbSor.Items.Clear();
            cbOszlop.Items.Clear();
            for (int i = 5; i < 21; i++)
            {
                cbSor.Items.Add(i);
                cbOszlop.Items.Add(i);
            }
            cbSor.SelectedItem = 20;
            cbOszlop.SelectedItem = 20;
        }

        private void btnUres_Click(object sender, EventArgs e)
        {
            foreach (Control control in panel1.Controls)
            {
                if (control is CheckBox)
                {
                    control.Dispose();
                }
            }

            for (int i = 0; i < int.Parse(cbSor.SelectedItem.ToString()); i++)
            {
                for (int j = 0; j < int.Parse(cbOszlop.SelectedItem.ToString()); j++)
                {
                    //MessageBox.Show($"i:{i}, j:{j}");
                    CheckBox cb = new();
                    cb.Location = new Point(cb.Size.Width + 2 * i, cb.Size.Height + 2 * j);
                    
                    panel1.Controls.Add(cb);
                    //nincs kész
                }
            }
        }
    }
}