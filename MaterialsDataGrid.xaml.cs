using System;
using System.Collections.Generic;
using System.Data.Entity;
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
using System.Windows.Shapes;

namespace FurnitureDEGTYANNIKOVIN_3802
{
    /// <summary>
    /// Логика взаимодействия для MaterialsDataGrid.xaml
    /// </summary>
    public partial class MaterialsDataGrid : Window
    {
        public MaterialsDataGrid()
        {
            InitializeComponent();
        }

        private void Window_Loaded(object sender, RoutedEventArgs e)
        {
            BD.db.Fur_Material.Load();
            BD.db.Fur_Provider.Load();
            BD.db.Fur_Type_Materal.Load();
            BD.db.Fur_Material_Unit_Of_Measurement.Load();
            MaterialsGrid.ItemsSource = BD.db.Fur_Material.ToList();
            //MaterialsGrid.ItemsSource = BD.db.Fur_Type_Materal.ToList();
            //MaterialsGrid.ItemsSource = BD.db.Fur_Material_Unit_Of_Measurement.ToList();

        }
    }
}
