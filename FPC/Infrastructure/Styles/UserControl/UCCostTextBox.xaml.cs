using System;
using System.Windows;


namespace FPC.Infrastructure.Styles.UserControl
{
    /// <summary>
    /// Логика взаимодействия для UCCostTextBox.xaml
    /// </summary>
    public partial class UCCostTextBox : System.Windows.Controls.UserControl
    {
        private static readonly DependencyProperty _hintProperty = DependencyProperty.Register("Hint", typeof(string), typeof(UCCostTextBox), new FrameworkPropertyMetadata("Поле ввода", FrameworkPropertyMetadataOptions.BindsTwoWayByDefault));

        public string Hint
        {
            get => (string)GetValue(_hintProperty);
            set => SetValue(_hintProperty, value);
        }

        public UCCostTextBox()
        {
            InitializeComponent();
        }
    }
}
