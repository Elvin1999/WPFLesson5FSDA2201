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

namespace WpfApp3
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {


        public List<Book> Books { get; set; } = new List<Book>
        {
            new Book
            {
                Id=1,
                Author="Richter",
                Genre="Fun",
                Pages=1100,
                Publisher="Baku INC",
                Title="C# via CLR",
                ImagePath="Images/image1.jpg"
            },
            new Book
            {
                Id=2,
                Author="Exupery",
                Pages=650,
                Genre="Not so fun",
                Publisher="Baku INC",
                Title="Little prince",
                ImagePath="Images/image2.jpg"

            },
            new Book
            {
                Id=3,
                Author="GOF",
                Pages=700,
                Genre="Very fun",
                Publisher="Baku INC",
                Title="Design Pattern Principles",
                ImagePath="Images/image3.jpg"
            },
        };
        public MainWindow()
        {
            InitializeComponent();
            // listview.ItemsSource = Books;
            this.DataContext = this;
        }

        private void listview_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
           // MessageBox.Show((listview.SelectedItem as Book).Title);
        }
    }
}
