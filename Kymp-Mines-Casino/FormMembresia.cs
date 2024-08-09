using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace COMPLETE_FLAT_UI
{
    public partial class FormMembresia : Form
    {
        Random random = new Random();
        char[] letters = { 'a', 'b', 'c', 'd', 'e' };
        int[] numbers = { 1, 2, 3, 4, 5 };

        public FormMembresia()
        {
            InitializeComponent();
        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            FormListaClientes hijo = new FormListaClientes();
            AddOwnedForm(hijo);
            hijo.FormBorderStyle = FormBorderStyle.None;
            hijo.TopLevel = false;
            hijo.Dock = DockStyle.Fill;
            this.Controls.Add(hijo);
            this.Tag = hijo;
            hijo.BringToFront();

            hijo.Show();
        }

        private void BtnCerrar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void comboBox2_SelectedIndexChanged(object sender, EventArgs e)
        {
            // Bu kısmı kaldırıyoruz
        }

        private void textBox11_TextChanged(object sender, EventArgs e)
        {

        }

        private void button4_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Saved", "Alert!!", MessageBoxButtons.OK);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int selectedIndex = comboBox2.SelectedIndex;

            if (selectedIndex == 0 && listBox1.Items.Count == 0)
            {
                MessageBox.Show("Please Select Mines First", "Alert!!", MessageBoxButtons.OK);
            }
            else if (selectedIndex != -1)
            {
                char selectedLetter;
                int selectedNumber;
                listBox1.Items.Clear(); // listBox1'i temizle

                // Seçilen rakam kadar rastgele harf ve sayı üret ve listBox1'e ekle
                for (int i = 0; i <= selectedIndex; i++)
                {
                    selectedLetter = letters[random.Next(letters.Length)];
                    selectedNumber = numbers[random.Next(numbers.Length)];
                    listBox1.Items.Add($"{selectedLetter}{selectedNumber}");
                }
            }
            else
            {
                MessageBox.Show("Please select a valid number from the Mines.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            // ListBox1'deki seçim değiştiğinde yapılacak işlemler buraya yazılır
        }
    }
}
