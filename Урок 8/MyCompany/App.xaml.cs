﻿using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Linq;
using System.Threading.Tasks;
using System.Windows;

namespace MyCompany
{
    /// <summary>
    ///Изменить WPF-приложение для ведения списка сотрудников компании(из урока №7), используя веб-сервисы.
    ///Разделить приложение на две части.Первая часть – клиентское приложение, отображающее данные.
    ///Вторая часть – веб-сервис и код, связанный с извлечением данных из БД.Приложение реализует только просмотр данных.
    ///При разработке приложения допустимо использовать любой из рассмотренных типов веб-сервисов.
    ///1. Создать таблицы Employee и Department в БД MSSQL Server и заполнить списки сущностей начальными данными.
    ///2. Для списка сотрудников и списка департаментов предусмотреть визуализацию (отображение).
    ///3. Разработать формы для отображения отдельных элементов списков сотрудников и департаментов.

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
