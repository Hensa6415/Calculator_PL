using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Calculator_App
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        private int Penambahan(int a, int b)
        {
            return a + b;
        }
        private int Pengurangan(int a, int b)
        {
            return a - b;
        }
        private int Perkalian(int a, int b)
        {
            return a * b;
        }
        private int Pembagian(int a, int b)
        {
            return a / b;
        }

        private void btnHitung_Click(object sender, EventArgs e)
        {
            var a = int.Parse(txtNilaiA.Text);
            var b = Convert.ToInt32(txtNilaiB.Text);

            IstHasil.Items.Clear();

            IstHasil.Items.Add($"Hasil Penambahan: {a} + {b} = {Penambahan(a, b)}");
            IstHasil.Items.Add($"Hasil Pengurangan: {a} - {b} = {Pengurangan(a, b)}");
            IstHasil.Items.Add($"Hasil Perkalian: {a} x {b} = {Perkalian(a, b)}");
            IstHasil.Items.Add($"Hasil Pembagian: {a} / {b} = {Pembagian(a, b)}");
        }
    }
}
