namespace NoteTakingApp
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            // Get the contents of the text box
            string contents = textBox1.Text;

            // Write the contents to a file
            System.IO.File.WriteAllText(@"C:\Users\Josep\source\repos\NoteTakingApp\Notes.txt", contents);

            // Show a message box to confirm the save
            MessageBox.Show("Notes saved successfully.");

        }

        private void button2_Click(object sender, EventArgs e)
        {
            
                // Show the Open File dialog box
                OpenFileDialog openFileDialog1 = new OpenFileDialog();
                openFileDialog1.Filter = "Text Files (*.txt)|*.txt|All Files (*.*)|*.*";
                openFileDialog1.Title = "Open Note";
                if (openFileDialog1.ShowDialog() == DialogResult.OK)
                {
                    // Read the contents of the selected file and display them in the text box
                    string fileName = openFileDialog1.FileName;
                    string contents = File.ReadAllText(fileName);
                    textBox1.Text = contents;
                }
            }

            private void editButton_Click(object sender, EventArgs e)
            {
                // Enable editing of the text box
                textBox1.ReadOnly = false;
            }

        }
    }
