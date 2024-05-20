namespace FinancingManager.Forms
{
    partial class AddCost
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
            textBoxName = new TextBox();
            textBoxCost = new TextBox();
            textBoxType = new TextBox();
            textBoxCurrency = new TextBox();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            rejectButton = new Button();
            button1 = new Button();
            label5 = new Label();
            SuspendLayout();
            // 
            // textBoxName
            // 
            textBoxName.BackColor = SystemColors.ControlLight;
            textBoxName.BorderStyle = BorderStyle.FixedSingle;
            textBoxName.Cursor = Cursors.Hand;
            textBoxName.Location = new Point(71, 63);
            textBoxName.Margin = new Padding(3, 2, 3, 2);
            textBoxName.Name = "textBoxName";
            textBoxName.Size = new Size(190, 23);
            textBoxName.TabIndex = 0;
            // 
            // textBoxCost
            // 
            textBoxCost.BackColor = SystemColors.ControlLight;
            textBoxCost.BorderStyle = BorderStyle.FixedSingle;
            textBoxCost.Cursor = Cursors.Hand;
            textBoxCost.Location = new Point(71, 90);
            textBoxCost.Margin = new Padding(3, 2, 3, 2);
            textBoxCost.Name = "textBoxCost";
            textBoxCost.Size = new Size(190, 23);
            textBoxCost.TabIndex = 1;
            // 
            // textBoxType
            // 
            textBoxType.BackColor = SystemColors.ControlLight;
            textBoxType.BorderStyle = BorderStyle.FixedSingle;
            textBoxType.Cursor = Cursors.Hand;
            textBoxType.Location = new Point(71, 117);
            textBoxType.Margin = new Padding(3, 2, 3, 2);
            textBoxType.Name = "textBoxType";
            textBoxType.Size = new Size(190, 23);
            textBoxType.TabIndex = 2;
            // 
            // textBoxCurrency
            // 
            textBoxCurrency.BackColor = SystemColors.ControlLight;
            textBoxCurrency.BorderStyle = BorderStyle.FixedSingle;
            textBoxCurrency.Cursor = Cursors.Hand;
            textBoxCurrency.Location = new Point(71, 144);
            textBoxCurrency.Margin = new Padding(3, 2, 3, 2);
            textBoxCurrency.Name = "textBoxCurrency";
            textBoxCurrency.Size = new Size(190, 23);
            textBoxCurrency.TabIndex = 3;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            label1.Location = new Point(12, 63);
            label1.Name = "label1";
            label1.Size = new Size(40, 15);
            label1.TabIndex = 5;
            label1.Text = "Name";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            label2.Location = new Point(12, 90);
            label2.Name = "label2";
            label2.Size = new Size(31, 15);
            label2.TabIndex = 6;
            label2.Text = "Cost";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            label3.Location = new Point(12, 117);
            label3.Name = "label3";
            label3.Size = new Size(33, 15);
            label3.TabIndex = 7;
            label3.Text = "Type";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            label4.Location = new Point(12, 142);
            label4.Name = "label4";
            label4.Size = new Size(57, 15);
            label4.TabIndex = 8;
            label4.Text = "Currency";
            // 
            // rejectButton
            // 
            rejectButton.BackColor = Color.FromArgb(255, 128, 128);
            rejectButton.Cursor = Cursors.Hand;
            rejectButton.FlatStyle = FlatStyle.Popup;
            rejectButton.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            rejectButton.ForeColor = SystemColors.ControlLightLight;
            rejectButton.Location = new Point(12, 199);
            rejectButton.Name = "rejectButton";
            rejectButton.Size = new Size(75, 23);
            rejectButton.TabIndex = 9;
            rejectButton.Text = "Reject";
            rejectButton.UseVisualStyleBackColor = false;
            rejectButton.Click += rejectButton_Click;
            // 
            // button1
            // 
            button1.BackColor = Color.FromArgb(128, 255, 128);
            button1.Cursor = Cursors.Hand;
            button1.FlatStyle = FlatStyle.Popup;
            button1.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            button1.ForeColor = SystemColors.ButtonHighlight;
            button1.Location = new Point(179, 199);
            button1.Margin = new Padding(3, 2, 3, 2);
            button1.Name = "button1";
            button1.Size = new Size(82, 22);
            button1.TabIndex = 4;
            button1.Text = "Accept";
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI", 18F, FontStyle.Bold, GraphicsUnit.Point);
            label5.ForeColor = Color.FromArgb(0, 0, 64);
            label5.Location = new Point(58, 19);
            label5.Name = "label5";
            label5.Size = new Size(152, 32);
            label5.TabIndex = 10;
            label5.Text = "Adding cost";
            // 
            // AddCost
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.GradientActiveCaption;
            ClientSize = new Size(273, 232);
            Controls.Add(label5);
            Controls.Add(rejectButton);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(button1);
            Controls.Add(textBoxCurrency);
            Controls.Add(textBoxType);
            Controls.Add(textBoxCost);
            Controls.Add(textBoxName);
            Margin = new Padding(3, 2, 3, 2);
            Name = "AddCost";
            Text = "AddCost";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox textBoxName;
        private TextBox textBoxCost;
        private TextBox textBoxType;
        private TextBox textBoxCurrency;
        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private Button rejectButton;
        private Button button1;
        private Label label5;
    }
}