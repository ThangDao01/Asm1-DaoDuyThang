using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.InteropServices.WindowsRuntime;
using Windows.Foundation;
using Windows.Foundation.Collections;
using Windows.UI.Xaml;
using Windows.UI.Xaml.Controls;
using Windows.UI.Xaml.Controls.Primitives;
using Windows.UI.Xaml.Data;
using Windows.UI.Xaml.Input;
using Windows.UI.Xaml.Media;
using Windows.UI.Xaml.Navigation;
using Asm_DaoDuyThang.Model;
using System.Collections.ObjectModel;

// The Blank Page item template is documented at https://go.microsoft.com/fwlink/?LinkId=402352&clcid=0x409

namespace Asm_DaoDuyThang
{
    /// <summary>
    /// An empty page that can be used on its own or navigated to within a Frame.
    /// </summary>
    public sealed partial class MainPage : Page
    {
        private List<Icon> Icons;
        //private List<Contact> Contacts;
        private ObservableCollection<Product> Products;
        public MainPage()
        {
            this.InitializeComponent();
            Icons = new List<Icon>();
            Icons.Add(new Icon { IconPath = "https://www.englishclub.com/images/vocabulary/food/vegetables/vegetables.jpg" });
            Icons.Add(new Icon { IconPath = "https://i.insider.com/60ff1914f350d50019590549?width=1136&format=jpeg" });
            Icons.Add(new Icon { IconPath = "https://medinabaking.com/wp-content/uploads/2020/01/Flour.jpg" });
            //Contacts = new List<Contact>();
            Products = new ObservableCollection<Product>();
        }
        private void NewContactButton_Click(object sender, RoutedEventArgs e)
        {
            string image = ((Icon)ImageComboBox.SelectedValue).IconPath;
            Products.Add(new Product { ProductName = ProductNameTextBox.Text, Description = DescriptionTextBox.Text, Image = image });
            ProductNameTextBox.Text = "";
            DescriptionTextBox.Text = "";
            ImageComboBox.SelectedIndex = -1;
            ProductNameTextBox.Focus(FocusState.Programmatic);
        }
    }
}
