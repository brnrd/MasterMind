using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Text.RegularExpressions;

namespace MasterMind {
    public partial class MainWindow : Form {

        private bool player = false;
        private int playerNumber = -1;
        private string playerName;
        private string playerFirstName;
        private string playerDoB;
        private string playerNationality;
        private string playerLanguage;
        private string playerCategory;

        private bool tournament = false;
        private int tournamentNumber = -1;
        private string tournamentName;
        private string tournamentCity;
        private string tournamentProvince;
        private string tournamentDoH;

        private string patternP = @"(?:-p)[\s]+(\w+)";
        private string patternN = @"(?:-n)[\s]+(\w+)";
        private string patternL = @"(?:-l)[\s]+(\w+)";
        private string patternNat = @"(?:-N)[\s]+(\w+)";
        //private string patternD = @"(?:-d)[\s]+(\w+)";
        private string patternC = @"(?:-c)[\s]+(\w+)";
        private string patternV = @"(?:-v)[\s]+(\w+)";
        private string patternPro = @"(?:-p)[\s]+(\w+)";

        
        public MainWindow() {
            InitializeComponent();
        }
        
        private void CenterSearch(Panel p) {
            p.Left = (Width - p.Width) / 2;
            p.Top = (Height - p.Height) / 3;
        }
        
        private void GoToSearchPage() {
            buttonSearchTop.ForeColor = Color.White;
            buttonPlayersTop.ForeColor = Color.Silver;
            buttonTournamentsTop.ForeColor = Color.Silver;
            HideAllPanelsBut(panelSearch);
            textBoxSearch.Focus();
        }

        private void GoToPlayersPage() {
            buttonSearchTop.ForeColor = Color.Silver;
            buttonTournamentsTop.ForeColor = Color.Silver;
            buttonPlayersTop.ForeColor = Color.White;
            HideAllPanelsBut(panelPlayerList,panelSidePlayers,panelTopSearch);
        }

        private void GoToPlayerPage() {
            HideAllPanelsBut(panelPlayer, panelSidePlayers, panelTopSearch);
        }

        private void GoToTournamentsPage() {
            buttonSearchTop.ForeColor = Color.Silver;
            buttonTournamentsTop.ForeColor = Color.White;
            buttonPlayersTop.ForeColor = Color.Silver;
            HideAllPanelsBut(panelTournamentsList, panelSideTournaments, panelTopSearch);
        }

        private void GoToTournamentPage() {
            textBoxTopSearch.Text = textBoxSearch.Text;
            textBoxSearch.Text = "";
            HideAllPanelsBut(panelTournament, panelSideTournaments, panelTopSearch);
        }

        private void getPlayerDataFromRow(DataGridViewRow row){
            playerNumber = int.Parse(row.Cells[1].Value.ToString());
            playerName = row.Cells[0].Value.ToString();
            playerFirstName = row.Cells[2].Value.ToString();
            playerDoB = row.Cells[3].Value.ToString();
            playerLanguage = row.Cells[4].Value.ToString();
            playerNationality = row.Cells[5].Value.ToString();
            playerCategory = row.Cells[6].Value.ToString();
        }


        private void getTournamentDataFromRow(DataGridViewRow row) {
            tournamentNumber = int.Parse(row.Cells[1].Value.ToString());
            tournamentName = row.Cells[0].Value.ToString();
            tournamentCity = row.Cells[2].Value.ToString();
            tournamentProvince = row.Cells[3].Value.ToString();
            tournamentDoH = row.Cells[4].Value.ToString();
        }

        private void buttonSearch_Click(object sender, EventArgs e) {
            if (textBoxSearch.Text == "") {
                buttonSearch.Text = "Un oubli ?";
                textBoxSearch.Focus();
            } else {
                playersTableAdapter.Fill(masterMindDataSet.Players);
                GoToPlayersPage();
                textBoxTopSearch.Text = textBoxSearch.Text;
                textBoxSearch.Text = "";
                textBoxTopSearch.Focus();
                buttonSearch.Text = "&Recherche";
            }
        }

        private void newPlayerControlsHide() {
            labelIsRegisterAtTour.Hide();
            labelIsNotRegisterAtTour.Hide();
            tournamentByParticipatingPlayerDataGridView.Hide();
            tournamentByNotParticipatingPlayerDataGridView.Hide();
            buttonAddTournamentToPlayer.Hide();
            buttonDelTournamentToPlayer.Hide();
            labelPlayerMustPay.Hide();
            playerRegisterTournamentDataGridView.Hide();
            buttonPay.Hide();
        }

        private void playerControlsShow() {
            labelIsRegisterAtTour.Show();
            labelIsNotRegisterAtTour.Show();
            tournamentByParticipatingPlayerDataGridView.Show();
            tournamentByNotParticipatingPlayerDataGridView.Show();
            buttonAddTournamentToPlayer.Show();
            buttonDelTournamentToPlayer.Show();
            labelPlayerMustPay.Show();
            playerRegisterTournamentDataGridView.Show();
            buttonPay.Show();
        }

        private void newTournamentControlsHide() {
            buttonAddResults.Hide();
            labelGameOfThisTournament.Hide();
            labelParticipateThisTournament.Hide();
            gamesByTourDataGridView.Hide();
            playersByTournamentDataGridView.Hide();
            buttonDeleteGameToTournament.Hide();
            labelMustPay.Hide();
            labelColorNumber.Hide();
            textBoxGameNumberColors.Hide();
            labelCellsNumber.Hide();
            textBoxGameNumberCells.Hide();
            labelTriesNumber.Hide();
            textBoxGameNumberTries.Hide();
            AddGameToTournament.Hide();
            buttonResetFormAddGameToTournament.Hide();
            playerRegisterTournamentDataGridView1.Hide();
            buttonPayTour.Hide();

        }

        private void tournamentControlsShow() {
            buttonAddResults.Show();
            labelGameOfThisTournament.Show();
            labelParticipateThisTournament.Show();
            gamesByTourDataGridView.Show();
            playersByTournamentDataGridView.Show();
            buttonDeleteGameToTournament.Show();
            labelMustPay.Show();
            labelColorNumber.Show();
            textBoxGameNumberColors.Show();
            labelCellsNumber.Show();
            textBoxGameNumberCells.Show();
            labelTriesNumber.Show();
            textBoxGameNumberTries.Show();
            AddGameToTournament.Show();
            buttonResetFormAddGameToTournament.Show();
            playerRegisterTournamentDataGridView1.Show();
            buttonPayTour.Show();
        }

        private void HideAllPanelsBut(Panel p) {
            panelSidePlayers.Hide();
            panelSideTournaments.Hide();
            panelPlayer.Hide();
            panelPlayerList.Hide();
            panelTournament.Hide();
            panelTournamentsList.Hide();
            panelSearch.Hide();
            panelTopSearch.Hide();
            p.Show();
        }

        private void HideAllPanelsBut(Panel p1, Panel p2) {
            panelSidePlayers.Hide();
            panelSideTournaments.Hide();
            panelPlayer.Hide();
            panelPlayerList.Hide();
            panelTournament.Hide();
            panelTournamentsList.Hide();
            panelSearch.Hide();
            panelTopSearch.Hide();
            p1.Show();
            p2.Show();
        }

        private void HideAllPanelsBut(Panel p1, Panel p2, Panel p3) {
            panelSidePlayers.Hide();
            panelSideTournaments.Hide();
            panelPlayer.Hide();
            panelPlayerList.Hide();
            panelTournament.Hide();
            panelTournamentsList.Hide();
            panelSearch.Hide();
            panelTopSearch.Hide();
            p1.Show();
            p2.Show();
            p3.Show();
        }

        private void logOffPlayer() {
            playerNumber = -1;
            playerName = "";
            playerFirstName = "";
            playerDoB = "";
            playerLanguage = "";
            playerNationality = "";
            playerCategory = "";
            linkLabelCurrentPlayer.Text = "";
        }

        private void logOffTournament() {
            tournamentNumber = -1;
            tournamentName = "";
            tournamentCity = "";
            tournamentProvince = "";
            tournamentDoH = "";
            linkLabelCurrentTournament.Text = "";
        }

        private void MainWindow_Shown(object sender, EventArgs e) {
            CenterSearch(panelSearch);
        }

        private void MainWindow_Resize(object sender, EventArgs e) {
            CenterSearch(panelSearch);
        }

        private void buttonSearchTop_Click(object sender, EventArgs e) {
            GoToSearchPage();
        }
        
        private void buttonPlayersTop_Click(object sender, EventArgs e) {
            GoToPlayersPage();
            AllPlayersButtonsDarkBut(buttonAllPlayers);
            playersTableAdapter.Fill(masterMindDataSet.Players);
        }
                
        private void buttonTournamentsTop_Click(object sender, EventArgs e) {
            GoToTournamentsPage();
            AllTournamentsButtonsDarkBut(buttonAllTournaments);
            tournamentsTableAdapter.Fill(masterMindDataSet.Tournaments);
        }

        private void buttonSearchTop_MouseEnter(object sender, EventArgs e) {
            buttonSearchTop.ForeColor = Color.White;
        }

        private void buttonSearchTop_MouseLeave(object sender, EventArgs e) {
            if (buttonPlayersTop.ForeColor == Color.White || buttonTournamentsTop.ForeColor == Color.White) {
                buttonSearchTop.ForeColor = Color.Silver;
            }
        }

        private void buttonPlayersTop_MouseEnter(object sender, EventArgs e) {
            buttonPlayersTop.ForeColor = Color.White;
        }

        private void buttonPlayersTop_MouseLeave(object sender, EventArgs e) {
            if (buttonSearchTop.ForeColor == Color.White || buttonTournamentsTop.ForeColor == Color.White) {
                buttonPlayersTop.ForeColor = Color.Silver;
            }
        }

        private void buttonTournamentsTop_MouseEnter(object sender, EventArgs e) {
            buttonTournamentsTop.ForeColor = Color.White;
        }

        private void buttonTournamentsTop_MouseLeave(object sender, EventArgs e) {
            if (buttonSearchTop.ForeColor == Color.White || buttonPlayersTop.ForeColor == Color.White) {
                buttonTournamentsTop.ForeColor = Color.Silver;
            }
        }
                
        private void buttonImFeelingLucky_MouseEnter(object sender, EventArgs e) {
            buttonImFeelingLucky.ForeColor = Color.Black;
            buttonImFeelingLucky.FlatAppearance.BorderColor = Color.Silver;
        }

        private void buttonImFeelingLucky_MouseLeave(object sender, EventArgs e) {
            buttonImFeelingLucky.ForeColor = Color.FromArgb(45, 45, 45);
            buttonImFeelingLucky.FlatAppearance.BorderColor = Color.Gainsboro;
        }

        private void buttonSearch_MouseEnter(object sender, EventArgs e) {
            buttonSearch.ForeColor = Color.Black;
            buttonSearch.FlatAppearance.BorderColor = Color.Silver;
        }

        private void buttonSearch_MouseLeave(object sender, EventArgs e) {
            buttonSearch.ForeColor = Color.FromArgb(45, 45, 45);
            buttonSearch.FlatAppearance.BorderColor = Color.Gainsboro;
        }

        private void buttonNewPlayer_MouseEnter(object sender, EventArgs e) {
            buttonNewPlayer.ForeColor = Color.Black;
            buttonNewPlayer.FlatAppearance.BorderColor = Color.Silver;
        }

        private void buttonNewPlayer_MouseLeave(object sender, EventArgs e) {
            buttonNewPlayer.ForeColor = Color.FromArgb(45, 45, 45);
            buttonNewPlayer.FlatAppearance.BorderColor = Color.Gainsboro;
        }

        private void buttonNewTournament_MouseEnter(object sender, EventArgs e) {
            buttonNewTournament.ForeColor = Color.Black;
            buttonNewTournament.FlatAppearance.BorderColor = Color.Silver;
        }

        private void buttonNewTournament_MouseLeave(object sender, EventArgs e) {
            buttonNewTournament.ForeColor = Color.FromArgb(45, 45, 45);
            buttonNewTournament.FlatAppearance.BorderColor = Color.Gainsboro;
        }

        private void buttonMagnifierSearch_MouseEnter(object sender, EventArgs e) {
            buttonMagnifierSearch.FlatAppearance.BorderColor = Color.FromArgb(47, 91, 183);
        }

        private void buttonMagnifierSearch_MouseLeave(object sender, EventArgs e) {
            buttonMagnifierSearch.FlatAppearance.BorderColor = Color.FromArgb(48, 121, 237);
        }

        private void buttonNewPlayer_Click(object sender, EventArgs e) {
            player = false;
            linkLabelCurrentPlayer.Text = "";
            GoToPlayerPage();
            textBoxPlayerName.Focus();
        }

        private void buttonNewTournament_Click(object sender, EventArgs e) {
            tournament = false;
            linkLabelCurrentTournament.Text = "";
            GoToTournamentPage();
            textBoxTournamentName.Focus();
        }

        private void MainWindow_Load(object sender, EventArgs e) {
            panelSearch.Location = new System.Drawing.Point(350, 200);
            panelTopSearch.Location = new System.Drawing.Point(210, 40);
            panelSidePlayers.Location = new System.Drawing.Point(0, 30);
            panelPlayerList.Location = new System.Drawing.Point(210, 80);
            panelPlayer.Location = new System.Drawing.Point(210, 80);
            panelSideTournaments.Location = new System.Drawing.Point(0, 30);
            panelTournamentsList.Location = new System.Drawing.Point(210, 80);
            panelTournament.Location = new System.Drawing.Point(210, 80);
            logOffPlayer();
            logOffTournament();
            textBoxSearch.Focus();
        }

        private void buttonSavePlayerAndBack_Click(object sender, EventArgs e) {
            if (player) {
                playersTableAdapter.UpdateQueryPlayer(textBoxPlayerName.Text, textBoxPlayerFirstName.Text, dateTimePickerPlayerDoB.Value.ToString(), comboBoxPlayerLanguage.Text,
                    comboBoxPlayerNationality.Text, comboBoxPlayerCategory.Text, playerNumber);
                playersTableAdapter.Fill(masterMindDataSet.Players);
            } else {
                playersTableAdapter.InsertQueryNewPlayer(textBoxPlayerName.Text, textBoxPlayerFirstName.Text, dateTimePickerPlayerDoB.Value.ToString(), comboBoxPlayerLanguage.Text, 
                    comboBoxPlayerNationality.Text, comboBoxPlayerCategory.Text);
                playersTableAdapter.Fill(masterMindDataSet.Players);
            }
            GoToPlayersPage();
        }

        private void loadPlayerPage() {
            textBoxPlayerName.Text = playerName;
            textBoxPlayerFirstName.Text = playerFirstName;
            dateTimePickerPlayerDoB.Text = playerDoB;
            comboBoxPlayerLanguage.Text = playerLanguage;
            comboBoxPlayerNationality.Text = playerNationality;
            comboBoxPlayerCategory.Text = playerCategory;
            linkLabelCurrentPlayer.Text = playerName + " " + playerFirstName;
        }

        private void loadTournamentPage() {
            textBoxTournamentName.Text = tournamentName;
            dateTimePickerTournamentDoH.Text = tournamentDoH;
            textBoxTournamentCity.Text = tournamentCity;
            textBoxTournamentProvince.Text = tournamentProvince;
            linkLabelCurrentTournament.Text = tournamentName + " " + tournamentDoH.Substring(0,10);
        }

        private void playersDataGridView_CellClick(object sender, DataGridViewCellEventArgs e) {
            Point dot = playersDataGridView.PointToClient(Cursor.Position);
            DataGridView.HitTestInfo hti = playersDataGridView.HitTest(dot.X, dot.Y);
            bool isClickedFromHearder = hti.Type == DataGridViewHitTestType.ColumnHeader;
            if (!isClickedFromHearder) {
                DataGridViewRow row = playersDataGridView.CurrentRow;
                getPlayerDataFromRow(row);
                linkLabelCurrentPlayer.Text = playerName + " " + playerFirstName;
                player = true;
            } 
        }
        
        private void tournamentsDataGridView_CellClick(object sender, DataGridViewCellEventArgs e) {
            Point dot = tournamentsDataGridView.PointToClient(Cursor.Position);
            DataGridView.HitTestInfo hti = tournamentsDataGridView.HitTest(dot.X, dot.Y);
            bool isClickedFromHearder = hti.Type == DataGridViewHitTestType.ColumnHeader;
            if (!isClickedFromHearder) {
                DataGridViewRow row = tournamentsDataGridView.CurrentRow;
                getTournamentDataFromRow(row);
                tournament = true;
                linkLabelCurrentTournament.Text = tournamentName + " " + tournamentDoH.Substring(0, 10); ;
            } 
        }

        private void panelTournament_VisibleChanged(object sender, EventArgs e) {
            if (tournament) {
                if (player) {
                    buttonAddCurrentPlayerToTournament.Show();
                }
                tournamentControlsShow();
                buttonDeleteCancelTournament.Text = "Supprimer";
                gamesByTourTableAdapter.FillByTour(masterMindDataSet.GamesByTour, tournamentNumber);
                playersByTournamentTableAdapter.FillByTournament(masterMindDataSet.PlayersByTournament, tournamentNumber);
                playerRegisterTournamentTableAdapter.FillByTournamentAndUnpaid(masterMindDataSet.PlayerRegisterTournament, tournamentNumber);
            } else {
                buttonAddCurrentPlayerToTournament.Hide();
                newTournamentControlsHide();
                buttonDeleteCancelTournament.Text = "Annuler";
                textBoxTournamentName.Text = "Ajouter un nom...";
                textBoxTournamentCity.Text = "Ajouter une ville...";
                textBoxTournamentProvince.Text = "Ajouter une province...";
                dateTimePickerTournamentDoH.Text = "";
                masterMindDataSet.GamesByTour.Clear();
                masterMindDataSet.PlayersByTournament.Clear();
            }
        }

        private void buttonSaveTournamentAndBack_Click(object sender, EventArgs e) {
            if (tournament) {
                tournamentsTableAdapter.UpdateQueryTournament(textBoxTournamentName.Text, textBoxTournamentCity.Text, textBoxTournamentProvince.Text, dateTimePickerTournamentDoH.Value.ToString(), tournamentNumber);
                tournamentsTableAdapter.Fill(masterMindDataSet.Tournaments);
            } else {
                tournamentsTableAdapter.InsertQueryNewTournament(textBoxTournamentName.Text, textBoxTournamentCity.Text, textBoxTournamentProvince.Text, dateTimePickerTournamentDoH.Value.ToString());
                tournamentsTableAdapter.Fill(masterMindDataSet.Tournaments);
            }
            GoToTournamentsPage();
        }


        private void panelPlayer_VisibleChanged(object sender, EventArgs e) {
            if (player) {
                if (tournament) {
                    buttonAddCurrentTournamentToPlayer.Show();
                }
                playerControlsShow();
                buttonDeleteCancelPlayer.Text = "Supprimer";
                playerRegisterTournamentTableAdapter.FillByPlayerAndUnpaid(masterMindDataSet.PlayerRegisterTournament, playerNumber);
                tournamentByParticipatingPlayerTableAdapter.FillByParticipatingPlayer(masterMindDataSet.TournamentByParticipatingPlayer, playerNumber);
                tournamentByNotParticipatingPlayerTableAdapter.FillByNotParticipatingPlayer(masterMindDataSet.TournamentByNotParticipatingPlayer, playerNumber);
            } else {
                buttonAddCurrentTournamentToPlayer.Hide();
                newPlayerControlsHide();
                linkLabelCurrentPlayer.Text = "";
                buttonDeleteCancelPlayer.Text = "Annuler";
                textBoxPlayerName.Text = "Ajouter un nom...";
                textBoxPlayerFirstName.Text = "Ajouter un prénom...";
                dateTimePickerPlayerDoB.Text = "";
                comboBoxPlayerCategory.Text = "Choisir...";
                comboBoxPlayerLanguage.Text = "Choisir...";
                comboBoxPlayerNationality.Text = "Choisir...";
            }
        }

        private void buttonDeleteCancelPlayer_Click(object sender, EventArgs e) {
            if (player) {
                gameTableAdapter.DeleteQueryByPlayer(playerNumber);
                registerTableAdapter.DeleteQueryByPlayer(playerNumber);
                playersTableAdapter.DeleteQueryByPlayerNumber(playerNumber);
                playersTableAdapter.Fill(masterMindDataSet.Players);
                linkLabelCurrentPlayer.Text = "";
            }
            GoToPlayersPage();
        }

        private void buttonDeleteCancelTournament_Click(object sender, EventArgs e) {
             if (tournament) {
                gamesByTourTableAdapter.DeleteQueryByTourAllGames(tournamentNumber);
                registerTableAdapter.DeleteQueryByTournament(tournamentNumber);
                tournamentsTableAdapter.DeleteQueryByTournamentNumber(tournamentNumber);
                tournamentsTableAdapter.Fill(masterMindDataSet.Tournaments);
                linkLabelCurrentTournament.Text = "";
            }
            GoToTournamentsPage();
        }
        
        private void tournamentByNotParticipatingPlayerDataGridView_CellDoubleClick(object sender, DataGridViewCellEventArgs e) {
            Point dot = tournamentByNotParticipatingPlayerDataGridView.PointToClient(Cursor.Position);
            DataGridView.HitTestInfo hti = tournamentByNotParticipatingPlayerDataGridView.HitTest(dot.X, dot.Y);
            bool isClickedFromHearder = hti.Type == DataGridViewHitTestType.ColumnHeader;
            if (!isClickedFromHearder) {
                DataGridViewRow row = tournamentByNotParticipatingPlayerDataGridView.CurrentRow;
                getTournamentDataFromRow(row);
                loadTournamentPage();
                tournament = true;
                GoToTournamentPage();
            } 
        }

        private void tournamentByParticipatingPlayerDataGridView_CellDoubleClick(object sender, DataGridViewCellEventArgs e) {
            Point dot = tournamentByParticipatingPlayerDataGridView.PointToClient(Cursor.Position);
            DataGridView.HitTestInfo hti = tournamentByParticipatingPlayerDataGridView.HitTest(dot.X, dot.Y);
            bool isClickedFromHearder = hti.Type == DataGridViewHitTestType.ColumnHeader;
            if (!isClickedFromHearder) {
                DataGridViewRow row = tournamentByParticipatingPlayerDataGridView.CurrentRow;
                getTournamentDataFromRow(row);
                loadTournamentPage();
                tournament = true;
                GoToTournamentPage();
            }
        }

        private void buttonAddGameToTournament_Click(object sender, EventArgs e) {
            gamesByTourTableAdapter.InsertQueryByTour(int.Parse(textBoxGameNumberColors.Text), int.Parse(textBoxGameNumberCells.Text), int.Parse(textBoxGameNumberTries.Text), tournamentNumber);
            gamesByTourTableAdapter.FillByTour(masterMindDataSet.GamesByTour, tournamentNumber);
        }

        private void buttonDeleteGameToTournament_Click(object sender, EventArgs e) {
            gameTableAdapter.DeleteQueryByGameNumber(int.Parse(gamesByTourDataGridView.CurrentRow.Cells[1].Value.ToString()));
            gamesByTourTableAdapter.DeleteQueryByTourOneGame(int.Parse(gamesByTourDataGridView.CurrentRow.Cells[1].Value.ToString()));
            gamesByTourTableAdapter.FillByTour(masterMindDataSet.GamesByTour, tournamentNumber);
        }

        private void buttonResetFormAddGameToTournament_Click(object sender, EventArgs e) {
            textBoxGameNumberColors.Text = "";
            textBoxGameNumberCells.Text = "";
            textBoxGameNumberTries.Text = "";
            textBoxGameNumberColors.Focus();
        }
        
        private void buttonAddTournamentToPlayer_Click(object sender, EventArgs e) {
            DataGridViewRow row = tournamentByNotParticipatingPlayerDataGridView.CurrentRow;
            int tempTourNumber = int.Parse(row.Cells[1].Value.ToString());
            AskIfPlayerPaid aipp = new AskIfPlayerPaid();
            aipp.playerNumber = playerNumber;
            aipp.tourNumber = tempTourNumber;
            aipp.setLabelName(playerName + " " + playerFirstName + " a-t-il payé son inscription ?");
            aipp.ShowDialog();
            tournamentByParticipatingPlayerTableAdapter.FillByParticipatingPlayer(masterMindDataSet.TournamentByParticipatingPlayer, playerNumber);
            tournamentByNotParticipatingPlayerTableAdapter.FillByNotParticipatingPlayer(masterMindDataSet.TournamentByNotParticipatingPlayer, playerNumber);
            playerRegisterTournamentTableAdapter.FillByPlayerAndUnpaid(masterMindDataSet.PlayerRegisterTournament, playerNumber);
        }

        private void buttonDelTournamentToPlayer_Click(object sender, EventArgs e) {
            DataGridViewRow row = tournamentByParticipatingPlayerDataGridView.CurrentRow;
            int tempTourNumber = int.Parse(row.Cells[1].Value.ToString());
            registerTableAdapter.DeleteQueryRegister(playerNumber, tempTourNumber);
            tournamentByParticipatingPlayerTableAdapter.FillByParticipatingPlayer(masterMindDataSet.TournamentByParticipatingPlayer, playerNumber);
            tournamentByNotParticipatingPlayerTableAdapter.FillByNotParticipatingPlayer(masterMindDataSet.TournamentByNotParticipatingPlayer, playerNumber);
            playerRegisterTournamentTableAdapter.FillByPlayerAndUnpaid(masterMindDataSet.PlayerRegisterTournament, playerNumber);
        }

        private void playersByTournamentDataGridView_CellDoubleClick(object sender, DataGridViewCellEventArgs e) {
            Point dot = playersDataGridView.PointToClient(Cursor.Position);
            DataGridView.HitTestInfo hti = playersByTournamentDataGridView.HitTest(dot.X, dot.Y);
            bool isClickedFromHearder = hti.Type == DataGridViewHitTestType.ColumnHeader;
            if (!isClickedFromHearder) {
                DataGridViewRow row = playersByTournamentDataGridView.CurrentRow;
                getPlayerDataFromRow(row);
                loadPlayerPage();
                player = true;
                tournamentByParticipatingPlayerTableAdapter.FillByParticipatingPlayer(masterMindDataSet.TournamentByParticipatingPlayer, playerNumber);
                tournamentByNotParticipatingPlayerTableAdapter.FillByNotParticipatingPlayer(masterMindDataSet.TournamentByNotParticipatingPlayer, playerNumber);
                GoToPlayerPage();
            }
        }

        private void buttonAddCurrentPlayerToTournament_Click(object sender, EventArgs e) {
            if (playerNumber != -1 && tournamentNumber != -1) {
                AskIfPlayerPaid aipp = new AskIfPlayerPaid();
                aipp.playerNumber = playerNumber;
                aipp.tourNumber = tournamentNumber;
                aipp.setLabelName(playerName + " " + playerFirstName + " a-t-il payé son inscription ?");
                aipp.ShowDialog();
                playersByTournamentTableAdapter.FillByTournament(masterMindDataSet.PlayersByTournament, tournamentNumber);
                playerRegisterTournamentTableAdapter.FillByTournamentAndUnpaid(masterMindDataSet.PlayerRegisterTournament, tournamentNumber);
            } else {
                MessageBox.Show("Il n'y a pas de joueur et/ou de tournoi sélectionné");
            }
        }

        private void AddGameToTournament_Click(object sender, EventArgs e) {
            gamesByTourTableAdapter.InsertQueryByTour(int.Parse(textBoxGameNumberColors.Text), int.Parse(textBoxGameNumberCells.Text), int.Parse(textBoxGameNumberTries.Text), tournamentNumber);
            gamesByTourTableAdapter.FillByTour(masterMindDataSet.GamesByTour, tournamentNumber);
            textBoxGameNumberColors.Text = "";
            textBoxGameNumberCells.Text = "";
            textBoxGameNumberTries.Text = "";
            textBoxGameNumberColors.Focus();

        }

        private void textBoxTopSearch_TextChanged(object sender, EventArgs e) {
            if (panelPlayerList.Visible) {
                if (textBoxTopSearch.Text.Length > 3 && (byte)textBoxTopSearch.Text[0] == 45) {
                    switch ((byte)textBoxTopSearch.Text[1]) {
                        case 110: //n pour nom
                            Match mn = Regex.Match(textBoxTopSearch.Text, patternN, RegexOptions.IgnoreCase);
                            if (mn.Success) {
                                playersBindingSource.Filter = "nom like '" + mn.Groups[1] + "*'";
                            }
                            break;
                        case 112: //p pour prénom
                            Match mp = Regex.Match(textBoxTopSearch.Text, patternP, RegexOptions.IgnoreCase);
                            if (mp.Success) {
                                playersBindingSource.Filter = "prenom like '" + mp.Groups[1] + "*'";
                            }
                            break;
                        //case 100: //d pour date de naissance
                        //    Match md = Regex.Match(textBoxTopSearch.Text, patternD, RegexOptions.IgnoreCase);
                        //    if (md.Success) {
                        //        playersBindingSource.Filter = "ddn like '" +  Convert.ToDateTime(md.Groups[1]) + "*'";
                        //    }
                        //    break;
                        case 108: //l pour langue
                            Match ml = Regex.Match(textBoxTopSearch.Text, patternL, RegexOptions.IgnoreCase);
                            if (ml.Success) {
                                playersBindingSource.Filter = "langue like '" + ml.Groups[1] + "*'";
                            }
                            break;
                        case 78: //N pour nationalité
                            Match mN = Regex.Match(textBoxTopSearch.Text, patternNat, RegexOptions.IgnoreCase);
                            if (mN.Success) {
                                playersBindingSource.Filter = "nationalite like '" + mN.Groups[1] + "*'";
                            }
                            break;
                        case 99: //c pour catégorie
                            Match mc = Regex.Match(textBoxTopSearch.Text, patternC, RegexOptions.IgnoreCase);
                            if (mc.Success) {
                                playersBindingSource.Filter = "categorie like '" + mc.Groups[1] + "*'";
                            }
                            break;
                        default:
                            break;
                    }
                } else if (textBoxTopSearch.Text.Length > 0 && textBoxTopSearch.Text.Length <= 3 && (byte)textBoxTopSearch.Text[0] == 45) {
                    //do nothing
                } else {
                    playersBindingSource.Filter = "nom like '" + textBoxTopSearch.Text + "*' OR prenom like '" + textBoxTopSearch.Text + "*'";
                }
            } else if (panelTournamentsList.Visible) {
                if (textBoxTopSearch.Text.Length > 3 && (byte)textBoxTopSearch.Text[0] == 45) {
                    switch ((byte)textBoxTopSearch.Text[1]) {
                        case 110: //n pour nom
                            Match mn = Regex.Match(textBoxTopSearch.Text, patternN, RegexOptions.IgnoreCase);
                            if (mn.Success) {
                                tournamentsBindingSource.Filter = "nom like '" + mn.Groups[1] + "*'";
                            }
                            break;
                        //case 100: //d pour date du tournoi
                        //    Match md = Regex.Match(textBoxTopSearch.Text, patternD, RegexOptions.IgnoreCase);
                        //    if (md.Success) {
                        //        tournamentsBindingSource.Filter = "dateT like '" + Convert.ToDateTime(md.Groups[1]) + "*'";
                        //    }
                        //    break;
                        case 118: //v pour ville
                            Match mv = Regex.Match(textBoxTopSearch.Text, patternV, RegexOptions.IgnoreCase);
                            if (mv.Success) {
                                tournamentsBindingSource.Filter = "ville like '" + mv.Groups[1] + "*'";
                            }
                            break;
                        case 112: //p pour province
                            Match mN = Regex.Match(textBoxTopSearch.Text, patternPro, RegexOptions.IgnoreCase);
                            if (mN.Success) {
                                tournamentsBindingSource.Filter = "province like '" + mN.Groups[1] + "*'";
                            }
                            break;
                        default:
                            break;
                    }
                } else if (textBoxTopSearch.Text.Length > 0 && textBoxTopSearch.Text.Length <= 3 && (byte)textBoxTopSearch.Text[0] == 45) {
                    //do nothing
                } else {
                    tournamentsBindingSource.Filter = "nom like '" + textBoxTopSearch.Text + "*' OR ville like '" + textBoxTopSearch.Text + "*'";
                }
            }
            
            
        }

        private void buttonImFeelingLucky_Click(object sender, EventArgs e) {
            MessageBox.Show("La réponse à la grande question sur la vie, l'univers et le reste est 42.\n Si vous ne comprenez pas, vous n'avez pas saisi la question.");
        }

        private void buttonPay_Click(object sender, EventArgs e) {
            DataGridViewRow row = playerRegisterTournamentDataGridView.CurrentRow;
            registerTableAdapter.UpdateQueryByPlayerAndTour("o",playerNumber,int.Parse(row.Cells[6].Value.ToString()));
            playerRegisterTournamentTableAdapter.FillByPlayerAndUnpaid(masterMindDataSet.PlayerRegisterTournament, playerNumber);
        }

        private void buttonPayTour_Click(object sender, EventArgs e) {
            DataGridViewRow row = playerRegisterTournamentDataGridView1.CurrentRow;
            registerTableAdapter.UpdateQueryByPlayerAndTour("o", int.Parse(row.Cells[3].Value.ToString()),tournamentNumber);
            playerRegisterTournamentTableAdapter.FillByTournamentAndUnpaid(masterMindDataSet.PlayerRegisterTournament, tournamentNumber);
        }

        private void buttonAddCurrentTournamentToPlayer_Click(object sender, EventArgs e) {
            if (tournamentNumber != -1 && playerNumber != -1) {
                AskIfPlayerPaid aipp = new AskIfPlayerPaid();
                aipp.playerNumber = playerNumber;
                aipp.tourNumber = tournamentNumber;
                aipp.setLabelName(playerName + " " + playerFirstName + " a-t-il payé son inscription ?");
                aipp.ShowDialog();
                tournamentByParticipatingPlayerTableAdapter.FillByParticipatingPlayer(masterMindDataSet.TournamentByParticipatingPlayer, playerNumber);
                tournamentByNotParticipatingPlayerTableAdapter.FillByNotParticipatingPlayer(masterMindDataSet.TournamentByNotParticipatingPlayer, playerNumber);
                playerRegisterTournamentTableAdapter.FillByPlayerAndUnpaid(masterMindDataSet.PlayerRegisterTournament, playerNumber);
            } else {
                MessageBox.Show("Il n'y a pas de joueur et/ou de tournoi sélectionné");
            }
        }

        private void playersByTournamentDataGridView_CellClick(object sender, DataGridViewCellEventArgs e) {
            Point dot = playersDataGridView.PointToClient(Cursor.Position);
            DataGridView.HitTestInfo hti = playersByTournamentDataGridView.HitTest(dot.X, dot.Y);
            bool isClickedFromHearder = hti.Type == DataGridViewHitTestType.ColumnHeader;
            if (!isClickedFromHearder) {
                DataGridViewRow row = playersByTournamentDataGridView.CurrentRow;
                getPlayerDataFromRow(row);
                loadPlayerPage();
                player = true;
            }
        }

        private void tournamentByNotParticipatingPlayerDataGridView_CellClick(object sender, DataGridViewCellEventArgs e) {
            Point dot = tournamentByNotParticipatingPlayerDataGridView.PointToClient(Cursor.Position);
            DataGridView.HitTestInfo hti = tournamentByNotParticipatingPlayerDataGridView.HitTest(dot.X, dot.Y);
            bool isClickedFromHearder = hti.Type == DataGridViewHitTestType.ColumnHeader;
            if (!isClickedFromHearder) {
                DataGridViewRow row = tournamentByNotParticipatingPlayerDataGridView.CurrentRow;
                getTournamentDataFromRow(row);
                loadTournamentPage();
                tournament = true;
            } 
        }

        private void tournamentByParticipatingPlayerDataGridView_CellClick(object sender, DataGridViewCellEventArgs e) {
            Point dot = tournamentByParticipatingPlayerDataGridView.PointToClient(Cursor.Position);
            DataGridView.HitTestInfo hti = tournamentByParticipatingPlayerDataGridView.HitTest(dot.X, dot.Y);
            bool isClickedFromHearder = hti.Type == DataGridViewHitTestType.ColumnHeader;
            if (!isClickedFromHearder) {
                DataGridViewRow row = tournamentByParticipatingPlayerDataGridView.CurrentRow;
                getTournamentDataFromRow(row);
                loadTournamentPage();
                tournament = true;
            }
        }

        private void buttonAddResults_Click(object sender, EventArgs e) {
            DataGridViewRow row = gamesByTourDataGridView.CurrentRow;
            DataGridViewRow rowP = playersByTournamentDataGridView.CurrentRow;
            int gameNumber = int.Parse(row.Cells[1].Value.ToString());
            int tempPlayerNumber = int.Parse(rowP.Cells[1].Value.ToString());
            bool resultExists = int.Parse(gameTableAdapter.ScalarQueryCountIfAlreadyResult(tempPlayerNumber, gameNumber).ToString()) > 0;
            Results res = new Results();
            if (resultExists) {
                res.labelStatus.Show();
            }
            res.encoded = resultExists;
            res.gameNumber = gameNumber;
            res.playerNumber = tempPlayerNumber;
            res.triesNumber = int.Parse(row.Cells[3].Value.ToString());
            res.ShowDialog();
        }

        private void buttonSavePlayerAndBack_MouseEnter(object sender, EventArgs e) {
            buttonSavePlayerAndBack.ForeColor = Color.Black;
            buttonSavePlayerAndBack.FlatAppearance.BorderColor = Color.Silver;
        }

        private void buttonDeleteCancelPlayer_MouseEnter(object sender, EventArgs e) {
            buttonDeleteCancelPlayer.ForeColor = Color.Black;
            buttonDeleteCancelPlayer.FlatAppearance.BorderColor = Color.Silver;
        }

        private void buttonAddCurrentTournamentToPlayer_MouseEnter(object sender, EventArgs e) {
            buttonAddCurrentTournamentToPlayer.ForeColor = Color.Black;
            buttonAddCurrentTournamentToPlayer.FlatAppearance.BorderColor = Color.Silver;
        }

        private void buttonAddTournamentToPlayer_MouseEnter(object sender, EventArgs e) {
            buttonAddTournamentToPlayer.ForeColor = Color.Black;
            buttonAddTournamentToPlayer.FlatAppearance.BorderColor = Color.Silver;
        }

        private void buttonDelTournamentToPlayer_MouseEnter(object sender, EventArgs e) {
            buttonDelTournamentToPlayer.ForeColor = Color.Black;
            buttonDelTournamentToPlayer.FlatAppearance.BorderColor = Color.Silver;
        }

        private void buttonPay_MouseEnter(object sender, EventArgs e) {
            buttonPay.ForeColor = Color.Black;
            buttonPay.FlatAppearance.BorderColor = Color.Silver;
        }

        private void buttonSaveTournamentAndBack_MouseEnter(object sender, EventArgs e) {
            buttonSaveTournamentAndBack.ForeColor = Color.Black;
            buttonSaveTournamentAndBack.FlatAppearance.BorderColor = Color.Silver;
        }

        private void buttonDeleteCancelTournament_MouseEnter(object sender, EventArgs e) {
            buttonDeleteCancelTournament.ForeColor = Color.Black;
            buttonDeleteCancelTournament.FlatAppearance.BorderColor = Color.Silver;
        }

        private void buttonAddCurrentPlayerToTournament_MouseEnter(object sender, EventArgs e) {
            buttonAddCurrentPlayerToTournament.ForeColor = Color.Black;
            buttonAddCurrentPlayerToTournament.FlatAppearance.BorderColor = Color.Silver;
        }

        private void buttonDeleteGameToTournament_MouseEnter(object sender, EventArgs e) {
            buttonDeleteGameToTournament.ForeColor = Color.Black;
            buttonDeleteGameToTournament.FlatAppearance.BorderColor = Color.Silver;
        }

        private void buttonAddResults_MouseEnter(object sender, EventArgs e) {
            buttonAddResults.ForeColor = Color.Black;
            buttonAddResults.FlatAppearance.BorderColor = Color.Silver;
        }

        private void AddGameToTournament_MouseEnter(object sender, EventArgs e) {
            AddGameToTournament.ForeColor = Color.Black;
            AddGameToTournament.FlatAppearance.BorderColor = Color.Silver;
        }

        private void buttonResetFormAddGameToTournament_MouseEnter(object sender, EventArgs e) {
            buttonResetFormAddGameToTournament.ForeColor = Color.Black;
            buttonResetFormAddGameToTournament.FlatAppearance.BorderColor = Color.Silver;
        }

        private void buttonSavePlayerAndBack_MouseLeave(object sender, EventArgs e) {
            buttonSavePlayerAndBack.ForeColor = Color.FromArgb(45, 45, 45);
            buttonSavePlayerAndBack.FlatAppearance.BorderColor = Color.Gainsboro;
        }

        private void buttonDeleteCancelPlayer_MouseLeave(object sender, EventArgs e) {
            buttonDeleteCancelPlayer.ForeColor = Color.FromArgb(45, 45, 45);
            buttonDeleteCancelPlayer.FlatAppearance.BorderColor = Color.Gainsboro;
        }

        private void buttonAddCurrentTournamentToPlayer_MouseLeave(object sender, EventArgs e) {
            buttonAddCurrentTournamentToPlayer.ForeColor = Color.FromArgb(45, 45, 45);
            buttonAddCurrentTournamentToPlayer.FlatAppearance.BorderColor = Color.Gainsboro;
        }

        private void buttonAddTournamentToPlayer_MouseLeave(object sender, EventArgs e) {
            buttonAddTournamentToPlayer.ForeColor = Color.FromArgb(45, 45, 45);
            buttonAddTournamentToPlayer.FlatAppearance.BorderColor = Color.Gainsboro;
        }

        private void buttonDelTournamentToPlayer_MouseLeave(object sender, EventArgs e) {
            buttonDelTournamentToPlayer.ForeColor = Color.FromArgb(45, 45, 45);
            buttonDelTournamentToPlayer.FlatAppearance.BorderColor = Color.Gainsboro;
        }

        private void buttonPay_MouseLeave(object sender, EventArgs e) {
            buttonPay.ForeColor = Color.FromArgb(45, 45, 45);
            buttonPay.FlatAppearance.BorderColor = Color.Gainsboro;
        }

        private void buttonSaveTournamentAndBack_MouseLeave(object sender, EventArgs e) {
            buttonSaveTournamentAndBack.ForeColor = Color.FromArgb(45, 45, 45);
            buttonSaveTournamentAndBack.FlatAppearance.BorderColor = Color.Gainsboro;
        }

        private void buttonDeleteCancelTournament_MouseLeave(object sender, EventArgs e) {
            buttonDeleteCancelTournament.ForeColor = Color.FromArgb(45, 45, 45);
            buttonDeleteCancelTournament.FlatAppearance.BorderColor = Color.Gainsboro;
        }

        private void buttonAddCurrentPlayerToTournament_MouseLeave(object sender, EventArgs e) {
            buttonAddCurrentPlayerToTournament.ForeColor = Color.FromArgb(45, 45, 45);
            buttonAddCurrentPlayerToTournament.FlatAppearance.BorderColor = Color.Gainsboro;
        }

        private void buttonDeleteGameToTournament_MouseLeave(object sender, EventArgs e) {
            buttonDeleteGameToTournament.ForeColor = Color.FromArgb(45, 45, 45);
            buttonDeleteGameToTournament.FlatAppearance.BorderColor = Color.Gainsboro;
        }

        private void buttonAddResults_MouseLeave(object sender, EventArgs e) {
            buttonAddResults.ForeColor = Color.FromArgb(45, 45, 45);
            buttonAddResults.FlatAppearance.BorderColor = Color.Gainsboro;
        }

        private void AddGameToTournament_MouseLeave(object sender, EventArgs e) {
            AddGameToTournament.ForeColor = Color.FromArgb(45, 45, 45);
            AddGameToTournament.FlatAppearance.BorderColor = Color.Gainsboro;
        }

        private void buttonResetFormAddGameToTournament_MouseLeave(object sender, EventArgs e) {
            buttonResetFormAddGameToTournament.ForeColor = Color.FromArgb(45, 45, 45);
            buttonResetFormAddGameToTournament.FlatAppearance.BorderColor = Color.Gainsboro;
        }

        private void buttonPayTour_MouseEnter(object sender, EventArgs e) {
            buttonPayTour.ForeColor = Color.Black;
            buttonPayTour.FlatAppearance.BorderColor = Color.Silver;
        }

        private void buttonPayTour_MouseLeave(object sender, EventArgs e) {
            buttonPayTour.ForeColor = Color.FromArgb(45, 45, 45);
            buttonPayTour.FlatAppearance.BorderColor = Color.Gainsboro;
        }

        private void buttonAllPlayers_Click(object sender, EventArgs e) {
            playersTableAdapter.Fill(masterMindDataSet.Players);
            AllPlayersButtonsDarkBut(buttonAllPlayers);
            GoToPlayersPage();
        }

        private void buttonBelgians_Click(object sender, EventArgs e) {
            playersTableAdapter.FillByBelgian(masterMindDataSet.Players);
            AllPlayersButtonsDarkBut(buttonBelgians);
            GoToPlayersPage();
        }

        private void buttonForeigners_Click(object sender, EventArgs e) {
            playersTableAdapter.FillByForeigners(masterMindDataSet.Players);
            AllPlayersButtonsDarkBut(buttonForeigners);
            GoToPlayersPage();
        }

        private void buttonCatA_Click(object sender, EventArgs e) {
            playersTableAdapter.FillByCategory(masterMindDataSet.Players, "A");
            AllPlayersButtonsDarkBut(buttonCatA);
            GoToPlayersPage();
        }

        private void buttonCatB_Click(object sender, EventArgs e) {
            playersTableAdapter.FillByCategory(masterMindDataSet.Players, "B");
            AllPlayersButtonsDarkBut(buttonCatB);
            GoToPlayersPage();
        }

        private void buttonCatC_Click(object sender, EventArgs e) {
            playersTableAdapter.FillByCategory(masterMindDataSet.Players, "C");
            AllPlayersButtonsDarkBut(buttonCatC);
            GoToPlayersPage();
        }

        private void buttonCatD_Click(object sender, EventArgs e) {
            playersTableAdapter.FillByCategory(masterMindDataSet.Players, "D");
            AllPlayersButtonsDarkBut(buttonCatD);
            GoToPlayersPage();
        }

        private void buttonAllTournaments_Click(object sender, EventArgs e) {
            tournamentsTableAdapter.Fill(masterMindDataSet.Tournaments);
            AllTournamentsButtonsDarkBut(buttonAllTournaments);
            GoToTournamentsPage();
        }

        private void buttonToday_Click(object sender, EventArgs e) {
            tournamentsTableAdapter.FillByEqualsDate(masterMindDataSet.Tournaments, DateTime.Now.ToShortDateString());
            AllTournamentsButtonsDarkBut(buttonToday);
            GoToTournamentsPage();
        }

        private void buttonComing_Click(object sender, EventArgs e) {
            tournamentsTableAdapter.FillByBiggerThanDate(masterMindDataSet.Tournaments, DateTime.Now.ToShortDateString());
            AllTournamentsButtonsDarkBut(buttonComing);
            GoToTournamentsPage();
        }

        private void buttonPast_Click(object sender, EventArgs e) {
            tournamentsTableAdapter.FillBySmallerThanDate(masterMindDataSet.Tournaments, DateTime.Now.ToShortDateString());
            AllTournamentsButtonsDarkBut(buttonPast);
            GoToTournamentsPage();
        }

        private void AllPlayersButtonsDarkBut(Button b) {
            buttonAllPlayers.ForeColor = Color.FromArgb(45, 45, 45);
            buttonBelgians.ForeColor = Color.FromArgb(45, 45, 45);
            buttonForeigners.ForeColor = Color.FromArgb(45, 45, 45);
            buttonCatA.ForeColor = Color.FromArgb(45, 45, 45);
            buttonCatB.ForeColor = Color.FromArgb(45, 45, 45);
            buttonCatC.ForeColor = Color.FromArgb(45, 45, 45);
            buttonCatD.ForeColor = Color.FromArgb(45, 45, 45);
            buttonDeadbeat.ForeColor = Color.FromArgb(45, 45, 45);
            b.ForeColor = Color.FromArgb(221, 75, 57);
        }

        private void AllTournamentsButtonsDarkBut(Button b) {
            buttonAllTournaments.ForeColor = Color.FromArgb(45, 45, 45);
            buttonToday.ForeColor = Color.FromArgb(45, 45, 45);
            buttonComing.ForeColor = Color.FromArgb(45, 45, 45);
            buttonPast.ForeColor = Color.FromArgb(45, 45, 45);
            b.ForeColor = Color.FromArgb(221, 75, 57);
        }

        private void playersDataGridView_CellDoubleClick(object sender, DataGridViewCellEventArgs e) {
            Point dot = playersDataGridView.PointToClient(Cursor.Position);
            DataGridView.HitTestInfo hti = playersDataGridView.HitTest(dot.X, dot.Y);
            bool isClickedFromHearder = hti.Type == DataGridViewHitTestType.ColumnHeader;
            if (!isClickedFromHearder) {
                DataGridViewRow row = playersDataGridView.CurrentRow;
                getPlayerDataFromRow(row);
                loadPlayerPage();
                player = true;
                tournamentByParticipatingPlayerTableAdapter.FillByParticipatingPlayer(masterMindDataSet.TournamentByParticipatingPlayer, playerNumber);
                tournamentByNotParticipatingPlayerTableAdapter.FillByNotParticipatingPlayer(masterMindDataSet.TournamentByNotParticipatingPlayer, playerNumber);
                GoToPlayerPage();
            } 
        }

        private void tournamentsDataGridView_CellDoubleClick(object sender, DataGridViewCellEventArgs e) {
            Point dot = tournamentsDataGridView.PointToClient(Cursor.Position);
            DataGridView.HitTestInfo hti = tournamentsDataGridView.HitTest(dot.X, dot.Y);
            bool isClickedFromHearder = hti.Type == DataGridViewHitTestType.ColumnHeader;
            if (!isClickedFromHearder) {
                DataGridViewRow row = tournamentsDataGridView.CurrentRow;
                getTournamentDataFromRow(row);
                loadTournamentPage();
                tournament = true;
                gamesByTourTableAdapter.FillByTour(masterMindDataSet.GamesByTour, tournamentNumber);
                playersByTournamentTableAdapter.FillByTournament(masterMindDataSet.PlayersByTournament, tournamentNumber);
                GoToTournamentPage();
            } 
        }
                
        private void linkLabelCurrentTournament_MouseUp(object sender, MouseEventArgs e) {
            if (e.Button == System.Windows.Forms.MouseButtons.Right) {
                logOffTournament();
            } else {
                loadTournamentPage();
                GoToTournamentPage();
                buttonTournamentsTop.ForeColor = Color.White;
                buttonPlayersTop.ForeColor = Color.Silver;
            }
        }

        private void linkLabelCurrentPlayer_MouseUp(object sender, MouseEventArgs e) {
            if (e.Button == System.Windows.Forms.MouseButtons.Right) {
                logOffPlayer();
            } else {
                loadPlayerPage();
                GoToPlayerPage();
                buttonTournamentsTop.ForeColor = Color.Silver;
                buttonPlayersTop.ForeColor = Color.White;
            }
        }

        private void buttonDisplayResults_MouseEnter(object sender, EventArgs e) {
            buttonDisplayResults.ForeColor = Color.Black;
            buttonDisplayResults.FlatAppearance.BorderColor = Color.Silver;
        }

        private void buttonDisplayResults_MouseLeave(object sender, EventArgs e) {
            buttonDisplayResults.ForeColor = Color.FromArgb(45, 45, 45);
            buttonDisplayResults.FlatAppearance.BorderColor = Color.Gainsboro;
        }

        private void buttonDisplayResultsPlayer_MouseEnter(object sender, EventArgs e) {
            buttonDisplayResultsPlayer.ForeColor = Color.Black;
            buttonDisplayResultsPlayer.FlatAppearance.BorderColor = Color.Silver;
        }

        private void buttonDisplayResultsPlayer_MouseLeave(object sender, EventArgs e) {
            buttonDisplayResultsPlayer.ForeColor = Color.FromArgb(45, 45, 45);
            buttonDisplayResultsPlayer.FlatAppearance.BorderColor = Color.Gainsboro;
        }

        private void buttonDisplayResults_Click(object sender, EventArgs e) {
            ResultsDisplay resD = new ResultsDisplay();
            resD.Text = "Résultats tournoi";
            resD.tournamentNumber = tournamentNumber;
            resD.player = false;
            resD.Show();
        }

        private void buttonDisplayResultsPlayer_Click(object sender, EventArgs e) {
            DataGridViewRow rowP = playersByTournamentDataGridView.CurrentRow;
            int tempPlayerNumber = int.Parse(rowP.Cells[1].Value.ToString());
            ResultsDisplay resD = new ResultsDisplay();
            resD.Text = "Résultats tournoi " + rowP.Cells[0].Value.ToString() + " " + rowP.Cells[2].Value.ToString();
            resD.tournamentNumber = tournamentNumber;
            resD.playerNumber = tempPlayerNumber;
            resD.player = true;
            resD.Show();
        }

        private void buttonDeadbeat_Click(object sender, EventArgs e) {
            playersTableAdapter.FillByDeadbeat(masterMindDataSet.Players);
            AllPlayersButtonsDarkBut(buttonDeadbeat);
            GoToPlayersPage();
        }

        
         
    }
}
