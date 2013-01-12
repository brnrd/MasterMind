namespace MasterMind {
    partial class Results {
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Results));
            this.buttonWon = new System.Windows.Forms.Button();
            this.labelTriesNumber = new System.Windows.Forms.Label();
            this.textBoxTries = new System.Windows.Forms.TextBox();
            this.labelNumberMax = new System.Windows.Forms.Label();
            this.buttonLost = new System.Windows.Forms.Button();
            this.labelStatus = new System.Windows.Forms.Label();
            this.buttonCancel = new System.Windows.Forms.Button();
            this.gameTableAdapter = new MasterMind.MasterMindDataSetTableAdapters.GameTableAdapter();
            this.SuspendLayout();
            // 
            // buttonWon
            // 
            this.buttonWon.BackColor = System.Drawing.Color.WhiteSmoke;
            this.buttonWon.FlatAppearance.BorderColor = System.Drawing.Color.Gainsboro;
            this.buttonWon.FlatAppearance.MouseDownBackColor = System.Drawing.Color.WhiteSmoke;
            this.buttonWon.FlatAppearance.MouseOverBackColor = System.Drawing.Color.WhiteSmoke;
            this.buttonWon.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonWon.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonWon.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(45)))), ((int)(((byte)(45)))));
            this.buttonWon.Location = new System.Drawing.Point(23, 87);
            this.buttonWon.Name = "buttonWon";
            this.buttonWon.Size = new System.Drawing.Size(75, 27);
            this.buttonWon.TabIndex = 2;
            this.buttonWon.Text = "&Gagné";
            this.buttonWon.UseVisualStyleBackColor = false;
            this.buttonWon.Click += new System.EventHandler(this.buttonWon_Click);
            this.buttonWon.MouseEnter += new System.EventHandler(this.buttonWon_MouseEnter);
            this.buttonWon.MouseLeave += new System.EventHandler(this.buttonWon_MouseLeave);
            // 
            // labelTriesNumber
            // 
            this.labelTriesNumber.AutoSize = true;
            this.labelTriesNumber.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelTriesNumber.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(45)))), ((int)(((byte)(45)))));
            this.labelTriesNumber.Location = new System.Drawing.Point(37, 26);
            this.labelTriesNumber.Name = "labelTriesNumber";
            this.labelTriesNumber.Size = new System.Drawing.Size(127, 16);
            this.labelTriesNumber.TabIndex = 109;
            this.labelTriesNumber.Text = "Nombre de coups :";
            // 
            // textBoxTries
            // 
            this.textBoxTries.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textBoxTries.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxTries.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(45)))), ((int)(((byte)(45)))));
            this.textBoxTries.Location = new System.Drawing.Point(170, 24);
            this.textBoxTries.Name = "textBoxTries";
            this.textBoxTries.Size = new System.Drawing.Size(49, 22);
            this.textBoxTries.TabIndex = 1;
            // 
            // labelNumberMax
            // 
            this.labelNumberMax.AutoSize = true;
            this.labelNumberMax.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelNumberMax.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(45)))), ((int)(((byte)(45)))));
            this.labelNumberMax.Location = new System.Drawing.Point(225, 26);
            this.labelNumberMax.Name = "labelNumberMax";
            this.labelNumberMax.Size = new System.Drawing.Size(20, 16);
            this.labelNumberMax.TabIndex = 112;
            this.labelNumberMax.Text = "/x";
            // 
            // buttonLost
            // 
            this.buttonLost.BackColor = System.Drawing.Color.WhiteSmoke;
            this.buttonLost.FlatAppearance.BorderColor = System.Drawing.Color.Gainsboro;
            this.buttonLost.FlatAppearance.MouseDownBackColor = System.Drawing.Color.WhiteSmoke;
            this.buttonLost.FlatAppearance.MouseOverBackColor = System.Drawing.Color.WhiteSmoke;
            this.buttonLost.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonLost.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonLost.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(45)))), ((int)(((byte)(45)))));
            this.buttonLost.Location = new System.Drawing.Point(104, 87);
            this.buttonLost.Name = "buttonLost";
            this.buttonLost.Size = new System.Drawing.Size(75, 27);
            this.buttonLost.TabIndex = 3;
            this.buttonLost.Text = "&Perdu";
            this.buttonLost.UseVisualStyleBackColor = false;
            this.buttonLost.Click += new System.EventHandler(this.buttonLost_Click);
            this.buttonLost.MouseEnter += new System.EventHandler(this.buttonLost_MouseEnter);
            this.buttonLost.MouseLeave += new System.EventHandler(this.buttonLost_MouseLeave);
            // 
            // labelStatus
            // 
            this.labelStatus.AutoSize = true;
            this.labelStatus.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelStatus.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(45)))), ((int)(((byte)(45)))));
            this.labelStatus.Location = new System.Drawing.Point(91, 59);
            this.labelStatus.Name = "labelStatus";
            this.labelStatus.Size = new System.Drawing.Size(101, 16);
            this.labelStatus.TabIndex = 109;
            this.labelStatus.Text = "Mettre à jour ?";
            this.labelStatus.Visible = false;
            // 
            // buttonCancel
            // 
            this.buttonCancel.BackColor = System.Drawing.Color.WhiteSmoke;
            this.buttonCancel.FlatAppearance.BorderColor = System.Drawing.Color.Gainsboro;
            this.buttonCancel.FlatAppearance.MouseDownBackColor = System.Drawing.Color.WhiteSmoke;
            this.buttonCancel.FlatAppearance.MouseOverBackColor = System.Drawing.Color.WhiteSmoke;
            this.buttonCancel.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonCancel.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonCancel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(45)))), ((int)(((byte)(45)))));
            this.buttonCancel.Location = new System.Drawing.Point(185, 87);
            this.buttonCancel.Name = "buttonCancel";
            this.buttonCancel.Size = new System.Drawing.Size(75, 27);
            this.buttonCancel.TabIndex = 4;
            this.buttonCancel.Text = "&Cancel";
            this.buttonCancel.UseVisualStyleBackColor = false;
            this.buttonCancel.Click += new System.EventHandler(this.buttonCancel_Click);
            this.buttonCancel.MouseEnter += new System.EventHandler(this.buttonCancel_MouseEnter);
            this.buttonCancel.MouseLeave += new System.EventHandler(this.buttonCancel_MouseLeave);
            // 
            // gameTableAdapter
            // 
            this.gameTableAdapter.ClearBeforeFill = true;
            // 
            // Results
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(283, 135);
            this.Controls.Add(this.buttonCancel);
            this.Controls.Add(this.buttonLost);
            this.Controls.Add(this.labelNumberMax);
            this.Controls.Add(this.buttonWon);
            this.Controls.Add(this.labelStatus);
            this.Controls.Add(this.labelTriesNumber);
            this.Controls.Add(this.textBoxTries);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Results";
            this.Text = "Résultat partie";
            this.Shown += new System.EventHandler(this.Results_Shown);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button buttonWon;
        private System.Windows.Forms.Label labelTriesNumber;
        private System.Windows.Forms.TextBox textBoxTries;
        private System.Windows.Forms.Label labelNumberMax;
        private System.Windows.Forms.Button buttonLost;
        private MasterMindDataSetTableAdapters.GameTableAdapter gameTableAdapter;
        private System.Windows.Forms.Button buttonCancel;
        public System.Windows.Forms.Label labelStatus;
    }
}