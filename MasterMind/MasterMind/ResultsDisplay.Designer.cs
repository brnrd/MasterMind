namespace MasterMind {
    partial class ResultsDisplay {
        /// <summary>
        /// Variable nécessaire au concepteur.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Nettoyage des ressources utilisées.
        /// </summary>
        /// <param name="disposing">true si les ressources managées doivent être supprimées ; sinon, false.</param>
        protected override void Dispose(bool disposing) {
            if (disposing && (components != null)) {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Code généré par le Concepteur Windows Form

        /// <summary>
        /// Méthode requise pour la prise en charge du concepteur - ne modifiez pas
        /// le contenu de cette méthode avec l'éditeur de code.
        /// </summary>
        private void InitializeComponent() {
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ResultsDisplay));
            this.masterMindDataSet = new MasterMind.MasterMindDataSet();
            this.tableAdapterManager = new MasterMind.MasterMindDataSetTableAdapters.TableAdapterManager();
            this.f___ingHellBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.f___ingHellTableAdapter = new MasterMind.MasterMindDataSetTableAdapters.F___ingHellTableAdapter();
            this.f___ingHellDataGridView = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn11 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn10 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn12 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn9 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn6 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn7 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn8 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn13 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn14 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn15 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn16 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn17 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.buttonClose = new System.Windows.Forms.Button();
            this.buttonRefresh = new System.Windows.Forms.Button();
            this.buttonSeeAll = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.masterMindDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.f___ingHellBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.f___ingHellDataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // masterMindDataSet
            // 
            this.masterMindDataSet.DataSetName = "MasterMindDataSet";
            this.masterMindDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.Connection = null;
            this.tableAdapterManager.GamesByTourTableAdapter = null;
            this.tableAdapterManager.GameTableAdapter = null;
            this.tableAdapterManager.InscrireTableAdapter = null;
            this.tableAdapterManager.JouerTableAdapter = null;
            this.tableAdapterManager.JoueursTableAdapter = null;
            this.tableAdapterManager.PartiesTableAdapter = null;
            this.tableAdapterManager.PlayersByTournamentTableAdapter = null;
            this.tableAdapterManager.PlayersTableAdapter = null;
            this.tableAdapterManager.RegisterTableAdapter = null;
            this.tableAdapterManager.TournamentByNotParticipatingPlayerTableAdapter = null;
            this.tableAdapterManager.TournamentByParticipatingPlayerTableAdapter = null;
            this.tableAdapterManager.TournamentsTableAdapter = null;
            this.tableAdapterManager.TournoisTableAdapter = null;
            this.tableAdapterManager.UpdateOrder = MasterMind.MasterMindDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            // 
            // f___ingHellBindingSource
            // 
            this.f___ingHellBindingSource.DataMember = "F***ingHell";
            this.f___ingHellBindingSource.DataSource = this.masterMindDataSet;
            // 
            // f___ingHellTableAdapter
            // 
            this.f___ingHellTableAdapter.ClearBeforeFill = true;
            // 
            // f___ingHellDataGridView
            // 
            this.f___ingHellDataGridView.AllowUserToAddRows = false;
            this.f___ingHellDataGridView.AllowUserToDeleteRows = false;
            this.f___ingHellDataGridView.AllowUserToResizeColumns = false;
            this.f___ingHellDataGridView.AllowUserToResizeRows = false;
            this.f___ingHellDataGridView.AutoGenerateColumns = false;
            this.f___ingHellDataGridView.BackgroundColor = System.Drawing.Color.WhiteSmoke;
            this.f___ingHellDataGridView.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.f___ingHellDataGridView.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None;
            this.f___ingHellDataGridView.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.WhiteSmoke;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(45)))), ((int)(((byte)(45)))));
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(217)))), ((int)(((byte)(224)))), ((int)(((byte)(234)))));
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(45)))), ((int)(((byte)(45)))));
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.f___ingHellDataGridView.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.f___ingHellDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.f___ingHellDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn11,
            this.dataGridViewTextBoxColumn10,
            this.dataGridViewTextBoxColumn12,
            this.dataGridViewTextBoxColumn2,
            this.dataGridViewTextBoxColumn3,
            this.dataGridViewTextBoxColumn9,
            this.dataGridViewTextBoxColumn4,
            this.dataGridViewTextBoxColumn1,
            this.dataGridViewTextBoxColumn5,
            this.dataGridViewTextBoxColumn6,
            this.dataGridViewTextBoxColumn7,
            this.dataGridViewTextBoxColumn8,
            this.dataGridViewTextBoxColumn13,
            this.dataGridViewTextBoxColumn14,
            this.dataGridViewTextBoxColumn15,
            this.dataGridViewTextBoxColumn16,
            this.dataGridViewTextBoxColumn17});
            this.f___ingHellDataGridView.Cursor = System.Windows.Forms.Cursors.Hand;
            this.f___ingHellDataGridView.DataSource = this.f___ingHellBindingSource;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(45)))), ((int)(((byte)(45)))));
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(217)))), ((int)(((byte)(224)))), ((int)(((byte)(234)))));
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(45)))), ((int)(((byte)(45)))));
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.f___ingHellDataGridView.DefaultCellStyle = dataGridViewCellStyle2;
            this.f___ingHellDataGridView.EnableHeadersVisualStyles = false;
            this.f___ingHellDataGridView.GridColor = System.Drawing.Color.White;
            this.f___ingHellDataGridView.Location = new System.Drawing.Point(16, 14);
            this.f___ingHellDataGridView.Margin = new System.Windows.Forms.Padding(4);
            this.f___ingHellDataGridView.Name = "f___ingHellDataGridView";
            this.f___ingHellDataGridView.ReadOnly = true;
            this.f___ingHellDataGridView.RowHeadersVisible = false;
            this.f___ingHellDataGridView.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.f___ingHellDataGridView.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.f___ingHellDataGridView.ShowCellErrors = false;
            this.f___ingHellDataGridView.ShowCellToolTips = false;
            this.f___ingHellDataGridView.ShowEditingIcon = false;
            this.f___ingHellDataGridView.ShowRowErrors = false;
            this.f___ingHellDataGridView.Size = new System.Drawing.Size(772, 471);
            this.f___ingHellDataGridView.TabIndex = 0;
            this.f___ingHellDataGridView.TabStop = false;
            this.f___ingHellDataGridView.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.f___ingHellDataGridView_CellClick);
            // 
            // dataGridViewTextBoxColumn11
            // 
            this.dataGridViewTextBoxColumn11.DataPropertyName = "nom";
            this.dataGridViewTextBoxColumn11.HeaderText = "Nom";
            this.dataGridViewTextBoxColumn11.Name = "dataGridViewTextBoxColumn11";
            this.dataGridViewTextBoxColumn11.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn10
            // 
            this.dataGridViewTextBoxColumn10.DataPropertyName = "idJ";
            this.dataGridViewTextBoxColumn10.HeaderText = "idJ";
            this.dataGridViewTextBoxColumn10.Name = "dataGridViewTextBoxColumn10";
            this.dataGridViewTextBoxColumn10.ReadOnly = true;
            this.dataGridViewTextBoxColumn10.Visible = false;
            // 
            // dataGridViewTextBoxColumn12
            // 
            this.dataGridViewTextBoxColumn12.DataPropertyName = "prenom";
            this.dataGridViewTextBoxColumn12.HeaderText = "Prénom";
            this.dataGridViewTextBoxColumn12.Name = "dataGridViewTextBoxColumn12";
            this.dataGridViewTextBoxColumn12.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.DataPropertyName = "nbCouleurs";
            this.dataGridViewTextBoxColumn2.HeaderText = "Couleurs";
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            this.dataGridViewTextBoxColumn2.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn3
            // 
            this.dataGridViewTextBoxColumn3.DataPropertyName = "nbCases";
            this.dataGridViewTextBoxColumn3.HeaderText = "Cases";
            this.dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
            this.dataGridViewTextBoxColumn3.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn9
            // 
            this.dataGridViewTextBoxColumn9.DataPropertyName = "nbCoups";
            this.dataGridViewTextBoxColumn9.HeaderText = "Coups réalisés";
            this.dataGridViewTextBoxColumn9.Name = "dataGridViewTextBoxColumn9";
            this.dataGridViewTextBoxColumn9.ReadOnly = true;
            this.dataGridViewTextBoxColumn9.Width = 150;
            // 
            // dataGridViewTextBoxColumn4
            // 
            this.dataGridViewTextBoxColumn4.DataPropertyName = "nbEssaisMax";
            this.dataGridViewTextBoxColumn4.HeaderText = "Essais maximum";
            this.dataGridViewTextBoxColumn4.Name = "dataGridViewTextBoxColumn4";
            this.dataGridViewTextBoxColumn4.ReadOnly = true;
            this.dataGridViewTextBoxColumn4.Width = 150;
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.DataPropertyName = "idP";
            this.dataGridViewTextBoxColumn1.HeaderText = "idP";
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            this.dataGridViewTextBoxColumn1.ReadOnly = true;
            this.dataGridViewTextBoxColumn1.Visible = false;
            // 
            // dataGridViewTextBoxColumn5
            // 
            this.dataGridViewTextBoxColumn5.DataPropertyName = "numT";
            this.dataGridViewTextBoxColumn5.HeaderText = "numT";
            this.dataGridViewTextBoxColumn5.Name = "dataGridViewTextBoxColumn5";
            this.dataGridViewTextBoxColumn5.ReadOnly = true;
            this.dataGridViewTextBoxColumn5.Visible = false;
            // 
            // dataGridViewTextBoxColumn6
            // 
            this.dataGridViewTextBoxColumn6.DataPropertyName = "numJ";
            this.dataGridViewTextBoxColumn6.HeaderText = "numJ";
            this.dataGridViewTextBoxColumn6.Name = "dataGridViewTextBoxColumn6";
            this.dataGridViewTextBoxColumn6.ReadOnly = true;
            this.dataGridViewTextBoxColumn6.Visible = false;
            // 
            // dataGridViewTextBoxColumn7
            // 
            this.dataGridViewTextBoxColumn7.DataPropertyName = "numP";
            this.dataGridViewTextBoxColumn7.HeaderText = "numP";
            this.dataGridViewTextBoxColumn7.Name = "dataGridViewTextBoxColumn7";
            this.dataGridViewTextBoxColumn7.ReadOnly = true;
            this.dataGridViewTextBoxColumn7.Visible = false;
            // 
            // dataGridViewTextBoxColumn8
            // 
            this.dataGridViewTextBoxColumn8.DataPropertyName = "gagnePerdu";
            this.dataGridViewTextBoxColumn8.HeaderText = "Résultat";
            this.dataGridViewTextBoxColumn8.Name = "dataGridViewTextBoxColumn8";
            this.dataGridViewTextBoxColumn8.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn13
            // 
            this.dataGridViewTextBoxColumn13.DataPropertyName = "ddn";
            this.dataGridViewTextBoxColumn13.HeaderText = "ddn";
            this.dataGridViewTextBoxColumn13.Name = "dataGridViewTextBoxColumn13";
            this.dataGridViewTextBoxColumn13.ReadOnly = true;
            this.dataGridViewTextBoxColumn13.Visible = false;
            // 
            // dataGridViewTextBoxColumn14
            // 
            this.dataGridViewTextBoxColumn14.DataPropertyName = "langue";
            this.dataGridViewTextBoxColumn14.HeaderText = "langue";
            this.dataGridViewTextBoxColumn14.Name = "dataGridViewTextBoxColumn14";
            this.dataGridViewTextBoxColumn14.ReadOnly = true;
            this.dataGridViewTextBoxColumn14.Visible = false;
            // 
            // dataGridViewTextBoxColumn15
            // 
            this.dataGridViewTextBoxColumn15.DataPropertyName = "nationalite";
            this.dataGridViewTextBoxColumn15.HeaderText = "nationalite";
            this.dataGridViewTextBoxColumn15.Name = "dataGridViewTextBoxColumn15";
            this.dataGridViewTextBoxColumn15.ReadOnly = true;
            this.dataGridViewTextBoxColumn15.Visible = false;
            // 
            // dataGridViewTextBoxColumn16
            // 
            this.dataGridViewTextBoxColumn16.DataPropertyName = "categorie";
            this.dataGridViewTextBoxColumn16.HeaderText = "categorie";
            this.dataGridViewTextBoxColumn16.Name = "dataGridViewTextBoxColumn16";
            this.dataGridViewTextBoxColumn16.ReadOnly = true;
            this.dataGridViewTextBoxColumn16.Visible = false;
            // 
            // dataGridViewTextBoxColumn17
            // 
            this.dataGridViewTextBoxColumn17.DataPropertyName = "idT";
            this.dataGridViewTextBoxColumn17.HeaderText = "idT";
            this.dataGridViewTextBoxColumn17.Name = "dataGridViewTextBoxColumn17";
            this.dataGridViewTextBoxColumn17.ReadOnly = true;
            this.dataGridViewTextBoxColumn17.Visible = false;
            // 
            // buttonClose
            // 
            this.buttonClose.BackColor = System.Drawing.Color.WhiteSmoke;
            this.buttonClose.FlatAppearance.BorderColor = System.Drawing.Color.Gainsboro;
            this.buttonClose.FlatAppearance.MouseDownBackColor = System.Drawing.Color.WhiteSmoke;
            this.buttonClose.FlatAppearance.MouseOverBackColor = System.Drawing.Color.WhiteSmoke;
            this.buttonClose.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonClose.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonClose.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(45)))), ((int)(((byte)(45)))));
            this.buttonClose.Location = new System.Drawing.Point(460, 493);
            this.buttonClose.Margin = new System.Windows.Forms.Padding(4);
            this.buttonClose.Name = "buttonClose";
            this.buttonClose.Size = new System.Drawing.Size(100, 33);
            this.buttonClose.TabIndex = 3;
            this.buttonClose.Text = "&Fermer";
            this.buttonClose.UseVisualStyleBackColor = false;
            this.buttonClose.Click += new System.EventHandler(this.buttonClose_Click);
            this.buttonClose.MouseEnter += new System.EventHandler(this.buttonClose_MouseEnter);
            this.buttonClose.MouseLeave += new System.EventHandler(this.buttonClose_MouseLeave);
            // 
            // buttonRefresh
            // 
            this.buttonRefresh.BackColor = System.Drawing.Color.WhiteSmoke;
            this.buttonRefresh.FlatAppearance.BorderColor = System.Drawing.Color.Gainsboro;
            this.buttonRefresh.FlatAppearance.MouseDownBackColor = System.Drawing.Color.WhiteSmoke;
            this.buttonRefresh.FlatAppearance.MouseOverBackColor = System.Drawing.Color.WhiteSmoke;
            this.buttonRefresh.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonRefresh.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonRefresh.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(45)))), ((int)(((byte)(45)))));
            this.buttonRefresh.Location = new System.Drawing.Point(352, 493);
            this.buttonRefresh.Margin = new System.Windows.Forms.Padding(4);
            this.buttonRefresh.Name = "buttonRefresh";
            this.buttonRefresh.Size = new System.Drawing.Size(100, 33);
            this.buttonRefresh.TabIndex = 2;
            this.buttonRefresh.Text = "&Actualiser";
            this.buttonRefresh.UseVisualStyleBackColor = false;
            this.buttonRefresh.Click += new System.EventHandler(this.buttonRefresh_Click);
            this.buttonRefresh.MouseEnter += new System.EventHandler(this.buttonRefresh_MouseEnter);
            this.buttonRefresh.MouseLeave += new System.EventHandler(this.buttonRefresh_MouseLeave);
            // 
            // buttonSeeAll
            // 
            this.buttonSeeAll.BackColor = System.Drawing.Color.WhiteSmoke;
            this.buttonSeeAll.FlatAppearance.BorderColor = System.Drawing.Color.Gainsboro;
            this.buttonSeeAll.FlatAppearance.MouseDownBackColor = System.Drawing.Color.WhiteSmoke;
            this.buttonSeeAll.FlatAppearance.MouseOverBackColor = System.Drawing.Color.WhiteSmoke;
            this.buttonSeeAll.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonSeeAll.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonSeeAll.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(45)))), ((int)(((byte)(45)))));
            this.buttonSeeAll.Location = new System.Drawing.Point(244, 493);
            this.buttonSeeAll.Margin = new System.Windows.Forms.Padding(4);
            this.buttonSeeAll.Name = "buttonSeeAll";
            this.buttonSeeAll.Size = new System.Drawing.Size(100, 33);
            this.buttonSeeAll.TabIndex = 1;
            this.buttonSeeAll.Text = "&Tout voir";
            this.buttonSeeAll.UseVisualStyleBackColor = false;
            this.buttonSeeAll.Click += new System.EventHandler(this.buttonSeeAll_Click);
            this.buttonSeeAll.MouseEnter += new System.EventHandler(this.buttonSeeAll_MouseEnter);
            this.buttonSeeAll.MouseLeave += new System.EventHandler(this.buttonSeeAll_MouseLeave);
            // 
            // ResultsDisplay
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(805, 541);
            this.Controls.Add(this.buttonSeeAll);
            this.Controls.Add(this.buttonRefresh);
            this.Controls.Add(this.buttonClose);
            this.Controls.Add(this.f___ingHellDataGridView);
            this.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(45)))), ((int)(((byte)(45)))));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "ResultsDisplay";
            this.Text = "Résultats tournoi";
            this.Load += new System.EventHandler(this.ResultsDisplay_Load);
            ((System.ComponentModel.ISupportInitialize)(this.masterMindDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.f___ingHellBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.f___ingHellDataGridView)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private MasterMindDataSet masterMindDataSet;
        private MasterMindDataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.BindingSource f___ingHellBindingSource;
        private MasterMindDataSetTableAdapters.F___ingHellTableAdapter f___ingHellTableAdapter;
        private System.Windows.Forms.DataGridView f___ingHellDataGridView;
        private System.Windows.Forms.Button buttonClose;
        private System.Windows.Forms.Button buttonRefresh;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn11;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn10;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn12;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn9;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn4;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn5;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn6;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn7;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn8;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn13;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn14;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn15;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn16;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn17;
        private System.Windows.Forms.Button buttonSeeAll;
    }
}