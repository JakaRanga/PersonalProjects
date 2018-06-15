namespace jPwdGen
{
    partial class ProfilView
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ProfilView));
            this.pwdGenButton = new System.Windows.Forms.Button();
            this.welcomeLabel = new System.Windows.Forms.Label();
            this.managePwdButton = new System.Windows.Forms.Button();
            this.dataAccessButton = new System.Windows.Forms.Button();
            this.paraAccButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // pwdGenButton
            // 
            this.pwdGenButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.pwdGenButton.Location = new System.Drawing.Point(162, 466);
            this.pwdGenButton.Name = "pwdGenButton";
            this.pwdGenButton.Size = new System.Drawing.Size(290, 78);
            this.pwdGenButton.TabIndex = 0;
            this.pwdGenButton.Text = "Générer un mot de passe";
            this.pwdGenButton.UseVisualStyleBackColor = true;
            this.pwdGenButton.Click += new System.EventHandler(this.pwdGenButton_Click);
            // 
            // welcomeLabel
            // 
            this.welcomeLabel.AutoSize = true;
            this.welcomeLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.welcomeLabel.Location = new System.Drawing.Point(277, 54);
            this.welcomeLabel.Name = "welcomeLabel";
            this.welcomeLabel.Size = new System.Drawing.Size(60, 24);
            this.welcomeLabel.TabIndex = 1;
            this.welcomeLabel.Text = "label1";
            // 
            // managePwdButton
            // 
            this.managePwdButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.managePwdButton.Location = new System.Drawing.Point(162, 358);
            this.managePwdButton.Name = "managePwdButton";
            this.managePwdButton.Size = new System.Drawing.Size(290, 78);
            this.managePwdButton.TabIndex = 2;
            this.managePwdButton.Text = "Gérer vos mots de passe";
            this.managePwdButton.UseVisualStyleBackColor = true;
            this.managePwdButton.Click += new System.EventHandler(this.managePwdButton_Click);
            // 
            // dataAccessButton
            // 
            this.dataAccessButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dataAccessButton.Location = new System.Drawing.Point(162, 142);
            this.dataAccessButton.Name = "dataAccessButton";
            this.dataAccessButton.Size = new System.Drawing.Size(290, 78);
            this.dataAccessButton.TabIndex = 3;
            this.dataAccessButton.Text = "Data Center (Super User only)\r\nNo available";
            this.dataAccessButton.UseVisualStyleBackColor = true;
            this.dataAccessButton.Click += new System.EventHandler(this.dataAccessButton_Click);
            // 
            // paraAccButton
            // 
            this.paraAccButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.paraAccButton.Location = new System.Drawing.Point(162, 250);
            this.paraAccButton.Name = "paraAccButton";
            this.paraAccButton.Size = new System.Drawing.Size(290, 78);
            this.paraAccButton.TabIndex = 4;
            this.paraAccButton.Text = "Paramètres";
            this.paraAccButton.UseVisualStyleBackColor = true;
            // 
            // ProfilView
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(614, 581);
            this.Controls.Add(this.paraAccButton);
            this.Controls.Add(this.dataAccessButton);
            this.Controls.Add(this.managePwdButton);
            this.Controls.Add(this.welcomeLabel);
            this.Controls.Add(this.pwdGenButton);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "ProfilView";
            this.Text = "jPwdGen - Profil";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button pwdGenButton;
        private System.Windows.Forms.Label welcomeLabel;
        private System.Windows.Forms.Button managePwdButton;
        private System.Windows.Forms.Button dataAccessButton;
        private System.Windows.Forms.Button paraAccButton;
    }
}