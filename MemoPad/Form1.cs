using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MemoPad {
    public partial class Form1 : Form {
        public Form1() {
            InitializeComponent();
        }

        private void openToolStripMenuItem_Click(object sender, EventArgs e) {
            if (openFileDialog1.ShowDialog() == DialogResult.OK) {
                string selectedFilename = this.openFileDialog1.FileName;
                using (var sreader = new System.IO.StreamReader(selectedFilename)) {
                    this.textBox1.Text = sreader.ReadToEnd();
                }
            }
        }

        private void saveToolStripMenuItem_Click(object sender, EventArgs e) {
            if (saveFileDialog1.ShowDialog() == DialogResult.OK) {
                string selectedFilename = this.saveFileDialog1.FileName;
                using (var swriter = new System.IO.StreamWriter(selectedFilename)) {
                    swriter.Write(this.textBox1.Text);
                }
            }

        }
    }
}
