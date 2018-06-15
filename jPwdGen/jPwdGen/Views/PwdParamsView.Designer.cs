namespace jPwdGen
{
    partial class PwdParamsView
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(PwdParamsView));
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.lenghtTextBox = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.majCheckBox = new System.Windows.Forms.CheckBox();
            this.minCheckBox = new System.Windows.Forms.CheckBox();
            this.specCheckBox = new System.Windows.Forms.CheckBox();
            this.acceptButton = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.softTextBox = new System.Windows.Forms.TextBox();
            this.nbCheckBox = new System.Windows.Forms.CheckBox();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(60, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(259, 40);
            this.label1.TabIndex = 1;
            this.label1.Text = "Choisir vos paramètres\r\npour la génération du mot de passe";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.ForeColor = System.Drawing.Color.Red;
            this.label2.Location = new System.Drawing.Point(12, 426);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(222, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Les paramètres par défaut sont recommandés";
            // 
            // lenghtTextBox
            // 
            this.lenghtTextBox.Location = new System.Drawing.Point(116, 160);
            this.lenghtTextBox.Name = "lenghtTextBox";
            this.lenghtTextBox.Size = new System.Drawing.Size(49, 20);
            this.lenghtTextBox.TabIndex = 3;
            this.lenghtTextBox.Text = "8";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(43, 163);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(49, 13);
            this.label3.TabIndex = 4;
            this.label3.Text = " Longeur";
            // 
            // majCheckBox
            // 
            this.majCheckBox.AutoSize = true;
            this.majCheckBox.CheckAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.majCheckBox.Checked = true;
            this.majCheckBox.CheckState = System.Windows.Forms.CheckState.Checked;
            this.majCheckBox.Location = new System.Drawing.Point(46, 207);
            this.majCheckBox.Name = "majCheckBox";
            this.majCheckBox.Size = new System.Drawing.Size(85, 17);
            this.majCheckBox.TabIndex = 5;
            this.majCheckBox.Text = "Majuscules  ";
            this.majCheckBox.UseVisualStyleBackColor = true;
            // 
            // minCheckBox
            // 
            this.minCheckBox.AutoSize = true;
            this.minCheckBox.CheckAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.minCheckBox.Checked = true;
            this.minCheckBox.CheckState = System.Windows.Forms.CheckState.Checked;
            this.minCheckBox.Location = new System.Drawing.Point(46, 255);
            this.minCheckBox.Name = "minCheckBox";
            this.minCheckBox.Size = new System.Drawing.Size(85, 17);
            this.minCheckBox.TabIndex = 6;
            this.minCheckBox.Text = "Minuscules  ";
            this.minCheckBox.UseVisualStyleBackColor = true;
            // 
            // specCheckBox
            // 
            this.specCheckBox.AutoSize = true;
            this.specCheckBox.CheckAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.specCheckBox.Checked = true;
            this.specCheckBox.CheckState = System.Windows.Forms.CheckState.Checked;
            this.specCheckBox.Location = new System.Drawing.Point(46, 351);
            this.specCheckBox.Name = "specCheckBox";
            this.specCheckBox.Size = new System.Drawing.Size(86, 30);
            this.specCheckBox.TabIndex = 7;
            this.specCheckBox.Text = "Caractères\r\nspéciaux      ";
            this.specCheckBox.UseVisualStyleBackColor = true;
            // 
            // acceptButton
            // 
            this.acceptButton.Location = new System.Drawing.Point(271, 418);
            this.acceptButton.Name = "acceptButton";
            this.acceptButton.Size = new System.Drawing.Size(80, 28);
            this.acceptButton.TabIndex = 8;
            this.acceptButton.Text = "Accepter";
            this.acceptButton.UseVisualStyleBackColor = true;
            this.acceptButton.Click += new System.EventHandler(this.acceptButton_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(43, 93);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(46, 39);
            this.label4.TabIndex = 9;
            this.label4.Text = " Site ou \r\n logiciel\r\n associé";
            // 
            // softTextBox
            // 
            this.softTextBox.ForeColor = System.Drawing.SystemColors.WindowFrame;
            this.softTextBox.Location = new System.Drawing.Point(116, 105);
            this.softTextBox.Name = "softTextBox";
            this.softTextBox.Size = new System.Drawing.Size(166, 20);
            this.softTextBox.TabIndex = 10;
            this.softTextBox.Text = "ex : YouTube";
            this.softTextBox.Click += new System.EventHandler(this.softTextBox_Click);
            // 
            // nbCheckBox
            // 
            this.nbCheckBox.AutoSize = true;
            this.nbCheckBox.CheckAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.nbCheckBox.Checked = true;
            this.nbCheckBox.CheckState = System.Windows.Forms.CheckState.Checked;
            this.nbCheckBox.Location = new System.Drawing.Point(46, 303);
            this.nbCheckBox.Name = "nbCheckBox";
            this.nbCheckBox.Size = new System.Drawing.Size(85, 17);
            this.nbCheckBox.TabIndex = 11;
            this.nbCheckBox.Text = "Chiffres        ";
            this.nbCheckBox.UseVisualStyleBackColor = true;
            // 
            // PwdParamsView
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(373, 469);
            this.Controls.Add(this.nbCheckBox);
            this.Controls.Add(this.softTextBox);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.acceptButton);
            this.Controls.Add(this.specCheckBox);
            this.Controls.Add(this.minCheckBox);
            this.Controls.Add(this.majCheckBox);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.lenghtTextBox);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "PwdParamsView";
            this.Text = "jPwdGen - Paramètres";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox lenghtTextBox;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.CheckBox majCheckBox;
        private System.Windows.Forms.CheckBox minCheckBox;
        private System.Windows.Forms.CheckBox specCheckBox;
        private System.Windows.Forms.Button acceptButton;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox softTextBox;
        private System.Windows.Forms.CheckBox nbCheckBox;
    }
}