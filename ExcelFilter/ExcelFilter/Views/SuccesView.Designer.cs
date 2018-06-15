namespace ExcelFilter
{
    partial class SuccesView
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(SuccesView));
            this.label1 = new System.Windows.Forms.Label();
            this.pathLabel = new System.Windows.Forms.Label();
            this.openDirButton = new System.Windows.Forms.Button();
            this.closeButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(96, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(351, 36);
            this.label1.TabIndex = 0;
            this.label1.Text = "Le filtrage Excel a été effectué avec succès\r\nRetrouvez les fichiers filtrés dans" +
    " le dossier suivant :";
            this.label1.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            // 
            // pathLabel
            // 
            this.pathLabel.AutoSize = true;
            this.pathLabel.Location = new System.Drawing.Point(246, 55);
            this.pathLabel.Name = "pathLabel";
            this.pathLabel.Size = new System.Drawing.Size(51, 13);
            this.pathLabel.TabIndex = 1;
            this.pathLabel.Text = "labelPath";
            this.pathLabel.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            // 
            // openDirButton
            // 
            this.openDirButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.openDirButton.Location = new System.Drawing.Point(69, 102);
            this.openDirButton.Name = "openDirButton";
            this.openDirButton.Size = new System.Drawing.Size(150, 32);
            this.openDirButton.TabIndex = 2;
            this.openDirButton.Text = "Ouvrir";
            this.openDirButton.UseVisualStyleBackColor = true;
            this.openDirButton.Click += new System.EventHandler(this.openDirButton_Click);
            // 
            // closeButton
            // 
            this.closeButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.closeButton.Location = new System.Drawing.Point(324, 102);
            this.closeButton.Name = "closeButton";
            this.closeButton.Size = new System.Drawing.Size(150, 32);
            this.closeButton.TabIndex = 3;
            this.closeButton.Text = "Fermer";
            this.closeButton.UseVisualStyleBackColor = true;
            this.closeButton.Click += new System.EventHandler(this.closeButton_Click);
            // 
            // SuccesView
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(543, 167);
            this.Controls.Add(this.closeButton);
            this.Controls.Add(this.openDirButton);
            this.Controls.Add(this.pathLabel);
            this.Controls.Add(this.label1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "SuccesView";
            this.Text = "Excel Filter - Succès";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label pathLabel;
        private System.Windows.Forms.Button openDirButton;
        private System.Windows.Forms.Button closeButton;
    }
}