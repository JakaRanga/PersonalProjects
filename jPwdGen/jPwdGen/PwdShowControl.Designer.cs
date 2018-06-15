namespace jPwdGen
{
    partial class PwdShowControl
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

        #region Code généré par le Concepteur de composants

        /// <summary> 
        /// Méthode requise pour la prise en charge du concepteur - ne modifiez pas 
        /// le contenu de cette méthode avec l'éditeur de code.
        /// </summary>
        private void InitializeComponent()
        {
            this.softLabel = new System.Windows.Forms.Label();
            this.pwdLabel = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // softLabel
            // 
            this.softLabel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.softLabel.Location = new System.Drawing.Point(0, 0);
            this.softLabel.Name = "softLabel";
            this.softLabel.Size = new System.Drawing.Size(295, 50);
            this.softLabel.TabIndex = 0;
            this.softLabel.Text = "label1";
            this.softLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // pwdLabel
            // 
            this.pwdLabel.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.pwdLabel.Location = new System.Drawing.Point(295, 0);
            this.pwdLabel.Name = "pwdLabel";
            this.pwdLabel.Size = new System.Drawing.Size(295, 50);
            this.pwdLabel.TabIndex = 1;
            this.pwdLabel.Text = "label2";
            this.pwdLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // PwdShowControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.pwdLabel);
            this.Controls.Add(this.softLabel);
            this.Name = "PwdShowControl";
            this.Size = new System.Drawing.Size(590, 50);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label softLabel;
        private System.Windows.Forms.Label pwdLabel;
    }
}
