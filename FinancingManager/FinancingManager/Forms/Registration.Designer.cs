namespace FinancingManager.Forms
{
    partial class Registration
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
            rejectButton = new Button();
            firstNameTextBox = new TextBox();
            firstNameLabel = new Label();
            lastNameLabel = new Label();
            lastNameTextBox = new TextBox();
            nicknameTextBox = new TextBox();
            nicknameLabel = new Label();
            label2 = new Label();
            passwordTextBox = new TextBox();
            passwordLabel = new Label();
            mailTextBox = new TextBox();
            mailLabel = new Label();
            acceptButton = new Button();
            confirmPasswordLabel = new Label();
            confirmPasswordTextBox = new TextBox();
            SuspendLayout();
            // 
            // rejectButton
            // 
            rejectButton.BackColor = Color.FromArgb(255, 128, 128);
            rejectButton.Cursor = Cursors.Hand;
            rejectButton.FlatStyle = FlatStyle.Popup;
            rejectButton.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            rejectButton.ForeColor = SystemColors.ControlLightLight;
            rejectButton.Location = new Point(12, 254);
            rejectButton.Name = "rejectButton";
            rejectButton.Size = new Size(75, 23);
            rejectButton.TabIndex = 0;
            rejectButton.Text = "Reject";
            rejectButton.UseVisualStyleBackColor = false;
            rejectButton.Click += rejectButton_Click;
            // 
            // firstNameTextBox
            // 
            firstNameTextBox.BackColor = SystemColors.ControlLight;
            firstNameTextBox.BorderStyle = BorderStyle.FixedSingle;
            firstNameTextBox.Cursor = Cursors.Hand;
            firstNameTextBox.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            firstNameTextBox.ForeColor = Color.FromArgb(0, 0, 64);
            firstNameTextBox.Location = new Point(121, 61);
            firstNameTextBox.Margin = new Padding(6, 3, 6, 3);
            firstNameTextBox.Name = "firstNameTextBox";
            firstNameTextBox.Size = new Size(187, 23);
            firstNameTextBox.TabIndex = 1;
            firstNameTextBox.Tag = "";
            // 
            // firstNameLabel
            // 
            firstNameLabel.AutoSize = true;
            firstNameLabel.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            firstNameLabel.ForeColor = Color.FromArgb(0, 0, 64);
            firstNameLabel.Location = new Point(11, 64);
            firstNameLabel.Name = "firstNameLabel";
            firstNameLabel.Size = new Size(67, 15);
            firstNameLabel.TabIndex = 2;
            firstNameLabel.Text = "First Name";
            // 
            // lastNameLabel
            // 
            lastNameLabel.AutoSize = true;
            lastNameLabel.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            lastNameLabel.ForeColor = Color.FromArgb(0, 0, 64);
            lastNameLabel.Location = new Point(12, 90);
            lastNameLabel.Name = "lastNameLabel";
            lastNameLabel.Size = new Size(65, 15);
            lastNameLabel.TabIndex = 3;
            lastNameLabel.Text = "Last Name";
            // 
            // lastNameTextBox
            // 
            lastNameTextBox.BackColor = SystemColors.ControlLight;
            lastNameTextBox.BorderStyle = BorderStyle.FixedSingle;
            lastNameTextBox.Cursor = Cursors.Hand;
            lastNameTextBox.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            lastNameTextBox.ForeColor = Color.FromArgb(0, 0, 64);
            lastNameTextBox.Location = new Point(121, 90);
            lastNameTextBox.Margin = new Padding(6, 3, 6, 3);
            lastNameTextBox.Name = "lastNameTextBox";
            lastNameTextBox.Size = new Size(187, 23);
            lastNameTextBox.TabIndex = 4;
            lastNameTextBox.Tag = "";
            // 
            // nicknameTextBox
            // 
            nicknameTextBox.BackColor = SystemColors.ControlLight;
            nicknameTextBox.BorderStyle = BorderStyle.FixedSingle;
            nicknameTextBox.Cursor = Cursors.Hand;
            nicknameTextBox.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            nicknameTextBox.ForeColor = Color.FromArgb(0, 0, 64);
            nicknameTextBox.Location = new Point(121, 119);
            nicknameTextBox.Margin = new Padding(6, 3, 6, 3);
            nicknameTextBox.Name = "nicknameTextBox";
            nicknameTextBox.Size = new Size(187, 23);
            nicknameTextBox.TabIndex = 5;
            nicknameTextBox.Tag = "";
            // 
            // nicknameLabel
            // 
            nicknameLabel.AutoSize = true;
            nicknameLabel.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            nicknameLabel.ForeColor = Color.FromArgb(0, 0, 64);
            nicknameLabel.Location = new Point(11, 119);
            nicknameLabel.Name = "nicknameLabel";
            nicknameLabel.Size = new Size(63, 15);
            nicknameLabel.TabIndex = 6;
            nicknameLabel.Text = "Nickname";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 18F, FontStyle.Bold, GraphicsUnit.Point);
            label2.ForeColor = Color.FromArgb(0, 0, 64);
            label2.Location = new Point(79, 15);
            label2.Name = "label2";
            label2.Size = new Size(153, 32);
            label2.TabIndex = 7;
            label2.Text = "Registration";
            // 
            // passwordTextBox
            // 
            passwordTextBox.BackColor = SystemColors.ControlLight;
            passwordTextBox.BorderStyle = BorderStyle.FixedSingle;
            passwordTextBox.Cursor = Cursors.Hand;
            passwordTextBox.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            passwordTextBox.ForeColor = Color.FromArgb(0, 0, 64);
            passwordTextBox.Location = new Point(121, 177);
            passwordTextBox.Margin = new Padding(6, 3, 6, 3);
            passwordTextBox.Name = "passwordTextBox";
            passwordTextBox.PasswordChar = '*';
            passwordTextBox.Size = new Size(187, 23);
            passwordTextBox.TabIndex = 8;
            passwordTextBox.Tag = "";
            // 
            // passwordLabel
            // 
            passwordLabel.AutoSize = true;
            passwordLabel.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            passwordLabel.ForeColor = Color.FromArgb(0, 0, 64);
            passwordLabel.Location = new Point(11, 177);
            passwordLabel.Name = "passwordLabel";
            passwordLabel.Size = new Size(59, 15);
            passwordLabel.TabIndex = 9;
            passwordLabel.Text = "Password";
            // 
            // mailTextBox
            // 
            mailTextBox.BackColor = SystemColors.ControlLight;
            mailTextBox.BorderStyle = BorderStyle.FixedSingle;
            mailTextBox.Cursor = Cursors.Hand;
            mailTextBox.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            mailTextBox.ForeColor = Color.FromArgb(0, 0, 64);
            mailTextBox.Location = new Point(121, 148);
            mailTextBox.Margin = new Padding(6, 3, 6, 3);
            mailTextBox.Name = "mailTextBox";
            mailTextBox.Size = new Size(187, 23);
            mailTextBox.TabIndex = 10;
            mailTextBox.Tag = "";
            // 
            // mailLabel
            // 
            mailLabel.AutoSize = true;
            mailLabel.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            mailLabel.ForeColor = Color.FromArgb(0, 0, 64);
            mailLabel.Location = new Point(11, 148);
            mailLabel.Name = "mailLabel";
            mailLabel.Size = new Size(41, 15);
            mailLabel.TabIndex = 11;
            mailLabel.Text = "E-Mail";
            // 
            // acceptButton
            // 
            acceptButton.BackColor = Color.FromArgb(128, 255, 128);
            acceptButton.Cursor = Cursors.Hand;
            acceptButton.FlatStyle = FlatStyle.Popup;
            acceptButton.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            acceptButton.ForeColor = SystemColors.ButtonHighlight;
            acceptButton.Location = new Point(233, 254);
            acceptButton.Name = "acceptButton";
            acceptButton.Size = new Size(75, 23);
            acceptButton.TabIndex = 12;
            acceptButton.Text = "Accept";
            acceptButton.UseVisualStyleBackColor = false;
            acceptButton.Click += this.acceptButton_Click;
            // 
            // confirmPasswordLabel
            // 
            confirmPasswordLabel.AutoSize = true;
            confirmPasswordLabel.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            confirmPasswordLabel.ForeColor = Color.FromArgb(0, 0, 64);
            confirmPasswordLabel.Location = new Point(11, 206);
            confirmPasswordLabel.Name = "confirmPasswordLabel";
            confirmPasswordLabel.Size = new Size(107, 15);
            confirmPasswordLabel.TabIndex = 13;
            confirmPasswordLabel.Text = "Confirm password";
            // 
            // confirmPasswordTextBox
            // 
            confirmPasswordTextBox.BackColor = SystemColors.ControlLight;
            confirmPasswordTextBox.BorderStyle = BorderStyle.FixedSingle;
            confirmPasswordTextBox.Cursor = Cursors.Hand;
            confirmPasswordTextBox.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            confirmPasswordTextBox.ForeColor = Color.FromArgb(0, 0, 64);
            confirmPasswordTextBox.Location = new Point(121, 206);
            confirmPasswordTextBox.Margin = new Padding(6, 3, 6, 3);
            confirmPasswordTextBox.Name = "confirmPasswordTextBox";
            confirmPasswordTextBox.PasswordChar = '*';
            confirmPasswordTextBox.Size = new Size(187, 23);
            confirmPasswordTextBox.TabIndex = 14;
            confirmPasswordTextBox.Tag = "";
            // 
            // Registration
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.GradientActiveCaption;
            ClientSize = new Size(320, 290);
            Controls.Add(confirmPasswordTextBox);
            Controls.Add(confirmPasswordLabel);
            Controls.Add(acceptButton);
            Controls.Add(mailLabel);
            Controls.Add(mailTextBox);
            Controls.Add(passwordLabel);
            Controls.Add(passwordTextBox);
            Controls.Add(label2);
            Controls.Add(nicknameLabel);
            Controls.Add(nicknameTextBox);
            Controls.Add(lastNameTextBox);
            Controls.Add(lastNameLabel);
            Controls.Add(firstNameLabel);
            Controls.Add(firstNameTextBox);
            Controls.Add(rejectButton);
            Name = "Registration";
            Text = "Registration";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button rejectButton;
        private TextBox firstNameTextBox;
        private Label firstNameLabel;
        private Label lastNameLabel;
        private TextBox lastNameTextBox;
        private TextBox nicknameTextBox;
        private Label nicknameLabel;
        private Label label2;
        private TextBox passwordTextBox;
        private Label passwordLabel;
        private TextBox mailTextBox;
        private Label mailLabel;
        private Button acceptButton;
        private Label confirmPasswordLabel;
        private TextBox confirmPasswordTextBox;
    }
}