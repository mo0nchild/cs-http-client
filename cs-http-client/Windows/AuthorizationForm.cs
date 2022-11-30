using CSHttpClient;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CSHttpClient.Windows
{
    public partial class AuthorizationForm : Form
    {
        private Controllers.IValidationController ValidationController { get; set; } = default!;
        protected Controllers.IProfileController? ProfileController { get; set; } = default;
        protected virtual System.Int32 TextboxMinChar { get => 4; }

        public AuthorizationForm(IServiceProvider service_provider)
        {
            this.InitializeComponent();
            this.ProfileController = service_provider.GetService<Controllers.IProfileController>();
            this.ValidationController = new Controllers.ValidationController();

            this.authorization_button.Click += new EventHandler(AuthorizationButtonClick);
            this.password_checkbox.Click += new EventHandler(PasswordCharChange);

            this.username_textbox.TextChanged += new EventHandler(UsernameTextboxTextChanged);
            this.password_textbox.TextChanged += new EventHandler(PasswordTextboxTextChanged);
        }

        private void PasswordTextboxTextChanged(object? sender, EventArgs args)
        {
            var token = this.ValidationController.TakeToken(this.password_textbox.Name);
            token.TokenValue = this.password_textbox.Text.Length >= this.TextboxMinChar;

            this.password_panel.BackColor = (token.TokenValue) ? Color.GreenYellow : Color.Salmon;
        }

        private void UsernameTextboxTextChanged(object? sender, EventArgs args)
        {
            var token = this.ValidationController.TakeToken(this.username_textbox.Name);
            token.TokenValue = this.username_textbox.Text.Length >= this.TextboxMinChar;

            this.username_panel.BackColor = (token.TokenValue) ? Color.GreenYellow : Color.Salmon;
        }

        private void AuthorizationButtonClick(object? sender, EventArgs args)
        {
            string username = this.username_textbox.Text, password = this.password_textbox.Text;
            if (!this.ValidationController.CheckAllTokens())
            {
                MessageBox.Show("Поля авторизации заполнены неверно", "Ошибка"); return;
            }
            try {
                var profile_info = this.ProfileController!.GetProfileData(username, password);
                var statements_info = this.ProfileController!.GetProfileStatements(profile_info.Code, profile_info.Сourse);

                var profile_form = new ProfileForm(profile_info, statements_info);
                profile_form.FormClosed += (sender, args) => this.Show();

                profile_form.Show(); this.Hide();
            }
            catch (System.Exception error) { MessageBox.Show($"Невозможно авторизироваться: {error.Message}", "Ошибка"); return; }
        }

        private void PasswordCharChange(object? sender, EventArgs args)
        {
            switch (this.password_checkbox.Checked)
            {
                case true: this.password_textbox.PasswordChar = default; break;
                case false: this.password_textbox.PasswordChar = '*'; break;
            }
        }
    }
}
