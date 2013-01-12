using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace MasterMind {
    public partial class ResultsDisplay : Form {

        public bool player;
        public int playerNumber;
        public int tournamentNumber;
        
        public ResultsDisplay() {
            InitializeComponent();
        }

        private void ResultsDisplay_Load(object sender, EventArgs e) {
            if (player) {
                f___ingHellTableAdapter.FillByTournamentAndPlayer(masterMindDataSet._F___ingHell, tournamentNumber, playerNumber);
            } else {
                f___ingHellTableAdapter.FillByTournament(masterMindDataSet._F___ingHell, tournamentNumber);
            }
        }

        private void buttonClose_MouseEnter(object sender, EventArgs e) {
            buttonClose.ForeColor = Color.Black;
            buttonClose.FlatAppearance.BorderColor = Color.Silver;
        }

        private void buttonClose_MouseLeave(object sender, EventArgs e) {
            buttonClose.ForeColor = Color.FromArgb(45, 45, 45);
            buttonClose.FlatAppearance.BorderColor = Color.Gainsboro;
        }

        private void buttonClose_Click(object sender, EventArgs e) {
            Close();
        }

        private void buttonRefresh_Click(object sender, EventArgs e) {
            if (player) {
                f___ingHellTableAdapter.FillByTournamentAndPlayer(masterMindDataSet._F___ingHell, tournamentNumber, playerNumber);
            } else {
                f___ingHellTableAdapter.FillByTournament(masterMindDataSet._F___ingHell, tournamentNumber);
            }
        }

        private void buttonRefresh_MouseEnter(object sender, EventArgs e) {
            buttonRefresh.ForeColor = Color.Black;
            buttonRefresh.FlatAppearance.BorderColor = Color.Silver;
        }

        private void buttonRefresh_MouseLeave(object sender, EventArgs e) {
            buttonRefresh.ForeColor = Color.FromArgb(45, 45, 45);
            buttonRefresh.FlatAppearance.BorderColor = Color.Gainsboro;
        }

        private void f___ingHellDataGridView_CellClick(object sender, DataGridViewCellEventArgs e) {
            Point dot = f___ingHellDataGridView.PointToClient(Cursor.Position);
            DataGridView.HitTestInfo hti = f___ingHellDataGridView.HitTest(dot.X, dot.Y);
            bool isClickedFromHearder = hti.Type == DataGridViewHitTestType.ColumnHeader;
            if (!isClickedFromHearder) {
                DataGridViewRow row = f___ingHellDataGridView.CurrentRow;
                player = true;
                this.Text = "Résultats tournoi " + row.Cells[0].Value.ToString() + " " + row.Cells[2].Value.ToString();
                playerNumber = int.Parse(row.Cells[1].Value.ToString());
                f___ingHellTableAdapter.FillByTournamentAndPlayer(masterMindDataSet._F___ingHell, tournamentNumber, playerNumber);
            }
        }

        private void buttonSeeAll_Click(object sender, EventArgs e) {
            this.Text = "Résultats tournoi";
            f___ingHellTableAdapter.FillByTournament(masterMindDataSet._F___ingHell, tournamentNumber);
        }

        private void buttonSeeAll_MouseEnter(object sender, EventArgs e) {
            buttonSeeAll.ForeColor = Color.Black;
            buttonSeeAll.FlatAppearance.BorderColor = Color.Silver;
        }

        private void buttonSeeAll_MouseLeave(object sender, EventArgs e) {
            buttonSeeAll.ForeColor = Color.FromArgb(45, 45, 45);
            buttonSeeAll.FlatAppearance.BorderColor = Color.Gainsboro;
        }

    }
}