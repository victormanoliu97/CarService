namespace CarServiceGUI
{
    partial class OrderDetailsPopup
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
            this.saveOrderDetailsButton = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.totalPriceTextBox = new System.Windows.Forms.TextBox();
            this.descriptionTextBox = new System.Windows.Forms.TextBox();
            this.kmNumberTextBox = new System.Windows.Forms.TextBox();
            this.finalizationDatePicker = new System.Windows.Forms.DateTimePicker();
            this.appointmentDatePicker = new System.Windows.Forms.DateTimePicker();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.orderMechanicsListBox = new System.Windows.Forms.ListBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.addMechanicButton = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.orderOperationsCheckedList = new System.Windows.Forms.CheckedListBox();
            this.orderOperationsListBox = new System.Windows.Forms.ListBox();
            this.saveOperationChoice = new System.Windows.Forms.Button();
            this.markOrderFinished = new System.Windows.Forms.Button();
            this.markOrderImpossible = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // saveOrderDetailsButton
            // 
            this.saveOrderDetailsButton.Location = new System.Drawing.Point(12, 363);
            this.saveOrderDetailsButton.Name = "saveOrderDetailsButton";
            this.saveOrderDetailsButton.Size = new System.Drawing.Size(143, 45);
            this.saveOrderDetailsButton.TabIndex = 20;
            this.saveOrderDetailsButton.Text = "Save";
            this.saveOrderDetailsButton.UseVisualStyleBackColor = true;
            this.saveOrderDetailsButton.Click += new System.EventHandler(this.saveOrderDetailsButton_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(12, 92);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(60, 13);
            this.label5.TabIndex = 19;
            this.label5.Text = "Description";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(521, 18);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(88, 13);
            this.label4.TabIndex = 18;
            this.label4.Text = "Piece Total Price";
            // 
            // totalPriceTextBox
            // 
            this.totalPriceTextBox.Location = new System.Drawing.Point(524, 44);
            this.totalPriceTextBox.Name = "totalPriceTextBox";
            this.totalPriceTextBox.Size = new System.Drawing.Size(100, 20);
            this.totalPriceTextBox.TabIndex = 17;
            // 
            // descriptionTextBox
            // 
            this.descriptionTextBox.Location = new System.Drawing.Point(15, 108);
            this.descriptionTextBox.Multiline = true;
            this.descriptionTextBox.Name = "descriptionTextBox";
            this.descriptionTextBox.Size = new System.Drawing.Size(161, 41);
            this.descriptionTextBox.TabIndex = 16;
            // 
            // kmNumberTextBox
            // 
            this.kmNumberTextBox.Location = new System.Drawing.Point(666, 44);
            this.kmNumberTextBox.Name = "kmNumberTextBox";
            this.kmNumberTextBox.Size = new System.Drawing.Size(100, 20);
            this.kmNumberTextBox.TabIndex = 15;
            // 
            // finalizationDatePicker
            // 
            this.finalizationDatePicker.Location = new System.Drawing.Point(278, 44);
            this.finalizationDatePicker.Name = "finalizationDatePicker";
            this.finalizationDatePicker.Size = new System.Drawing.Size(200, 20);
            this.finalizationDatePicker.TabIndex = 14;
            // 
            // appointmentDatePicker
            // 
            this.appointmentDatePicker.Location = new System.Drawing.Point(12, 44);
            this.appointmentDatePicker.Name = "appointmentDatePicker";
            this.appointmentDatePicker.Size = new System.Drawing.Size(202, 20);
            this.appointmentDatePicker.TabIndex = 13;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(663, 18);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(62, 13);
            this.label3.TabIndex = 23;
            this.label3.Text = "Km Number";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(275, 18);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(85, 13);
            this.label2.TabIndex = 22;
            this.label2.Text = "Finalization Date";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 18);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(89, 13);
            this.label1.TabIndex = 21;
            this.label1.Text = "AppointmentDate";
            // 
            // orderMechanicsListBox
            // 
            this.orderMechanicsListBox.FormattingEnabled = true;
            this.orderMechanicsListBox.Location = new System.Drawing.Point(240, 108);
            this.orderMechanicsListBox.Name = "orderMechanicsListBox";
            this.orderMechanicsListBox.Size = new System.Drawing.Size(120, 95);
            this.orderMechanicsListBox.TabIndex = 24;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(240, 89);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(59, 13);
            this.label6.TabIndex = 25;
            this.label6.Text = "Mechanics";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(521, 89);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(58, 13);
            this.label7.TabIndex = 27;
            this.label7.Text = "Operations";
            // 
            // addMechanicButton
            // 
            this.addMechanicButton.Location = new System.Drawing.Point(375, 108);
            this.addMechanicButton.Name = "addMechanicButton";
            this.addMechanicButton.Size = new System.Drawing.Size(86, 23);
            this.addMechanicButton.TabIndex = 28;
            this.addMechanicButton.Text = "Add Mechanic";
            this.addMechanicButton.UseVisualStyleBackColor = true;
            this.addMechanicButton.Click += new System.EventHandler(this.addMechanicButton_Click);
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(375, 150);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(86, 35);
            this.button3.TabIndex = 29;
            this.button3.Text = "Delete Mechanic";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // button4
            // 
            this.button4.Location = new System.Drawing.Point(707, 106);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(100, 23);
            this.button4.TabIndex = 30;
            this.button4.Text = "Add Operation";
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // orderOperationsCheckedList
            // 
            this.orderOperationsCheckedList.FormattingEnabled = true;
            this.orderOperationsCheckedList.Location = new System.Drawing.Point(524, 217);
            this.orderOperationsCheckedList.Name = "orderOperationsCheckedList";
            this.orderOperationsCheckedList.Size = new System.Drawing.Size(177, 94);
            this.orderOperationsCheckedList.TabIndex = 31;
            this.orderOperationsCheckedList.Visible = false;
            // 
            // orderOperationsListBox
            // 
            this.orderOperationsListBox.FormattingEnabled = true;
            this.orderOperationsListBox.Location = new System.Drawing.Point(524, 105);
            this.orderOperationsListBox.Name = "orderOperationsListBox";
            this.orderOperationsListBox.Size = new System.Drawing.Size(177, 95);
            this.orderOperationsListBox.TabIndex = 32;
            // 
            // saveOperationChoice
            // 
            this.saveOperationChoice.Location = new System.Drawing.Point(707, 217);
            this.saveOperationChoice.Name = "saveOperationChoice";
            this.saveOperationChoice.Size = new System.Drawing.Size(99, 37);
            this.saveOperationChoice.TabIndex = 33;
            this.saveOperationChoice.Text = "Save operation choice";
            this.saveOperationChoice.UseVisualStyleBackColor = true;
            this.saveOperationChoice.Visible = false;
            this.saveOperationChoice.Click += new System.EventHandler(this.saveOperationChoice_Click);
            // 
            // markOrderFinished
            // 
            this.markOrderFinished.Location = new System.Drawing.Point(194, 363);
            this.markOrderFinished.Name = "markOrderFinished";
            this.markOrderFinished.Size = new System.Drawing.Size(143, 45);
            this.markOrderFinished.TabIndex = 34;
            this.markOrderFinished.Text = "Mark finished";
            this.markOrderFinished.UseVisualStyleBackColor = true;
            this.markOrderFinished.Click += new System.EventHandler(this.markOrderFinished_Click);
            // 
            // markOrderImpossible
            // 
            this.markOrderImpossible.Location = new System.Drawing.Point(375, 363);
            this.markOrderImpossible.Name = "markOrderImpossible";
            this.markOrderImpossible.Size = new System.Drawing.Size(143, 45);
            this.markOrderImpossible.TabIndex = 35;
            this.markOrderImpossible.Text = "Imposible due to tehnical issues";
            this.markOrderImpossible.UseVisualStyleBackColor = true;
            this.markOrderImpossible.Click += new System.EventHandler(this.markOrderImpossible_Click);
            // 
            // OrderDetailsPopup
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(867, 420);
            this.Controls.Add(this.markOrderImpossible);
            this.Controls.Add(this.markOrderFinished);
            this.Controls.Add(this.saveOperationChoice);
            this.Controls.Add(this.orderOperationsListBox);
            this.Controls.Add(this.orderOperationsCheckedList);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.addMechanicButton);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.orderMechanicsListBox);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.saveOrderDetailsButton);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.totalPriceTextBox);
            this.Controls.Add(this.descriptionTextBox);
            this.Controls.Add(this.kmNumberTextBox);
            this.Controls.Add(this.finalizationDatePicker);
            this.Controls.Add(this.appointmentDatePicker);
            this.Name = "OrderDetailsPopup";
            this.Text = "OrderDetailsPopup";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button saveOrderDetailsButton;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox totalPriceTextBox;
        private System.Windows.Forms.TextBox descriptionTextBox;
        private System.Windows.Forms.TextBox kmNumberTextBox;
        private System.Windows.Forms.DateTimePicker finalizationDatePicker;
        private System.Windows.Forms.DateTimePicker appointmentDatePicker;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ListBox orderMechanicsListBox;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Button addMechanicButton;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.CheckedListBox orderOperationsCheckedList;
        private System.Windows.Forms.ListBox orderOperationsListBox;
        private System.Windows.Forms.Button saveOperationChoice;
        private System.Windows.Forms.Button markOrderFinished;
        private System.Windows.Forms.Button markOrderImpossible;
    }
}