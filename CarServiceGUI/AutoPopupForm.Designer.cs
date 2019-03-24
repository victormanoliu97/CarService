namespace CarServiceGUI
{
    partial class AutoPopupForm
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
            this.registrationNumberTextBox = new System.Windows.Forms.TextBox();
            this.chassisSeriesTextBox = new System.Windows.Forms.TextBox();
            this.autoSaveButton = new System.Windows.Forms.Button();
            this.autoOwnersComboBox = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.chassisComboBox = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // registrationNumberTextBox
            // 
            this.registrationNumberTextBox.Location = new System.Drawing.Point(27, 33);
            this.registrationNumberTextBox.Name = "registrationNumberTextBox";
            this.registrationNumberTextBox.Size = new System.Drawing.Size(115, 20);
            this.registrationNumberTextBox.TabIndex = 0;
            this.registrationNumberTextBox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.registrationNumberTextBox_KeyPress);
            // 
            // chassisSeriesTextBox
            // 
            this.chassisSeriesTextBox.Location = new System.Drawing.Point(201, 33);
            this.chassisSeriesTextBox.Name = "chassisSeriesTextBox";
            this.chassisSeriesTextBox.Size = new System.Drawing.Size(168, 20);
            this.chassisSeriesTextBox.TabIndex = 0;
            this.chassisSeriesTextBox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.chassisSeriesTextBox_KeyPress);
            // 
            // autoSaveButton
            // 
            this.autoSaveButton.Location = new System.Drawing.Point(27, 147);
            this.autoSaveButton.Name = "autoSaveButton";
            this.autoSaveButton.Size = new System.Drawing.Size(134, 32);
            this.autoSaveButton.TabIndex = 2;
            this.autoSaveButton.Text = "Save";
            this.autoSaveButton.UseVisualStyleBackColor = true;
            this.autoSaveButton.Click += new System.EventHandler(this.autoSaveButton_Click);
            // 
            // autoOwnersComboBox
            // 
            this.autoOwnersComboBox.FormattingEnabled = true;
            this.autoOwnersComboBox.Location = new System.Drawing.Point(406, 33);
            this.autoOwnersComboBox.Name = "autoOwnersComboBox";
            this.autoOwnersComboBox.Size = new System.Drawing.Size(169, 21);
            this.autoOwnersComboBox.TabIndex = 3;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(27, 14);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(103, 13);
            this.label1.TabIndex = 4;
            this.label1.Text = "Registration Number";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(201, 13);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(75, 13);
            this.label2.TabIndex = 5;
            this.label2.Text = "Chassis Series";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(413, 13);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(38, 13);
            this.label3.TabIndex = 6;
            this.label3.Text = "Owner";
            // 
            // chassisComboBox
            // 
            this.chassisComboBox.FormattingEnabled = true;
            this.chassisComboBox.Location = new System.Drawing.Point(610, 32);
            this.chassisComboBox.Name = "chassisComboBox";
            this.chassisComboBox.Size = new System.Drawing.Size(166, 21);
            this.chassisComboBox.TabIndex = 7;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(607, 9);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(43, 13);
            this.label4.TabIndex = 8;
            this.label4.Text = "Chassis";
            // 
            // AutoPopupForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(788, 204);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.chassisComboBox);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.autoOwnersComboBox);
            this.Controls.Add(this.autoSaveButton);
            this.Controls.Add(this.chassisSeriesTextBox);
            this.Controls.Add(this.registrationNumberTextBox);
            this.Name = "AutoPopupForm";
            this.Text = "AutoPopupForm";
            this.Load += new System.EventHandler(this.AutoPopupForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox registrationNumberTextBox;
        private System.Windows.Forms.TextBox chassisSeriesTextBox;
        private System.Windows.Forms.Button autoSaveButton;
        private System.Windows.Forms.ComboBox autoOwnersComboBox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox chassisComboBox;
        private System.Windows.Forms.Label label4;
    }
}