using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Serialization;
using static Груповая_динамика_Программа.LoginForm;

namespace Груповая_динамика_Программа
{
    public partial class LoginForm : Form
    {
        private bool ForLogin = true;

        public UserData userData { get; set; }

        public LoginForm()
        {
            InitializeComponent();
            DialogResult = DialogResult.Cancel;

            Password_One_TextBox.KeyPress += Entry_ban;
            Password_Two_TextBox.KeyPress += Entry_ban;
        }

        private void LoginOrRegistrationButton_Click(object sender, EventArgs e)
        {
            if (LoginTextBox.Text.Equals("") || Password_One_TextBox.Text.Equals(""))
            {
                MessageBox.Show("Поле ввода пусто!", "Ошибка!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            if (!Regex.Match(LoginTextBox.Text, @"^\%*$~`").Success)
            {
                MessageBox.Show("Логин введен некорректно!!!\nРазрешены буквы, цифры и символ нижнего подчеркивания.", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                LoginTextBox.Focus();
                return;
            }

            UserData UserByForm = new UserData(LoginTextBox.Text, Password_One_TextBox.Text);

            List<UserData> UsersData = GetUsersData_by_Deserealize();

            bool RealUser = false, ToAcceptPassword = false;

            if (UsersData != null)
            {
                foreach (UserData userD in UsersData)
                {
                    if (userD.NameUser.Equals(UserByForm.NameUser))
                    {
                        RealUser = true;

                        if (userD.PasswordUser.Equals(UserByForm.PasswordUser))
                            ToAcceptPassword = true;

                        break;
                    }
                }
            }

            if (ForLogin)
            {

                if (UsersData == null || !RealUser)
                {
                    MessageBox.Show("Такого пользователя не существует, зарегестрируйтесь!", "Ошибка!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    ForLogin = false;
                    Set_display();
                    return;
                } 
                
                if(!ToAcceptPassword)
                {
                    MessageBox.Show("Введён неверный пароль!!!", "Ошибка!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                DialogResult = DialogResult.OK;

                userData = UserByForm;

                this.Close();
            }
            else
            {

                if(!Password_One_TextBox.Text.Equals(Password_Two_TextBox.Text))
                {
                    MessageBox.Show("Пароли не совпадают!", "Ошибка!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                if (RealUser)
                {
                    MessageBox.Show("Данное имя пользователя уже занято, выберите другое имя!", "Ошибка!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                if (UsersData == null)
                    UsersData = new List<UserData>();

                UsersData.Add(UserByForm);

                XmlSerializer xmlSerializer = new XmlSerializer(typeof(List<UserData>));

                using (var fs = new FileStream(@"DataUsers\Users.xml", FileMode.Create))
                {
                    xmlSerializer.Serialize(fs, UsersData);
                }

                MessageBox.Show("Вы успешно зарегестрировались!", "Оповещение.", MessageBoxButtons.OK, MessageBoxIcon.Question);

                DialogResult = DialogResult.OK;
                
                userData = UserByForm;

                this.Close();
            }

        }

        [Serializable]
        public struct UserData
        {
            public UserData(string _NameUser, string _PasswordUser)
            {
                NameUser = _NameUser;
                PasswordUser = _PasswordUser;
            }
            public string NameUser;
            public string PasswordUser;

            public override bool Equals(object obj)
            {
                //return base.Equals(obj);
                
                UserData ToEqualsData = (UserData) obj;

                if(this.NameUser.Equals(ToEqualsData.NameUser) && this.PasswordUser.Equals(ToEqualsData.PasswordUser))
                    return true;
                else 
                    return false;
            }
        }

        private List<UserData> GetUsersData_by_Deserealize()
        {
            if (!Directory.Exists("DataUsers"))
            {
                Directory.CreateDirectory("DataUsers");
                return null;
            }

            if (File.Exists(@"DataUsers\Users.xml"))
            {
                XmlSerializer xmlSerializer = new XmlSerializer(typeof(List<UserData>));

                using (var fs = new FileStream(@"DataUsers\Users.xml", FileMode.Open))
                {
                    try
                    {
                        return xmlSerializer.Deserialize(fs) as List<UserData>;
                    }
                    catch (System.InvalidOperationException ex)
                    {
                        MessageBox.Show(ex.Message + "\nБыл создан новый файл.", "Ошибка!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        fs.Close();
                        File.Delete("DataUsers\\Users.xml");
                    }
                }

            }
             
            return null;
        }

        private void Set_display()
        {

            if(ForLogin)
            {
                Login_lable.Text = "Введите ваш логин";
                Password_One_lable.Text = "Введите ваш пароль";
                Password_Two_lable.Visible = false;

                Password_Two_TextBox.Visible = false;

                LoginOrRegistrationButton.Location = new Point(LoginOrRegistrationButton.Location.X, Password_Two_TextBox.Location.Y);

                LoginOrRegistrationButton.Text = "Войти";
            }
            else
            {
                Login_lable.Text = "Придумайте логин";
                Password_One_lable.Text = "Придумайте пароль";
                Password_Two_lable.Visible = true;

                Password_Two_TextBox.Visible = true;

                LoginOrRegistrationButton.Location = new Point(LoginOrRegistrationButton.Location.X,
                    Password_Two_TextBox.Location.Y + (Password_Two_TextBox.Location.Y - Password_One_TextBox.Location.Y));
            
                LoginOrRegistrationButton.Text = "Регистрация";
            }

        }

        private void LoginForm_Load(object sender, EventArgs e)
        {
            Set_display();
        }

        private void ChangeLoginOrRegistationButton_Click(object sender, EventArgs e)
        {
            ForLogin = !ForLogin;
            Set_display();
        }

        private void Entry_ban(object sender, KeyPressEventArgs e)
        {
            if(e.KeyChar == '*' || e.KeyChar == ' ')
            {
                e.Handled = true;
                return;
            }
        }
    }
}
