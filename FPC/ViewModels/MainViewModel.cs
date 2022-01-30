using FPC.Infrastructure.Commands;
using FPC.Infrastructure.Commands.Base;
using FPC.ViewModels.Base;
using FPC.Views.Pages;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Controls;


namespace FPC.ViewModels
{
    class MainViewModel : ViewModel
    {
        #region Смена прозрачности

        private double _opacityItem = 1;

        public double OpacityItem
        {
            get => _opacityItem;
            set => Set(ref _opacityItem, value);
        }

        public async void ChangeOpacity(Page InputPage, string InputBackground)
        {
            if (CurrentPage != InputPage)
            {
                await Task.Factory.StartNew(() =>
                {
                    for (double i = 1; i > 0; i -= 0.1)
                    {
                        OpacityItem = i;
                        Thread.Sleep(10);
                    }

                    CurrentBackground = InputBackground;
                    CurrentPage = InputPage;

                    for (double i = 0; i < 1; i += 0.1)
                    {
                        OpacityItem = i;
                        Thread.Sleep(20);
                    }
                });
            }
        }

        #endregion

        #region Фон страниц

        private string _mainBackgorund = $@"C:\Users\Designeed\source\repos\WPF\FPC\FPC\Infrastructure\Backgrounds\Light\MainBackground.png";
        private string _basketBackground = $@"C:\Users\Designeed\source\repos\WPF\FPC\FPC\Infrastructure\Backgrounds\Light\BasketBackground.png";
        private string _profileBackground = $@"C:\Users\Designeed\source\repos\WPF\FPC\FPC\Infrastructure\Backgrounds\Light\ProfileBackground.png";
        private string _currentBackground;

        public string CurrentBackground
        {
            get => _currentBackground;
            set => Set(ref _currentBackground, value);
        }
        public string MainBackgorund => _mainBackgorund;
        public string BasketBackground
        {
            get
            {
                return _basketBackground;
            }
        }
        public string ProfileBackground => _profileBackground;

        #endregion

        #region Страницы приложения
        private readonly Page _mainContentPage;
        private readonly Page _basketPage;
        private readonly Page _profilePage;
        private Page _currentPage;

        /// <summary> Изменение страниц </summary>
        public Page CurrentPage
        {
            get => _currentPage;
            set => Set(ref _currentPage, value);
        }

        public Page BasketPage => _basketPage;

        public Page ProfilePage => _profilePage;

        public Page MainPage => _mainContentPage;
        public Command ChangeViewCommand { get; set; }

        #endregion

        public MainViewModel()
        {
            _mainContentPage = new MainContentPage();
            _basketPage = new BasketPage();
            _profilePage = new ProfilePage();

            CurrentPage = _mainContentPage;
            CurrentBackground = MainBackgorund;
            ChangeViewCommand = new ChangeViewCommand(this);
        }
    }
}
