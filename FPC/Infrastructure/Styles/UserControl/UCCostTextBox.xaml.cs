using System;
using System.Windows;


namespace FPC.Infrastructure.Styles.UserControl
{
    /// <summary>
    /// Логика взаимодействия для UCCostTextBox.xaml
    /// </summary>
    public partial class UCCostTextBox : System.Windows.Controls.UserControl
    {
        private static readonly DependencyProperty FieldTextProperty = DependencyProperty.Register("text", typeof(string), typeof(UCCostTextBox), new FrameworkPropertyMetadata("Поле ввода", FrameworkPropertyMetadataOptions.BindsTwoWayByDefault));

        public string Text
        {
            get => (string)GetValue(FieldTextProperty);
            set => SetValue(FieldTextProperty, value);
        }

        public UCCostTextBox()
        {
            InitializeComponent();
        }
    }
}
