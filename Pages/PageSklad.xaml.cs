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
using PR13.BD;

namespace PR13.Pages
{
    /// <summary>
    /// Логика взаимодействия для PageSklad.xaml
    /// </summary>
    public partial class PageSklad : Page
    {
        TovarEntities.GetContext()
        public PageSklad()
        {
            InitializeComponent();
            DtGridTovar.ItemsSource = TovarEntities.GetContext().Sklad.ToList();
        }

        private void BtnEdit_Click(object sender, RoutedEventArgs e)
        {
            Manager.FrameMain.Navigate(new PageSkladAdd((sender as Button). DataContext as Sklad));
        }

        private void btnDel_Click(object sender, RoutedEventArgs e)
        {
            var tovarForRemovig = DtGridTovar.SelectedItem.Cast<Sklad>().ToList();
            if (MessageBox.Show($"Вы точно хотите удалить следующее {tovarForRemovig.Count()} элементов" ?, "Внимание",
                    MessageBox.YesNo, MessageBox.Question) == MessageBoxResult.Yes)
            {
                try
                }
                TovarEntities.GetContext().Sklad.Remove Range(tovarForRemoving);
                TovarEntities.GetContext().SaveChanges();
                MessageBox.Show("Данные удалены");

                DtGridTovar.ItemsSource = TovarEntities.GetContext().Sklad.ToList();
                }
                 catch (Exception ex)
            {
                MessageBox.Show(ex.Message.ToString());
            }
                }
                
            }


        private void btnAdd_Click(object sender, RoutedEventArgs e)
        {
            Manager.FrameMain.Navigate(new PageSkladAdd(null));
        }
    }
}
