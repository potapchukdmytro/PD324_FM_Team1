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
            button1 = new Button();
            SuspendLayout();
            // 
            // textBoxName
            // 
            textBoxName.Location = new Point(268, 121);
            textBoxName.Name = "textBoxName";
            textBoxName.Size = new Size(125, 27);
            textBoxName.TabIndex = 0;
            textBoxName.Text = "name";
            // 
            // textBoxCost
            // 
            textBoxCost.Location = new Point(268, 154);
            textBoxCost.Name = "textBoxCost";
            textBoxCost.Size = new Size(125, 27);
            textBoxCost.TabIndex = 1;
            textBoxCost.Text = "cost";
            // 
            // textBoxType
            // 
            textBoxType.Location = new Point(268, 198);
            textBoxType.Name = "textBoxType";
            textBoxType.Size = new Size(125, 27);
            textBoxType.TabIndex = 2;
            textBoxType.Text = "type";
            // 
            // textBoxCurrency
            // 
            textBoxCurrency.Location = new Point(268, 243);
            textBoxCurrency.Name = "textBoxCurrency";
            textBoxCurrency.Size = new Size(125, 27);
            textBoxCurrency.TabIndex = 3;
            textBoxCurrency.Text = "currency";
            // 
            // button1
            // 
            button1.Location = new Point(268, 293);
            button1.Name = "button1";
            button1.Size = new Size(94, 29);
            button1.TabIndex = 4;
            button1.Text = "button1";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // AddCost
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(button1);
            Controls.Add(textBoxCurrency);
            Controls.Add(textBoxType);
            Controls.Add(textBoxCost);
            Controls.Add(textBoxName);
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
        private Button button1;
    }
}