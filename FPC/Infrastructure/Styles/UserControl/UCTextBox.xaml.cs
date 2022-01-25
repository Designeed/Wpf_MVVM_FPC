using System.Windows;

namespace FPC.Infrastructure.Styles.UserControl
{
    /// <summary>
    /// Логика взаимодействия для UCTextBox.xaml
    /// </summary>
    public partial class UCTextBox : System.Windows.Controls.UserControl
    {
        public static readonly DependencyProperty TitleProperty = DependencyProperty.Register("title", typeof(string), typeof(UCTextBox), new PropertyMetadata("Заголовок"));
        public static readonly DependencyProperty FieldTextProperty = DependencyProperty.Register("text", typeof(string), typeof(UCTextBox), new FrameworkPropertyMetadata("Поле ввода", FrameworkPropertyMetadataOptions.BindsTwoWayByDefault));

        public string Title
        {
            get => (string)GetValue(TitleProperty);
            set => SetValue(TitleProperty, value);
        }

        public string Text
        {
            get => (string)GetValue(FieldTextProperty);
            set => SetValue(FieldTextProperty, value);
        }

        public UCTextBox()
        {
            InitializeComponent();
        }
    }
}
