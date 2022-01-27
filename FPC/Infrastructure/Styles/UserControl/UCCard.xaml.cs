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
    /// Логика взаимодействия для UCCard.xaml
    /// </summary>
    public partial class UCCard : System.Windows.Controls.UserControl
    {
        private static readonly DependencyProperty _path = DependencyProperty.Register("ImagePath", typeof(string), typeof(UCCard), new FrameworkPropertyMetadata(@"D:\Пользователи\Загрузки\Фоточки\Default.png", FrameworkPropertyMetadataOptions.BindsTwoWayByDefault));
        private static readonly DependencyProperty _title = DependencyProperty.Register("Title", typeof(string), typeof(UCCard), new FrameworkPropertyMetadata("Название", FrameworkPropertyMetadataOptions.BindsTwoWayByDefault));
        private static readonly DependencyProperty _description = DependencyProperty.Register("Description", typeof(string), typeof(UCCard), new FrameworkPropertyMetadata("Описание", FrameworkPropertyMetadataOptions.BindsTwoWayByDefault));
        private static readonly DependencyProperty _cost = DependencyProperty.Register("Cost", typeof(string), typeof(UCCard), new FrameworkPropertyMetadata("0", FrameworkPropertyMetadataOptions.BindsTwoWayByDefault));
        
        public string ImagePath
        {
            get => (string)GetValue(_path);
            set => SetValue(_path, value);
        }
        public string Title
        {
            get => (string)GetValue(_title);
            set => SetValue(_title, value);
        }

        public string Desctirpion
        {
            get => (string)GetValue(_description);
            set => SetValue(_description, value);
        }

        public string Cost
        {
            get => (string)GetValue(_cost);
            set => SetValue(_cost, value);
        }  

        public UCCard()
        {
            InitializeComponent();
        }
    }
}
