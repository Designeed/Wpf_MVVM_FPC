using System.Windows;

namespace FPC.Infrastructure.Styles.UserControl
{
    /// <summary>
    /// Логика взаимодействия для UCPasswordBox.xaml
    /// </summary>
    public partial class UCPasswordBox : System.Windows.Controls.UserControl
    {
        private static readonly DependencyProperty _titleProperty = DependencyProperty.Register("Header", typeof(string), typeof(UCTextBox), new PropertyMetadata("Заголовок"));

        public string Header
        {
            get => (string)GetValue(_titleProperty);
            set => SetValue(_titleProperty, value);
        }

        public UCPasswordBox()
        {
            InitializeComponent();
        }
    }
}
