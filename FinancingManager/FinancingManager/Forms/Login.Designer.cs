namespace FinancingManager.Forms
{
    partial class Login
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
            label2 = new Label();
            passwordLabel = new Label();
            passwordTextBox = new TextBox();
            nicknameLabel = new Label();
            nicknameTextBox = new TextBox();
            acceptButton = new Button();
            rejectButton = new Button();
            SuspendLayout();
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 18F, FontStyle.Bold, GraphicsUnit.Point);
            label2.ForeColor = Color.FromArgb(0, 0, 64);
            label2.Location = new Point(121, 19);
            label2.Name = "label2";
            label2.Size = new Size(106, 41);
            label2.TabIndex = 8;
            label2.Text = "Log In";
            // 
            // passwordLabel
            // 
            passwordLabel.AutoSize = true;
            passwordLabel.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            passwordLabel.ForeColor = Color.FromArgb(0, 0, 64);
            passwordLabel.Location = new Point(12, 106);
            passwordLabel.Name = "passwordLabel";
            passwordLabel.Size = new Size(76, 20);
            passwordLabel.TabIndex = 13;
            passwordLabel.Text = "Password";
            // 
            // passwordTextBox
            // 
            passwordTextBox.BackColor = SystemColors.ControlLight;
            passwordTextBox.BorderStyle = BorderStyle.FixedSingle;
            passwordTextBox.Cursor = Cursors.Hand;
            passwordTextBox.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            passwordTextBox.ForeColor = Color.FromArgb(0, 0, 64);
            passwordTextBox.Location = new Point(137, 106);
            passwordTextBox.Margin = new Padding(7, 4, 7, 4);
            passwordTextBox.Name = "passwordTextBox";
            passwordTextBox.PasswordChar = '*';
            passwordTextBox.Size = new Size(213, 27);
            passwordTextBox.TabIndex = 12;
            passwordTextBox.Tag = "";
            // 
            // nicknameLabel
            // 
            nicknameLabel.AutoSize = true;
            nicknameLabel.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            nicknameLabel.ForeColor = Color.FromArgb(0, 0, 64);
            nicknameLabel.Location = new Point(12, 71);
            nicknameLabel.Name = "nicknameLabel";
            nicknameLabel.Size = new Size(79, 20);
            nicknameLabel.TabIndex = 11;
            nicknameLabel.Text = "Nickname";
            // 
            // nicknameTextBox
            // 
            nicknameTextBox.BackColor = SystemColors.ControlLight;
            nicknameTextBox.BorderStyle = BorderStyle.FixedSingle;
            nicknameTextBox.Cursor = Cursors.Hand;
            nicknameTextBox.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            nicknameTextBox.ForeColor = Color.FromArgb(0, 0, 64);
            nicknameTextBox.Location = new Point(137, 71);
            nicknameTextBox.Margin = new Padding(7, 4, 7, 4);
            nicknameTextBox.Name = "nicknameTextBox";
            nicknameTextBox.Size = new Size(213, 27);
            nicknameTextBox.TabIndex = 10;
            nicknameTextBox.Tag = "";
            // 
            // acceptButton
            // 
            acceptButton.BackColor = Color.FromArgb(128, 255, 128);
            acceptButton.Cursor = Cursors.Hand;
            acceptButton.FlatStyle = FlatStyle.Popup;
            acceptButton.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            acceptButton.ForeColor = SystemColors.ButtonHighlight;
            acceptButton.Location = new Point(264, 176);
            acceptButton.Margin = new Padding(3, 4, 3, 4);
            acceptButton.Name = "acceptButton";
            acceptButton.Size = new Size(86, 31);
            acceptButton.TabIndex = 15;
            acceptButton.Text = "Accept";
            acceptButton.UseVisualStyleBackColor = false;
            acceptButton.Click += acceptButton_Click;
            // 
            // rejectButton
            // 
            rejectButton.BackColor = Color.FromArgb(255, 128, 128);
            rejectButton.Cursor = Cursors.Hand;
            rejectButton.FlatStyle = FlatStyle.Popup;
            rejectButton.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            rejectButton.ForeColor = SystemColors.ControlLightLight;
            rejectButton.Location = new Point(12, 176);
            rejectButton.Margin = new Padding(3, 4, 3, 4);
            rejectButton.Name = "rejectButton";
            rejectButton.Size = new Size(86, 31);
            rejectButton.TabIndex = 14;
            rejectButton.Text = "Reject";
            rejectButton.UseVisualStyleBackColor = false;
            rejectButton.Click += rejectButton_Click;
            // 
            // Login
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.GradientActiveCaption;
            ClientSize = new Size(366, 221);
            Controls.Add(acceptButton);
            Controls.Add(rejectButton);
            Controls.Add(passwordLabel);
            Controls.Add(passwordTextBox);
            Controls.Add(nicknameLabel);
            Controls.Add(nicknameTextBox);
            Controls.Add(label2);
            Name = "Login";
            Text = "Login";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label2;
        private Label passwordLabel;
        private TextBox passwordTextBox;
        private Label nicknameLabel;
        private TextBox nicknameTextBox;
        private Button acceptButton;
        private Button rejectButton;
    }
}