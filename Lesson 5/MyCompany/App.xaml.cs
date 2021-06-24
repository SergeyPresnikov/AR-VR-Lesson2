using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Linq;
using System.Threading.Tasks;
using System.Windows;

namespace MyCompany
{
    /// <summary>
   /// Изменить WPF-приложение для ведения списка сотрудников компании(из урока №5), 
   /// используя связывание данных, ListView, ObservableCollection и INotifyPropertyChanged.
   ///1. Создать сущности Employee и Department и заполнить списки сущностей начальными данными.
   ///2. Для списка сотрудников и списка департаментов предусмотреть визуализацию(отображение).
   ///Это можно сделать, например, с использованием ComboBox или ListView.
   ///3. Предусмотреть возможность редактирования сотрудников и департаментов.
   ///Должна быть возможность изменить департамент у сотрудника.
   ///Список департаментов для выбора, можно выводить в ComboBox, это все можно выводить на дополнительной форме.
   ///4. Предусмотреть возможность создания новых сотрудников и департаментов.
   ///Реализовать данную возможность либо на форме редактирования, либо сделать новую форму.

    ///Пресников С.А.
    /// </summary>

    /// <summary>
    /// Логика взаимодействия для App.xaml
    /// </summary>
    public partial class App : Application
    {
        private void Application_Startup(object sender, StartupEventArgs e)
        {
            MainWindow main = new MainWindow();
            main.Title = "MyCompany";
            main.Show();
        }


    }
}
