using Core.DAL;
using Core.Model;
using System.Windows;

namespace Counter
{
    /// <summary>
    /// Interaction logic for Registration.xaml
    /// </summary>
    public partial class Registration : Window
    {
        private Pair _pair;
        public Registration(Pair pair = null)
        {
            InitializeComponent();
            _pair = pair;
        }

        private void SaveClick(object sender, RoutedEventArgs e)
        {
            if(_pair == null)
            {
                Participant male = new Participant()
                {
                    Name = this.Male.Name.Text,
                    Surname = this.Male.Surname.Text
                };
                Participant female = new Participant()
                {
                    Name = this.Female.Name.Text,
                    Surname = this.Female.Surname.Text
                };
                _pair = new Pair()
                {
                    Male = male,
                    Female = female
                };
            }
            DataAccessLayer.Add(_pair);    
        }
    }
}
