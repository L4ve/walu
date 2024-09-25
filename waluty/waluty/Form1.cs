namespace waluty
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            string value = textBox4.Text;




            if (String.IsNullOrEmpty(textBox4.Text))
            {
                MessageBox.Show("Wybierz Kwotê ");
                return;
            }



            label3.Text = value;
            float number = float.Parse(value);












            if (radioButton5.Checked && radioButton6.Checked)
            {
                label3.Text = (number * 1f).ToString();
                //PLN
            }
            if (radioButton5.Checked && radioButton7.Checked)
            {
                label3.Text = (number * 3.82f).ToString();
                //USD
            }
            if (radioButton5.Checked && radioButton9.Checked)
            {
                label3.Text = (number * 4.27f).ToString();
                //EURO
            }
            if (radioButton5.Checked && radioButton10.Checked)
            {
                label3.Text = (number * 24.08f).ToString();
                //RUB
            }
            if (radioButton5.Checked && radioButton8.Checked)
            {
                label3.Text = (number * 93f).ToString();
                //HUF
            }





            if (radioButton1.Checked && radioButton6.Checked)
            {
                label3.Text = (number * 4.27f).ToString();
                //PLN
            }
            if (radioButton1.Checked && radioButton7.Checked)
            {
                label3.Text = (number * 1.12f).ToString();
                //USD
            }
            if (radioButton1.Checked && radioButton9.Checked)
            {
                label3.Text = (number * 1f).ToString();
                //EURO
            }
            if (radioButton1.Checked && radioButton10.Checked)
            {
                label3.Text = (number * 102.78f).ToString();
                //RUB
            }
            if (radioButton1.Checked && radioButton8.Checked)
            {
                label3.Text = (number * 395.3f).ToString();
                //HUF
            }






            if (radioButton4.Checked && radioButton6.Checked)
            {
                label3.Text = (number * 3.82f).ToString();
                //PLN
            }
            if (radioButton4.Checked && radioButton7.Checked)
            {
                label3.Text = (number * 1f).ToString();
                //USD
            }
            if (radioButton4.Checked && radioButton9.Checked)
            {
                label3.Text = (number * 0.9f).ToString();
                //EURO
            }
            if (radioButton4.Checked && radioButton10.Checked)
            {
                label3.Text = (number * 92.12f).ToString();
                //RUB
            }
            if (radioButton4.Checked && radioButton8.Checked)
            {
                label3.Text = (number * 354.3f).ToString();
                //HUF
            }







            if (radioButton2.Checked && radioButton6.Checked)
            {
                label3.Text = (number * 0.04f).ToString();
                //PLN
            }
            if (radioButton2.Checked && radioButton7.Checked)
            {
                label3.Text = (number * 0.01f).ToString();
                //USD
            }
            if (radioButton2.Checked && radioButton9.Checked)
            {
                label3.Text = (number * 0.0097f).ToString();
                //EURO
            }
            if (radioButton2.Checked && radioButton10.Checked)
            {
                label3.Text = (number * 1f).ToString();
                //RUB
            }
            if (radioButton2.Checked && radioButton8.Checked)
            {
                label3.Text = (number * 3.84f).ToString();
                //HUF
            }









            if (radioButton3.Checked && radioButton6.Checked)
            {
                label3.Text = (number * 0.01f).ToString();
                //PLN
            }
            if (radioButton3.Checked && radioButton7.Checked)
            {
                label3.Text = (number * 0.0028f).ToString();
                //USD
            }
            if (radioButton3.Checked && radioButton9.Checked)
            {
                label3.Text = (number * 0.0025f).ToString();
                //EURO
            }
            if (radioButton3.Checked && radioButton10.Checked)
            {
                label3.Text = (number * 0.26f).ToString();
                //RUB
            }
            if (radioButton3.Checked && radioButton8.Checked)
            {
                label3.Text = (number * 1f).ToString();
                //HUF
            }

        }

        private void textBox4_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void radioButton4_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void groupBox2_Enter(object sender, EventArgs e)
        {

        }

        private void radioButton5_CheckedChanged(object sender, EventArgs e)
        {

        }
    }
}
