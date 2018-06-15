namespace ExcelFilter
{
    partial class MainFormView
    {
        /// <summary>
        /// Variable nécessaire au concepteur.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Nettoyage des ressources utilisées.
        /// </summary>
        /// <param name="disposing">true si les ressources managées doivent être supprimées ; sinon, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Code généré par le Concepteur Windows Form

        /// <summary>
        /// Méthode requise pour la prise en charge du concepteur - ne modifiez pas
        /// le contenu de cette méthode avec l'éditeur de code.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainFormView));
            this.browseButton = new System.Windows.Forms.Button();
            this.xlsPathTextBox = new System.Windows.Forms.TextBox();
            this.menuLabel = new System.Windows.Forms.Label();
            this.openXlsFileDialog = new System.Windows.Forms.OpenFileDialog();
            this.filterComboBox = new System.Windows.Forms.ComboBox();
            this.addFilterButton = new System.Windows.Forms.Button();
            this.filterStartButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // browseButton
            // 
            this.browseButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.browseButton.Location = new System.Drawing.Point(484, 62);
            this.browseButton.Name = "browseButton";
            this.browseButton.Size = new System.Drawing.Size(122, 32);
            this.browseButton.TabIndex = 0;
            this.browseButton.Text = "Ouvrir";
            this.browseButton.UseVisualStyleBackColor = true;
            this.browseButton.Click += new System.EventHandler(this.browseButton_Click);
            // 
            // xlsPathTextBox
            // 
            this.xlsPathTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.xlsPathTextBox.Location = new System.Drawing.Point(39, 66);
            this.xlsPathTextBox.Name = "xlsPathTextBox";
            this.xlsPathTextBox.ReadOnly = true;
            this.xlsPathTextBox.Size = new System.Drawing.Size(400, 24);
            this.xlsPathTextBox.TabIndex = 1;
            // 
            // menuLabel
            // 
            this.menuLabel.AutoSize = true;
            this.menuLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.menuLabel.Location = new System.Drawing.Point(145, 25);
            this.menuLabel.Name = "menuLabel";
            this.menuLabel.Size = new System.Drawing.Size(338, 18);
            this.menuLabel.TabIndex = 2;
            this.menuLabel.Text = "Veuillez choisir un fichier à filtrer (.xls/.xlsx ou .csv)";
            // 
            // filterComboBox
            // 
            this.filterComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.filterComboBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.filterComboBox.FormattingEnabled = true;
            this.filterComboBox.Location = new System.Drawing.Point(39, 139);
            this.filterComboBox.Name = "filterComboBox";
            this.filterComboBox.Size = new System.Drawing.Size(400, 26);
            this.filterComboBox.TabIndex = 6;
            // 
            // addFilterButton
            // 
            this.addFilterButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.addFilterButton.Location = new System.Drawing.Point(484, 135);
            this.addFilterButton.Name = "addFilterButton";
            this.addFilterButton.Size = new System.Drawing.Size(122, 32);
            this.addFilterButton.TabIndex = 7;
            this.addFilterButton.Text = "Ajouter Filtres";
            this.addFilterButton.UseVisualStyleBackColor = true;
            this.addFilterButton.Click += new System.EventHandler(this.addFilterButton_Click);
            // 
            // filterStartButton
            // 
            this.filterStartButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.filterStartButton.Location = new System.Drawing.Point(269, 200);
            this.filterStartButton.Name = "filterStartButton";
            this.filterStartButton.Size = new System.Drawing.Size(90, 69);
            this.filterStartButton.TabIndex = 8;
            this.filterStartButton.Text = "Filtrer";
            this.filterStartButton.UseVisualStyleBackColor = true;
            this.filterStartButton.Click += new System.EventHandler(this.filterStartButton_Click);
            // 
            // MainFormView
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(629, 292);
            this.Controls.Add(this.filterStartButton);
            this.Controls.Add(this.addFilterButton);
            this.Controls.Add(this.filterComboBox);
            this.Controls.Add(this.menuLabel);
            this.Controls.Add(this.xlsPathTextBox);
            this.Controls.Add(this.browseButton);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "MainFormView";
            this.Text = "ExcelFilter - Choix fichier";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button browseButton;
        private System.Windows.Forms.TextBox xlsPathTextBox;
        private System.Windows.Forms.Label menuLabel;
        private System.Windows.Forms.OpenFileDialog openXlsFileDialog;
        private System.Windows.Forms.ComboBox filterComboBox;
        private System.Windows.Forms.Button addFilterButton;
        private System.Windows.Forms.Button filterStartButton;
    }
}

