using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace EmployeeRegistration
{
    /// <summary>
    /// Логика взаимодействия для Registration.xaml
    /// </summary>
    public partial class Registration : Page
    {
        public Registration()
        {
            InitializeComponent();

            CmbGender.ItemsSource = new Gender[]
         {
            new Gender { Name = "Мужчина" },
            new Gender { Name = "Женщина"}
         };

            CmbRole.ItemsSource = new Role[]
        {
            new Role { Name = "Директор" },
            new Role { Name = "Администратор" },
            new Role { Name = "Бухгалтер" },
            new Role { Name = "Снабженец" },
            new Role { Name = "Юрист" },
            new Role { Name = "Менеджер по персоналу" },
            new Role { Name = "Уборщица"}
        };

        }


        public class Gender
        {
            public string Name { get; set; } = "";
            public override string ToString() => $"{Name}";
        }

        public class Role
        {
            public string Name { get; set; } = "";
            public override string ToString() => $"{Name}";
        }

        private void TbFirsName_GotFocus(object sender, RoutedEventArgs e)
        {
            if (TbFirsName.Text == "Введите Имя")
            {
                TbFirsName.Text = "";
            }
        }

        private void TbFirsName_LostFocus(object sender, RoutedEventArgs e)
        {
            if (TbFirsName.Text == "")
            {
                TbFirsName.Text = "Введите Имя";
            }
        }

        private void TbLastName_GotFocus(object sender, RoutedEventArgs e)
        {
            if (TbLastName.Text == "Введите Фамилию")
            {
                TbLastName.Text = "";
            }
        }

        private void TbLastName_LostFocus(object sender, RoutedEventArgs e)
        {
            if(TbLastName.Text == "")
            {
                TbLastName.Text = "Введите Фамилию";
            }
        }

        private void TbPatronymic_GotFocus(object sender, RoutedEventArgs e)
        {
            if (TbPatronymic.Text == "Введите Oтчество")
            {
                TbPatronymic.Text = "";
            }
        }

        private void TbPatronymic_LostFocus(object sender, RoutedEventArgs e)
        {
            if (TbPatronymic.Text == "")
            {
                TbPatronymic.Text = "Введите Отчество";
            }
        }

        private void TbPasport_GotFocus(object sender, RoutedEventArgs e)
        {
            if (TbPasport.Text == "Введите серию и номер паспорта (без пробела)")
            {
                TbPasport.Text = "";
            }
        }

        private void TbPasport_LostFocus(object sender, RoutedEventArgs e)
        {
            if (TbPasport.Text == "")
            {
                TbPasport.Text = "Введите серию и номер паспорта (без пробела)";
            }
        }

        private void TbPhoneNumber_GotFocus(object sender, RoutedEventArgs e)
        {
            if (TbPhoneNumber.Text == "Введите Номер")
            {
                TbPhoneNumber.Text = "";
            }
        }

        private void TbPhoneNumber_LostFocus(object sender, RoutedEventArgs e)
        {
            if (TbPhoneNumber.Text == "")
            {
                TbPhoneNumber.Text = "Введите Номер";
            }
        }

        private void TbEmail_GotFocus(object sender, RoutedEventArgs e)
        {
            if (TbEmail.Text == "Введите Email")
            {
                TbEmail.Text = "";
            }
        }

        private void TbEmail_LostFocus(object sender, RoutedEventArgs e)
        {
            if (TbEmail.Text == "")
            {
                TbEmail.Text = "Введите Email";
            }
        }

        private void BtnRegistration_Click(object sender, RoutedEventArgs e)
        {
            if (string.IsNullOrWhiteSpace(TbFirsName.Text) || TbFirsName.Text == "Введите Имя")
            {
                MessageBox.Show("Поле Имя должно быть заполнено", "Ошибка", MessageBoxButton.OK, MessageBoxImage.Error);
                return;
            }
            else if (string.IsNullOrWhiteSpace(TbLastName.Text))
            {
                MessageBox.Show("Поле Фамилия должно быть заполнено", "Ошибка", MessageBoxButton.OK, MessageBoxImage.Error);
                return;
            }
            else { MessageBox.Show("Пользователь зарегистрирован", "Успешно", MessageBoxButton.OK, MessageBoxImage.Information); }
        }
    }
}
