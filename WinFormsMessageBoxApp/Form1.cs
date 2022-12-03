namespace WinFormsMessageBoxApp
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            DialogResult result =  MessageBox.Show(
                            "Hello world",  // message
                            "Message box title", // title window
                            MessageBoxButtons.CancelTryContinue, // buttons
                            MessageBoxIcon.Information, // icon
                            MessageBoxDefaultButton.Button1 // default button
                            );

            MessageBox.Show("You press " + result.ToString());
        }

        private void btnOpen_Click(object sender, EventArgs e)
        {
            openFileDialog1.InitialDirectory = @"D:\";
            openFileDialog1.Filter = "All files (*.*)|*.*|Text files (*.txt)|*.txt|C++ files (*.cpp)|*.cpp";

            if(openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                string fileName = openFileDialog1.FileName;
                string text = File.ReadAllText(fileName);
                textBox1.Text = text;
            }
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            if (saveFileDialog1.ShowDialog() == DialogResult.Cancel)
                return;
            string filename = saveFileDialog1.FileName;
            File.WriteAllText(filename, textBox1.Text);
        }

        private void btnFont_Click(object sender, EventArgs e)
        {
            fontDialog1.Font = textBox1.Font;
            fontDialog1.ShowColor = true;

            if(fontDialog1.ShowDialog() == DialogResult.OK)
            {
                textBox1.Font = fontDialog1.Font;
                textBox1.ForeColor = fontDialog1.Color;
            }
        }

        private void btnColorFore_Click(object sender, EventArgs e)
        {
            if(colorDialog1.ShowDialog() == DialogResult.OK)
            {
                textBox1.ForeColor = colorDialog1.Color;
            }
        }

        private void btnColorBack_Click(object sender, EventArgs e)
        {
            colorDialog1.FullOpen = true;
            colorDialog1.SolidColorOnly = true;
            if (colorDialog1.ShowDialog() == DialogResult.OK)
            {
                textBox1.BackColor = colorDialog1.Color;
            }
        }
    }
}