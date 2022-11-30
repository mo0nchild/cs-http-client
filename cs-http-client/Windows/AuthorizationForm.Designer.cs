namespace CSHttpClient.Windows
{
    partial class AuthorizationForm
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
            this.username_textbox = new System.Windows.Forms.TextBox();
            this.username_label = new System.Windows.Forms.Label();
            this.password_label = new System.Windows.Forms.Label();
            this.password_textbox = new System.Windows.Forms.TextBox();
            this.authorization_button = new System.Windows.Forms.Button();
            this.password_checkbox = new System.Windows.Forms.CheckBox();
            this.title_label = new System.Windows.Forms.Label();
            this.username_panel = new System.Windows.Forms.Panel();
            this.password_panel = new System.Windows.Forms.Panel();
            this.SuspendLayout();
            // 
            // username_textbox
            // 
            this.username_textbox.BackColor = System.Drawing.Color.White;
            this.username_textbox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.username_textbox.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.username_textbox.Location = new System.Drawing.Point(75, 102);
            this.username_textbox.MaxLength = 100;
            this.username_textbox.Name = "username_textbox";
            this.username_textbox.Size = new System.Drawing.Size(253, 29);
            this.username_textbox.TabIndex = 0;
            // 
            // username_label
            // 
            this.username_label.AutoSize = true;
            this.username_label.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.username_label.Location = new System.Drawing.Point(75, 80);
            this.username_label.Name = "username_label";
            this.username_label.Size = new System.Drawing.Size(128, 19);
            this.username_label.TabIndex = 1;
            this.username_label.Text = "Имя пользователя:";
            // 
            // password_label
            // 
            this.password_label.AutoSize = true;
            this.password_label.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.password_label.Location = new System.Drawing.Point(75, 143);
            this.password_label.Name = "password_label";
            this.password_label.Size = new System.Drawing.Size(125, 19);
            this.password_label.TabIndex = 3;
            this.password_label.Text = "Пароль для входа:";
            // 
            // password_textbox
            // 
            this.password_textbox.BackColor = System.Drawing.Color.White;
            this.password_textbox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.password_textbox.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.password_textbox.Location = new System.Drawing.Point(75, 165);
            this.password_textbox.MaxLength = 100;
            this.password_textbox.Name = "password_textbox";
            this.password_textbox.PasswordChar = '*';
            this.password_textbox.Size = new System.Drawing.Size(253, 29);
            this.password_textbox.TabIndex = 2;
            // 
            // authorization_button
            // 
            this.authorization_button.BackColor = System.Drawing.Color.White;
            this.authorization_button.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.authorization_button.Location = new System.Drawing.Point(75, 238);
            this.authorization_button.Name = "authorization_button";
            this.authorization_button.Size = new System.Drawing.Size(253, 40);
            this.authorization_button.TabIndex = 4;
            this.authorization_button.Text = "Войти в профиль";
            this.authorization_button.UseVisualStyleBackColor = false;
            // 
            // password_checkbox
            // 
            this.password_checkbox.AutoSize = true;
            this.password_checkbox.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.password_checkbox.Location = new System.Drawing.Point(75, 200);
            this.password_checkbox.Name = "password_checkbox";
            this.password_checkbox.Size = new System.Drawing.Size(135, 23);
            this.password_checkbox.TabIndex = 5;
            this.password_checkbox.Text = "Показать пароль";
            this.password_checkbox.UseVisualStyleBackColor = true;
            // 
            // title_label
            // 
            this.title_label.AutoSize = true;
            this.title_label.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.title_label.Location = new System.Drawing.Point(52, 9);
            this.title_label.Name = "title_label";
            this.title_label.Size = new System.Drawing.Size(291, 50);
            this.title_label.TabIndex = 6;
            this.title_label.Text = "Воронежский государственный \r\nтехнический университет";
            this.title_label.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // username_panel
            // 
            this.username_panel.BackColor = System.Drawing.Color.Salmon;
            this.username_panel.Location = new System.Drawing.Point(75, 127);
            this.username_panel.Name = "username_panel";
            this.username_panel.Size = new System.Drawing.Size(253, 4);
            this.username_panel.TabIndex = 7;
            // 
            // password_panel
            // 
            this.password_panel.BackColor = System.Drawing.Color.Salmon;
            this.password_panel.Location = new System.Drawing.Point(75, 190);
            this.password_panel.Name = "password_panel";
            this.password_panel.Size = new System.Drawing.Size(253, 4);
            this.password_panel.TabIndex = 8;
            // 
            // AuthorizationForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(96F, 96F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.ClientSize = new System.Drawing.Size(398, 303);
            this.Controls.Add(this.password_panel);
            this.Controls.Add(this.username_panel);
            this.Controls.Add(this.title_label);
            this.Controls.Add(this.password_checkbox);
            this.Controls.Add(this.authorization_button);
            this.Controls.Add(this.password_label);
            this.Controls.Add(this.password_textbox);
            this.Controls.Add(this.username_label);
            this.Controls.Add(this.username_textbox);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.MaximumSize = new System.Drawing.Size(414, 342);
            this.MinimumSize = new System.Drawing.Size(414, 342);
            this.Name = "AuthorizationForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Авторизация";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private TextBox username_textbox;
        private Label username_label;
        private Label password_label;
        private TextBox password_textbox;
        private Button authorization_button;
        private CheckBox password_checkbox;
        private Label title_label;
        private Panel username_panel;
        private Panel password_panel;
    }
}