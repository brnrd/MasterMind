using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace MasterMind {
    public partial class Results : Form {

        public int gameNumber;
        public int playerNumber;
        public bool encoded;
        public int triesNumber;

        public Results() {
            InitializeComponent();
        }

        private void buttonWon_Click(object sender, EventArgs e) {
            if (textBoxTries.Text != "" && int.Parse(textBoxTries.Text) <= triesNumber) {
                if (encoded) {
                    gameTableAdapter.UpdateQueryGameResult("g", int.Parse(textBoxTries.Text), playerNumber, gameNumber);
                } else {
                    gameTableAdapter.InsertQueryGameResult(playerNumber, gameNumber, "g", int.Parse(textBoxTries.Text));
                }
                Close();
            } else {
                MessageBox.Show("Entrer une valeur valide");
                textBoxTries.Focus();
            }
        }

        private void buttonLost_Click(object sender, EventArgs e) {
            if (encoded) {
                gameTableAdapter.UpdateQueryGameResult("p", triesNumber, playerNumber, gameNumber);
            } else {
                gameTableAdapter.InsertQueryGameResult(playerNumber, gameNumber, "p", triesNumber);
            }
            Close();
        }

        private void setLabelNumberMax() {
            labelNumberMax.Text = "/" + triesNumber;
        }

        private void Results_Shown(object sender, EventArgs e) {
            setLabelNumberMax();
            textBoxTries.Focus();
        }

        private void buttonWon_MouseEnter(object sender, EventArgs e) {
            buttonWon.ForeColor = Color.Black;
            buttonWon.FlatAppearance.BorderColor = Color.Silver;
        }

        private void buttonWon_MouseLeave(object sender, EventArgs e) {
            buttonWon.ForeColor = Color.FromArgb(45, 45, 45);
            buttonWon.FlatAppearance.BorderColor = Color.Gainsboro;
        }

        private void buttonLost_MouseEnter(object sender, EventArgs e) {
            buttonLost.ForeColor = Color.Black;
            buttonLost.FlatAppearance.BorderColor = Color.Silver;
        }

        private void buttonLost_MouseLeave(object sender, EventArgs e) {
            buttonLost.ForeColor = Color.FromArgb(45, 45, 45);
            buttonLost.FlatAppearance.BorderColor = Color.Gainsboro;
        }

        private void buttonCancel_MouseEnter(object sender, EventArgs e) {
            buttonCancel.ForeColor = Color.Black;
            buttonCancel.FlatAppearance.BorderColor = Color.Silver;
        }

        private void buttonCancel_MouseLeave(object sender, EventArgs e) {
            buttonCancel.ForeColor = Color.FromArgb(45, 45, 45);
            buttonCancel.FlatAppearance.BorderColor = Color.Gainsboro;
        }

        private void buttonCancel_Click(object sender, EventArgs e) {
            Close();
        }



    }
}
