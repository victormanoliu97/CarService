namespace CarServiceGUI
{
    partial class ClientPopupForm
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
            this.firstNameInput = new System.Windows.Forms.TextBox();
            this.lastNameInput = new System.Windows.Forms.TextBox();
            this.adressInput = new System.Windows.Forms.TextBox();
            this.phoneInput = new System.Windows.Forms.TextBox();
            this.cityInput = new System.Windows.Forms.TextBox();
            this.stateInput = new System.Windows.Forms.TextBox();
            this.emailInput = new System.Windows.Forms.TextBox();
            this.saveButton = new System.Windows.Forms.Button();
            this.firstNameLabel = new System.Windows.Forms.Label();
            this.lastNameLabel = new System.Windows.Forms.Label();
            this.addressLabel = new System.Windows.Forms.Label();
            this.telephoneLabel = new System.Windows.Forms.Label();
            this.cityLabel = new System.Windows.Forms.Label();
            this.stateLabel = new System.Windows.Forms.Label();
            this.emailLabel = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // firstNameInput
            // 
            this.firstNameInput.Location = new System.Drawing.Point(38, 38);
            this.firstNameInput.Name = "firstNameInput";
            this.firstNameInput.Size = new System.Drawing.Size(119, 20);
            this.firstNameInput.TabIndex = 0;
            this.firstNameInput.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.firstNameInput_KeyPress);
            // 
            // lastNameInput
            // 
            this.lastNameInput.Location = new System.Drawing.Point(38, 90);
            this.lastNameInput.Name = "lastNameInput";
            this.lastNameInput.Size = new System.Drawing.Size(119, 20);
            this.lastNameInput.TabIndex = 1;
            this.lastNameInput.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.lastNameInput_KeyPress);
            // 
            // adressInput
            // 
            this.adressInput.Location = new System.Drawing.Point(201, 38);
            this.adressInput.Name = "adressInput";
            this.adressInput.Size = new System.Drawing.Size(119, 20);
            this.adressInput.TabIndex = 2;
            // 
            // phoneInput
            // 
            this.phoneInput.Location = new System.Drawing.Point(201, 90);
            this.phoneInput.Name = "phoneInput";
            this.phoneInput.Size = new System.Drawing.Size(119, 20);
            this.phoneInput.TabIndex = 3;
            this.phoneInput.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.phoneInput_KeyPress);
            // 
            // cityInput
            // 
            this.cityInput.Location = new System.Drawing.Point(362, 38);
            this.cityInput.Name = "cityInput";
            this.cityInput.Size = new System.Drawing.Size(119, 20);
            this.cityInput.TabIndex = 4;
            this.cityInput.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.cityInput_KeyPress);
            // 
            // stateInput
            // 
            this.stateInput.Location = new System.Drawing.Point(362, 90);
            this.stateInput.Name = "stateInput";
            this.stateInput.Size = new System.Drawing.Size(119, 20);
            this.stateInput.TabIndex = 5;
            this.stateInput.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.stateInput_KeyPress);
            // 
            // emailInput
            // 
            this.emailInput.Location = new System.Drawing.Point(530, 66);
            this.emailInput.Name = "emailInput";
            this.emailInput.Size = new System.Drawing.Size(224, 20);
            this.emailInput.TabIndex = 6;
            // 
            // saveButton
            // 
            this.saveButton.Location = new System.Drawing.Point(38, 158);
            this.saveButton.Name = "saveButton";
            this.saveButton.Size = new System.Drawing.Size(127, 30);
            this.saveButton.TabIndex = 7;
            this.saveButton.Text = "Save";
            this.saveButton.UseVisualStyleBackColor = true;
            this.saveButton.Click += new System.EventHandler(this.saveButton_Click);
            // 
            // firstNameLabel
            // 
            this.firstNameLabel.AutoSize = true;
            this.firstNameLabel.Location = new System.Drawing.Point(38, 19);
            this.firstNameLabel.Name = "firstNameLabel";
            this.firstNameLabel.Size = new System.Drawing.Size(57, 13);
            this.firstNameLabel.TabIndex = 8;
            this.firstNameLabel.Text = "First Name";
            // 
            // lastNameLabel
            // 
            this.lastNameLabel.AutoSize = true;
            this.lastNameLabel.Location = new System.Drawing.Point(38, 73);
            this.lastNameLabel.Name = "lastNameLabel";
            this.lastNameLabel.Size = new System.Drawing.Size(58, 13);
            this.lastNameLabel.TabIndex = 9;
            this.lastNameLabel.Text = "Last Name";
            // 
            // addressLabel
            // 
            this.addressLabel.AutoSize = true;
            this.addressLabel.Location = new System.Drawing.Point(207, 19);
            this.addressLabel.Name = "addressLabel";
            this.addressLabel.Size = new System.Drawing.Size(45, 13);
            this.addressLabel.TabIndex = 10;
            this.addressLabel.Text = "Address";
            // 
            // telephoneLabel
            // 
            this.telephoneLabel.AutoSize = true;
            this.telephoneLabel.Location = new System.Drawing.Point(207, 73);
            this.telephoneLabel.Name = "telephoneLabel";
            this.telephoneLabel.Size = new System.Drawing.Size(58, 13);
            this.telephoneLabel.TabIndex = 11;
            this.telephoneLabel.Text = "Telephone";
            // 
            // cityLabel
            // 
            this.cityLabel.AutoSize = true;
            this.cityLabel.Location = new System.Drawing.Point(372, 19);
            this.cityLabel.Name = "cityLabel";
            this.cityLabel.Size = new System.Drawing.Size(24, 13);
            this.cityLabel.TabIndex = 12;
            this.cityLabel.Text = "City";
            // 
            // stateLabel
            // 
            this.stateLabel.AutoSize = true;
            this.stateLabel.Location = new System.Drawing.Point(372, 73);
            this.stateLabel.Name = "stateLabel";
            this.stateLabel.Size = new System.Drawing.Size(32, 13);
            this.stateLabel.TabIndex = 13;
            this.stateLabel.Text = "State";
            // 
            // emailLabel
            // 
            this.emailLabel.AutoSize = true;
            this.emailLabel.Location = new System.Drawing.Point(536, 45);
            this.emailLabel.Name = "emailLabel";
            this.emailLabel.Size = new System.Drawing.Size(32, 13);
            this.emailLabel.TabIndex = 14;
            this.emailLabel.Text = "Email";
            // 
            // ClientPopupForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(806, 202);
            this.Controls.Add(this.emailLabel);
            this.Controls.Add(this.stateLabel);
            this.Controls.Add(this.cityLabel);
            this.Controls.Add(this.telephoneLabel);
            this.Controls.Add(this.addressLabel);
            this.Controls.Add(this.lastNameLabel);
            this.Controls.Add(this.firstNameLabel);
            this.Controls.Add(this.saveButton);
            this.Controls.Add(this.emailInput);
            this.Controls.Add(this.stateInput);
            this.Controls.Add(this.cityInput);
            this.Controls.Add(this.phoneInput);
            this.Controls.Add(this.adressInput);
            this.Controls.Add(this.lastNameInput);
            this.Controls.Add(this.firstNameInput);
            this.Name = "ClientPopupForm";
            this.Text = "ClientPopupForm";
            this.Load += new System.EventHandler(this.ClientPopupForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox firstNameInput;
        private System.Windows.Forms.TextBox lastNameInput;
        private System.Windows.Forms.TextBox adressInput;
        private System.Windows.Forms.TextBox phoneInput;
        private System.Windows.Forms.TextBox cityInput;
        private System.Windows.Forms.TextBox stateInput;
        private System.Windows.Forms.TextBox emailInput;
        private System.Windows.Forms.Button saveButton;
        private System.Windows.Forms.Label firstNameLabel;
        private System.Windows.Forms.Label lastNameLabel;
        private System.Windows.Forms.Label addressLabel;
        private System.Windows.Forms.Label telephoneLabel;
        private System.Windows.Forms.Label cityLabel;
        private System.Windows.Forms.Label stateLabel;
        private System.Windows.Forms.Label emailLabel;
    }
}