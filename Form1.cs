namespace Travel
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            DialogResult d = MessageBox.Show("Proqramdan çıxış edilsinmi?", "Məlumat", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (d == DialogResult.Yes)
            {
                Close();
            }

        }

        private void button4_Click(object sender, EventArgs e)
        {
            string a = comboBox1.Text;
            string b = comboBox2.Text;
            string c = b;
            comboBox2.Text = a;
            comboBox1.Text = c;
        }
        int n = 0;
        private void button3_Click(object sender, EventArgs e)
        {
            if (comboBox1.Text == comboBox2.Text)
            {
                MessageBox.Show("Eyni şəhərlərə gediş yoxdur", "Məlumat", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {


                if (textBox3.Text.Length != 7)
                {
                    MessageBox.Show("FIN yanlışdır", "Məlumat", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else
                {
                    if (textBox4.Text.Contains("@") && textBox4.Text.Contains("."))
                    {
                        if (textBox4.Text.IndexOf("@") - textBox4.Text.IndexOf(".") == 1 ||
                            textBox4.Text.IndexOf("@") - textBox4.Text.IndexOf(".") == -1)
                        {
                            MessageBox.Show("Email yanlışdır", "Məlumat", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                        else
                        {
                            n++;
                            listBox1.Items.Add(n.ToString() + ") " + comboBox1.Text + " " + comboBox2.Text + maskedTextBox2.Text + " " + textBox1.Text);
                            comboBox1.Text = "";
                            comboBox2.Text = "";
                            maskedTextBox2.Text = "";
                            textBox1.Clear();

                        }
                    }
                    else
                    {
                        MessageBox.Show("Email yanlışdır", "Məlumat", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            listBox1.Items.RemoveAt(listBox1.SelectedIndex);
        }
    }
}
