using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace MasterMind {
    public partial class AskIfPlayerPaid : Form {
        
        public int playerNumber;
        public int tourNumber;
        
        public AskIfPlayerPaid() {
            InitializeComponent();
        }

        public void setLabelName(string label){
            labelPlayerName.Text = label;
        }

        private void buttonYes_Click(object sender, EventArgs e) {
            registerTableAdapter1.InsertQueryRegister(playerNumber, tourNumber, "o");
            Close();
        }

        private void buttonNo_Click(object sender, EventArgs e) {
            registerTableAdapter1.InsertQueryRegister(playerNumber, tourNumber, "n");
            Close();
        }

        private void buttonCancel_Click(object sender, EventArgs e) {
            Close();
        }

        private void buttonYes_MouseEnter(object sender, EventArgs e) {
            buttonYes.ForeColor = Color.Black;
            buttonYes.FlatAppearance.BorderColor = Color.Silver;
        }

        private void buttonYes_MouseLeave(object sender, EventArgs e) {
            buttonYes.ForeColor = Color.FromArgb(45, 45, 45);
            buttonYes.FlatAppearance.BorderColor = Color.Gainsboro;
        }

        private void buttonNo_MouseEnter(object sender, EventArgs e) {
            buttonNo.ForeColor = Color.Black;
            buttonNo.FlatAppearance.BorderColor = Color.Silver;
        }

        private void buttonNo_MouseLeave(object sender, EventArgs e) {
            buttonNo.ForeColor = Color.FromArgb(45, 45, 45);
            buttonNo.FlatAppearance.BorderColor = Color.Gainsboro;
        }

        private void buttonCancel_MouseEnter(object sender, EventArgs e) {
            buttonCancel.ForeColor = Color.Black;
            buttonCancel.FlatAppearance.BorderColor = Color.Silver;
        }

        private void buttonCancel_MouseLeave(object sender, EventArgs e) {
            buttonCancel.ForeColor = Color.FromArgb(45, 45, 45);
            buttonCancel.FlatAppearance.BorderColor = Color.Gainsboro;
        }

        
    
    }

        
}
