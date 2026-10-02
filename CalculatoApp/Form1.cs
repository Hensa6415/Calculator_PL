using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CalculatoApp
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            if (BtnOperasi.Items.Count == 0)
            {
                BtnOperasi.SelectedIndex = 0;
            }
        }

        private void btnHitung_Click(object sender, EventArgs e)
        {
            try
            {
                double nilaiA = Convert.ToDouble(txtNilaiA.Text);
                double nilaiB = Convert.ToDouble(txtNilaiB.Text);
                double hasil = 0;
                string operasi = BtnOperasi.SelectedItem.ToString();
                switch (operasi)
                {
                    case "Penambahan":
                        hasil = nilaiA + nilaiB;
                        break;
                    case "Pengurangan":
                        hasil = nilaiA - nilaiB;
                        break;
                    case "Perkalian":
                        hasil = nilaiA * nilaiB;
                        break;
                    case "Pembagian":
                        if (nilaiB == 0)
                        {
                            MessageBox.Show("Error: Pembagian dengan nol tidak diperbolehkan.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            return;
                        }
                        hasil = nilaiA / nilaiB;
                        break;
                    default:
                        MessageBox.Show("Operasi tidak valid.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        return;
                }
                txtHasil.Text = hasil.ToString();

            }
            catch (FormatException)
            {
                MessageBox.Show("Input harus berupa angka.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Terjadi kesalahan: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
