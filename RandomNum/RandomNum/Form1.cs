using System;
using System.IO;
using System.Windows.Forms;

namespace RandomNum
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnGenerate_Click(object sender, EventArgs e)
        {
            // Validate the number entered
            if (!int.TryParse(txtNumberOfRandoms.Text, out int numberOfRandoms) || numberOfRandoms <= 0)
            {
                MessageBox.Show("Please enter a valid positive number.");
                return;
            }

            // Show the SaveFileDialog to select file location and name
            saveFileDialog1.Filter = "Text Files (*.txt)|*.txt|All Files (*.*)|*.*";
            saveFileDialog1.Title = "Save Random Numbers File";
            if (saveFileDialog1.ShowDialog() == DialogResult.OK)
            {
                string filePath = saveFileDialog1.FileName;
                try
                {
                    // Write random numbers to the file
                    Random rand = new Random();
                    using (StreamWriter writer = new StreamWriter(filePath))
                    {
                        for (int i = 0; i < numberOfRandoms; i++)
                        {
                            int randomNumber = rand.Next(1, 101); // Generates numbers from 1 to 100
                            writer.WriteLine(randomNumber);
                        }
                    }
                    lblMessage.Text = "File saved successfully!";
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"Error: {ex.Message}");
                }
            }
        }
    }
}