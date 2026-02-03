using System;
using System.Collections.Generic;
using System.Text;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Shapes;

namespace RoyalDelivery.Views
{
    /// <summary>
    /// Interaction logic for UserView.xaml
    /// </summary>
    public partial class UserView : Window // Ensure this matches the base class in all partial declarations
    {
        private bool _contentLoaded; // Add this field if not already present in the other partial class

        public UserView()
        {
            InitializeComponent();
        }

        public UserView(bool contentLoaded)
        {
            _contentLoaded = contentLoaded;
        }
    }
}
