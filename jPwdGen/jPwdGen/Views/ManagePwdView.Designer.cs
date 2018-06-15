namespace jPwdGen
{
    partial class ManagePwdView
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ManagePwdView));
            this.listView1 = new System.Windows.Forms.ListView();
            this.idPwdCol = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.softCol = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.pwdCol = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.selectedSoftTextBox = new System.Windows.Forms.TextBox();
            this.selectedPwdTextBox = new System.Windows.Forms.TextBox();
            this.abortButton = new System.Windows.Forms.Button();
            this.deletePwdButton = new System.Windows.Forms.Button();
            this.modifyButton = new System.Windows.Forms.Button();
            this.idPwdTextBox = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // listView1
            // 
            this.listView1.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.listView1.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.idPwdCol,
            this.softCol,
            this.pwdCol});
            this.listView1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.listView1.GridLines = true;
            this.listView1.Location = new System.Drawing.Point(10, 19);
            this.listView1.Margin = new System.Windows.Forms.Padding(0);
            this.listView1.Name = "listView1";
            this.listView1.Size = new System.Drawing.Size(600, 284);
            this.listView1.TabIndex = 3;
            this.listView1.UseCompatibleStateImageBehavior = false;
            this.listView1.View = System.Windows.Forms.View.Details;
            this.listView1.SelectedIndexChanged += new System.EventHandler(this.listView1_SelectedIndexChanged);
            // 
            // idPwdCol
            // 
            this.idPwdCol.Text = "N°";
            this.idPwdCol.Width = 100;
            // 
            // softCol
            // 
            this.softCol.Text = "Nom du logiciel / site Internet";
            this.softCol.Width = 250;
            // 
            // pwdCol
            // 
            this.pwdCol.Text = "Mot de passe associé";
            this.pwdCol.Width = 250;
            // 
            // selectedSoftTextBox
            // 
            this.selectedSoftTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.selectedSoftTextBox.Location = new System.Drawing.Point(130, 342);
            this.selectedSoftTextBox.Name = "selectedSoftTextBox";
            this.selectedSoftTextBox.Size = new System.Drawing.Size(222, 24);
            this.selectedSoftTextBox.TabIndex = 5;
            this.selectedSoftTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // selectedPwdTextBox
            // 
            this.selectedPwdTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.selectedPwdTextBox.Location = new System.Drawing.Point(374, 342);
            this.selectedPwdTextBox.Name = "selectedPwdTextBox";
            this.selectedPwdTextBox.Size = new System.Drawing.Size(222, 24);
            this.selectedPwdTextBox.TabIndex = 6;
            this.selectedPwdTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // abortButton
            // 
            this.abortButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.abortButton.Image = global::jPwdGen.Properties.Resources.porte_sortie_icone_9124_64;
            this.abortButton.Location = new System.Drawing.Point(486, 408);
            this.abortButton.Name = "abortButton";
            this.abortButton.Size = new System.Drawing.Size(109, 88);
            this.abortButton.TabIndex = 10;
            this.abortButton.Text = "Quitter";
            this.abortButton.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.abortButton.UseVisualStyleBackColor = true;
            this.abortButton.Click += new System.EventHandler(this.abortButton_Click);
            // 
            // deletePwdButton
            // 
            this.deletePwdButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.deletePwdButton.Image = global::jPwdGen.Properties.Resources.fermer_croix_supprimer_erreurs_sortie_icone_4368_64;
            this.deletePwdButton.Location = new System.Drawing.Point(255, 408);
            this.deletePwdButton.Name = "deletePwdButton";
            this.deletePwdButton.Size = new System.Drawing.Size(109, 88);
            this.deletePwdButton.TabIndex = 9;
            this.deletePwdButton.Text = "Supprimer";
            this.deletePwdButton.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.deletePwdButton.UseVisualStyleBackColor = true;
            this.deletePwdButton.Click += new System.EventHandler(this.deletePwdButton_Click);
            // 
            // modifyButton
            // 
            this.modifyButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.modifyButton.Image = global::jPwdGen.Properties.Resources.modifier_icone_7876_64;
            this.modifyButton.Location = new System.Drawing.Point(24, 408);
            this.modifyButton.Name = "modifyButton";
            this.modifyButton.Size = new System.Drawing.Size(109, 88);
            this.modifyButton.TabIndex = 8;
            this.modifyButton.Text = "Modifier";
            this.modifyButton.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.modifyButton.UseVisualStyleBackColor = true;
            this.modifyButton.Click += new System.EventHandler(this.modifyButton_Click);
            // 
            // idPwdTextBox
            // 
            this.idPwdTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.idPwdTextBox.Location = new System.Drawing.Point(24, 342);
            this.idPwdTextBox.Name = "idPwdTextBox";
            this.idPwdTextBox.ReadOnly = true;
            this.idPwdTextBox.Size = new System.Drawing.Size(80, 24);
            this.idPwdTextBox.TabIndex = 11;
            this.idPwdTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // ManagePwdView
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(619, 526);
            this.Controls.Add(this.idPwdTextBox);
            this.Controls.Add(this.abortButton);
            this.Controls.Add(this.deletePwdButton);
            this.Controls.Add(this.modifyButton);
            this.Controls.Add(this.selectedPwdTextBox);
            this.Controls.Add(this.selectedSoftTextBox);
            this.Controls.Add(this.listView1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "ManagePwdView";
            this.Text = "jPwdGen - Gestion";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.ListView listView1;
        private System.Windows.Forms.ColumnHeader softCol;
        private System.Windows.Forms.ColumnHeader pwdCol;
        private System.Windows.Forms.ColumnHeader idPwdCol;
        private System.Windows.Forms.TextBox selectedSoftTextBox;
        private System.Windows.Forms.TextBox selectedPwdTextBox;
        private System.Windows.Forms.Button modifyButton;
        private System.Windows.Forms.Button deletePwdButton;
        private System.Windows.Forms.Button abortButton;
        private System.Windows.Forms.TextBox idPwdTextBox;
    }
}