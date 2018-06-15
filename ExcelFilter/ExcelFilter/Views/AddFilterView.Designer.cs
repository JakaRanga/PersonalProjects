namespace ExcelFilter
{
    partial class AddFilterView
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AddFilterView));
            this.okButton = new System.Windows.Forms.Button();
            this.abortButton = new System.Windows.Forms.Button();
            this.newFComboBox = new System.Windows.Forms.ComboBox();
            this.deleteButton = new System.Windows.Forms.Button();
            this.addFilter = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // okButton
            // 
            this.okButton.Location = new System.Drawing.Point(438, 12);
            this.okButton.Name = "okButton";
            this.okButton.Size = new System.Drawing.Size(75, 23);
            this.okButton.TabIndex = 0;
            this.okButton.Text = "OK";
            this.okButton.UseVisualStyleBackColor = true;
            this.okButton.Click += new System.EventHandler(this.okButton_Click);
            // 
            // abortButton
            // 
            this.abortButton.Location = new System.Drawing.Point(438, 73);
            this.abortButton.Name = "abortButton";
            this.abortButton.Size = new System.Drawing.Size(75, 23);
            this.abortButton.TabIndex = 1;
            this.abortButton.Text = "Annuler";
            this.abortButton.UseVisualStyleBackColor = true;
            this.abortButton.Click += new System.EventHandler(this.abortButton_Click);
            // 
            // newFComboBox
            // 
            this.newFComboBox.FormattingEnabled = true;
            this.newFComboBox.Location = new System.Drawing.Point(29, 49);
            this.newFComboBox.Name = "newFComboBox";
            this.newFComboBox.Size = new System.Drawing.Size(359, 21);
            this.newFComboBox.TabIndex = 2;
            // 
            // deleteButton
            // 
            this.deleteButton.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.deleteButton.Image = global::ExcelFilter.Properties.Resources.suppButton;
            this.deleteButton.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.deleteButton.Location = new System.Drawing.Point(246, 112);
            this.deleteButton.Name = "deleteButton";
            this.deleteButton.Size = new System.Drawing.Size(75, 75);
            this.deleteButton.TabIndex = 3;
            this.deleteButton.Text = "Supprimer";
            this.deleteButton.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.deleteButton.UseVisualStyleBackColor = false;
            this.deleteButton.Click += new System.EventHandler(this.deleteButton_Click);
            // 
            // addFilter
            // 
            this.addFilter.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.addFilter.Image = global::ExcelFilter.Properties.Resources.sign_add_icon;
            this.addFilter.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.addFilter.Location = new System.Drawing.Point(95, 110);
            this.addFilter.Name = "addFilter";
            this.addFilter.Size = new System.Drawing.Size(75, 75);
            this.addFilter.TabIndex = 5;
            this.addFilter.Text = "Ajouter";
            this.addFilter.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.addFilter.UseVisualStyleBackColor = false;
            this.addFilter.Click += new System.EventHandler(this.addFilter_Click);
            // 
            // AddFilterView
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(525, 199);
            this.Controls.Add(this.addFilter);
            this.Controls.Add(this.deleteButton);
            this.Controls.Add(this.newFComboBox);
            this.Controls.Add(this.abortButton);
            this.Controls.Add(this.okButton);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "AddFilterView";
            this.Text = "ExcelFilter - Ajout Filtres";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button okButton;
        private System.Windows.Forms.Button abortButton;
        private System.Windows.Forms.ComboBox newFComboBox;
        private System.Windows.Forms.Button deleteButton;
        private System.Windows.Forms.Button addFilter;
    }
}