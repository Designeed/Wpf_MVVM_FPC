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

namespace FPC.Infrastructure.Styles.UserControl
{
    /// <summary>
    /// Логика взаимодействия для UserControlTextBox.xaml
    /// </summary>
    public partial class UCTextBox : UserControl
    {
        public static readonly DependencyProperty TitleProperty = DependencyProperty.Register("title", typeof(string), typeof(UCTextBox), new PropertyMetadata(string.Empty));
        public static readonly DependencyProperty FieldTextProperty = DependencyProperty.Register("text", typeof(string), typeof(UCTextBox), new FrameworkPropertyMetadata(string.Empty, FrameworkPropertyMetadataOptions.BindsTwoWayByDefault));

        public string Title
        {
            get => (string) GetValue(TitleProperty);
            set => SetValue(TitleProperty, value);
        }

        public string Text
        {
            get => (string) GetValue(FieldTextProperty);
            set => SetValue(FieldTextProperty, value);
        }

        public UCTextBox()
        {
            InitializeComponent();
        }
    }
}
