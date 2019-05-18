namespace CarServiceWCFClient
{
    partial class Form1
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
            this.clientFirstNameInput = new System.Windows.Forms.TextBox();
            this.clientLastNameInput = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.searchClientButton = new System.Windows.Forms.Button();
            this.clientsFoundListBox = new System.Windows.Forms.ListBox();
            this.addClientButton = new System.Windows.Forms.Button();
            this.modifyClientButton = new System.Windows.Forms.Button();
            this.deleteClientButton = new System.Windows.Forms.Button();
            this.clientAutosListBox = new System.Windows.Forms.ListBox();
            this.clientCarsLabel = new System.Windows.Forms.Label();
            this.addAutoToClientButton = new System.Windows.Forms.Button();
            this.modifyAutoButton = new System.Windows.Forms.Button();
            this.deleteAutoButton = new System.Windows.Forms.Button();
            this.getOrdersForAutoButton = new System.Windows.Forms.Button();
            this.ordersListBox = new System.Windows.Forms.ListBox();
            this.addOrderButton = new System.Windows.Forms.Button();
            this.modifyOrderButton = new System.Windows.Forms.Button();
            this.deleteOrderButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // clientFirstNameInput
            // 
            this.clientFirstNameInput.Location = new System.Drawing.Point(12, 25);
            this.clientFirstNameInput.Name = "clientFirstNameInput";
            this.clientFirstNameInput.Size = new System.Drawing.Size(157, 20);
            this.clientFirstNameInput.TabIndex = 0;
            this.clientFirstNameInput.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.clientFirstNameInput_KeyPress);
            // 
            // clientLastNameInput
            // 
            this.clientLastNameInput.Location = new System.Drawing.Point(12, 84);
            this.clientLastNameInput.Name = "clientLastNameInput";
            this.clientLastNameInput.Size = new System.Drawing.Size(157, 20);
            this.clientLastNameInput.TabIndex = 1;
            this.clientLastNameInput.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.clientLastNameInput_KeyPress);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 7);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(86, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "Client First Name";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(11, 68);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(87, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "Client Last Name";
            // 
            // searchClientButton
            // 
            this.searchClientButton.Location = new System.Drawing.Point(207, 7);
            this.searchClientButton.Name = "searchClientButton";
            this.searchClientButton.Size = new System.Drawing.Size(104, 38);
            this.searchClientButton.TabIndex = 4;
            this.searchClientButton.Text = "Search Client";
            this.searchClientButton.UseVisualStyleBackColor = true;
            this.searchClientButton.Click += new System.EventHandler(this.searchClientButton_Click);
            // 
            // clientsFoundListBox
            // 
            this.clientsFoundListBox.FormattingEnabled = true;
            this.clientsFoundListBox.Location = new System.Drawing.Point(348, 7);
            this.clientsFoundListBox.Name = "clientsFoundListBox";
            this.clientsFoundListBox.Size = new System.Drawing.Size(446, 95);
            this.clientsFoundListBox.TabIndex = 5;
            this.clientsFoundListBox.Visible = false;
            this.clientsFoundListBox.SelectedIndexChanged += new System.EventHandler(this.clientsFoundListBox_SelectedIndexChanged);
            // 
            // addClientButton
            // 
            this.addClientButton.Location = new System.Drawing.Point(207, 57);
            this.addClientButton.Name = "addClientButton";
            this.addClientButton.Size = new System.Drawing.Size(104, 34);
            this.addClientButton.TabIndex = 6;
            this.addClientButton.Text = "Add Client";
            this.addClientButton.UseVisualStyleBackColor = true;
            this.addClientButton.Click += new System.EventHandler(this.addClientButton_Click);
            // 
            // modifyClientButton
            // 
            this.modifyClientButton.Location = new System.Drawing.Point(348, 108);
            this.modifyClientButton.Name = "modifyClientButton";
            this.modifyClientButton.Size = new System.Drawing.Size(104, 34);
            this.modifyClientButton.TabIndex = 7;
            this.modifyClientButton.Text = "Modify Client";
            this.modifyClientButton.UseVisualStyleBackColor = true;
            this.modifyClientButton.Visible = false;
            this.modifyClientButton.Click += new System.EventHandler(this.modifyClientButton_Click);
            // 
            // deleteClientButton
            // 
            this.deleteClientButton.Location = new System.Drawing.Point(473, 108);
            this.deleteClientButton.Name = "deleteClientButton";
            this.deleteClientButton.Size = new System.Drawing.Size(104, 34);
            this.deleteClientButton.TabIndex = 8;
            this.deleteClientButton.Text = "Delete Client";
            this.deleteClientButton.UseVisualStyleBackColor = true;
            this.deleteClientButton.Visible = false;
            this.deleteClientButton.Click += new System.EventHandler(this.deleteClientButton_Click);
            // 
            // clientAutosListBox
            // 
            this.clientAutosListBox.FormattingEnabled = true;
            this.clientAutosListBox.Location = new System.Drawing.Point(12, 198);
            this.clientAutosListBox.Name = "clientAutosListBox";
            this.clientAutosListBox.Size = new System.Drawing.Size(195, 251);
            this.clientAutosListBox.TabIndex = 10;
            this.clientAutosListBox.Visible = false;
            this.clientAutosListBox.SelectedIndexChanged += new System.EventHandler(this.clientAutosListBox_SelectedIndexChanged);
            // 
            // clientCarsLabel
            // 
            this.clientCarsLabel.AutoSize = true;
            this.clientCarsLabel.Location = new System.Drawing.Point(12, 164);
            this.clientCarsLabel.Name = "clientCarsLabel";
            this.clientCarsLabel.Size = new System.Drawing.Size(57, 13);
            this.clientCarsLabel.TabIndex = 11;
            this.clientCarsLabel.Text = "Client Cars";
            this.clientCarsLabel.Visible = false;
            // 
            // addAutoToClientButton
            // 
            this.addAutoToClientButton.Location = new System.Drawing.Point(207, 108);
            this.addAutoToClientButton.Name = "addAutoToClientButton";
            this.addAutoToClientButton.Size = new System.Drawing.Size(104, 34);
            this.addAutoToClientButton.TabIndex = 12;
            this.addAutoToClientButton.Text = "Add Auto For Client";
            this.addAutoToClientButton.UseVisualStyleBackColor = true;
            this.addAutoToClientButton.Visible = false;
            this.addAutoToClientButton.Click += new System.EventHandler(this.addAutoToClientButton_Click);
            // 
            // modifyAutoButton
            // 
            this.modifyAutoButton.Location = new System.Drawing.Point(213, 198);
            this.modifyAutoButton.Name = "modifyAutoButton";
            this.modifyAutoButton.Size = new System.Drawing.Size(104, 34);
            this.modifyAutoButton.TabIndex = 13;
            this.modifyAutoButton.Text = "Modify Auto";
            this.modifyAutoButton.UseVisualStyleBackColor = true;
            this.modifyAutoButton.Visible = false;
            this.modifyAutoButton.Click += new System.EventHandler(this.modifyAutoButton_Click);
            // 
            // deleteAutoButton
            // 
            this.deleteAutoButton.Location = new System.Drawing.Point(213, 249);
            this.deleteAutoButton.Name = "deleteAutoButton";
            this.deleteAutoButton.Size = new System.Drawing.Size(104, 34);
            this.deleteAutoButton.TabIndex = 14;
            this.deleteAutoButton.Text = "Delete Auto";
            this.deleteAutoButton.UseVisualStyleBackColor = true;
            this.deleteAutoButton.Visible = false;
            this.deleteAutoButton.Click += new System.EventHandler(this.deleteAutoButton_Click);
            // 
            // getOrdersForAutoButton
            // 
            this.getOrdersForAutoButton.Location = new System.Drawing.Point(213, 303);
            this.getOrdersForAutoButton.Name = "getOrdersForAutoButton";
            this.getOrdersForAutoButton.Size = new System.Drawing.Size(104, 34);
            this.getOrdersForAutoButton.TabIndex = 15;
            this.getOrdersForAutoButton.Text = "Get Orders For Auto";
            this.getOrdersForAutoButton.UseVisualStyleBackColor = true;
            this.getOrdersForAutoButton.Visible = false;
            this.getOrdersForAutoButton.Click += new System.EventHandler(this.getOrdersForAutoButton_Click);
            // 
            // ordersListBox
            // 
            this.ordersListBox.FormattingEnabled = true;
            this.ordersListBox.Location = new System.Drawing.Point(413, 198);
            this.ordersListBox.Name = "ordersListBox";
            this.ordersListBox.Size = new System.Drawing.Size(204, 251);
            this.ordersListBox.TabIndex = 16;
            this.ordersListBox.Visible = false;
            this.ordersListBox.SelectedIndexChanged += new System.EventHandler(this.ordersListBox_SelectedIndexChanged);
            // 
            // addOrderButton
            // 
            this.addOrderButton.Location = new System.Drawing.Point(213, 368);
            this.addOrderButton.Name = "addOrderButton";
            this.addOrderButton.Size = new System.Drawing.Size(104, 34);
            this.addOrderButton.TabIndex = 17;
            this.addOrderButton.Text = "Add Order For Auto";
            this.addOrderButton.UseVisualStyleBackColor = true;
            this.addOrderButton.Visible = false;
            this.addOrderButton.Click += new System.EventHandler(this.addOrderButton_Click);
            // 
            // modifyOrderButton
            // 
            this.modifyOrderButton.Location = new System.Drawing.Point(623, 198);
            this.modifyOrderButton.Name = "modifyOrderButton";
            this.modifyOrderButton.Size = new System.Drawing.Size(104, 34);
            this.modifyOrderButton.TabIndex = 18;
            this.modifyOrderButton.Text = "Modify/View Order";
            this.modifyOrderButton.UseVisualStyleBackColor = true;
            this.modifyOrderButton.Visible = false;
            this.modifyOrderButton.Click += new System.EventHandler(this.modifyOrderButton_Click);
            // 
            // deleteOrderButton
            // 
            this.deleteOrderButton.Location = new System.Drawing.Point(623, 265);
            this.deleteOrderButton.Name = "deleteOrderButton";
            this.deleteOrderButton.Size = new System.Drawing.Size(104, 34);
            this.deleteOrderButton.TabIndex = 19;
            this.deleteOrderButton.Text = "Delete Order";
            this.deleteOrderButton.UseVisualStyleBackColor = true;
            this.deleteOrderButton.Visible = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(813, 450);
            this.Controls.Add(this.deleteOrderButton);
            this.Controls.Add(this.modifyOrderButton);
            this.Controls.Add(this.addOrderButton);
            this.Controls.Add(this.ordersListBox);
            this.Controls.Add(this.getOrdersForAutoButton);
            this.Controls.Add(this.deleteAutoButton);
            this.Controls.Add(this.modifyAutoButton);
            this.Controls.Add(this.addAutoToClientButton);
            this.Controls.Add(this.clientCarsLabel);
            this.Controls.Add(this.clientAutosListBox);
            this.Controls.Add(this.deleteClientButton);
            this.Controls.Add(this.modifyClientButton);
            this.Controls.Add(this.addClientButton);
            this.Controls.Add(this.clientsFoundListBox);
            this.Controls.Add(this.searchClientButton);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.clientLastNameInput);
            this.Controls.Add(this.clientFirstNameInput);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox clientFirstNameInput;
        private System.Windows.Forms.TextBox clientLastNameInput;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button searchClientButton;
        private System.Windows.Forms.ListBox clientsFoundListBox;
        private System.Windows.Forms.Button addClientButton;
        private System.Windows.Forms.Button modifyClientButton;
        private System.Windows.Forms.Button deleteClientButton;
        private System.Windows.Forms.ListBox clientAutosListBox;
        private System.Windows.Forms.Label clientCarsLabel;
        private System.Windows.Forms.Button addAutoToClientButton;
        private System.Windows.Forms.Button modifyAutoButton;
        private System.Windows.Forms.Button deleteAutoButton;
        private System.Windows.Forms.Button getOrdersForAutoButton;
        private System.Windows.Forms.ListBox ordersListBox;
        private System.Windows.Forms.Button addOrderButton;
        private System.Windows.Forms.Button modifyOrderButton;
        private System.Windows.Forms.Button deleteOrderButton;
    }
}

