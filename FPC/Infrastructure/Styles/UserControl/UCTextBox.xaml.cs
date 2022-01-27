using System.Windows;

namespace FPC.Infrastructure.Styles.UserControl
{
    /// <summary>
    /// Логика взаимодействия для UCTextBox.xaml
    /// </summary>
    public partial class UCTextBox : System.Windows.Controls.UserControl
    {
        private static readonly DependencyProperty _titleProperty = DependencyProperty.Register("Title", typeof(string), typeof(UCTextBox), new PropertyMetadata("Заголовок"));
        private static readonly DependencyProperty _hintProperty = DependencyProperty.Register("Hint", typeof(string), typeof(UCTextBox), new FrameworkPropertyMetadata("Поле ввода", FrameworkPropertyMetadataOptions.BindsTwoWayByDefault));

        public string Title
        {
            get => (string)GetValue(_titleProperty);
            set => SetValue(_titleProperty, value);
        }

        public string Hint
        {
            get => (string)GetValue(_hintProperty);
            set => SetValue(_hintProperty, value);
        }

        public UCTextBox()
        {
            InitializeComponent();
        }
    }
}
