using FPC.ViewModels;

namespace FPC.Infrastructure.Commands
{
    class ChangeViewCommand : Base.Command
    {
        private readonly MainViewModel _viewModel;

        public ChangeViewCommand(MainViewModel viewModel)
        {
            _viewModel = viewModel;
        }

        public override bool CanExecute(object parameter) => true;

        public override void Execute(object parameter)
        {
            if (parameter?.ToString() == "MainPage")
                _viewModel.ChangeOpacity(_viewModel.MainPage, _viewModel.MainBackgorund);

            else if (parameter?.ToString() == "BasketPage")
                _viewModel.ChangeOpacity(_viewModel.BasketPage, _viewModel.BasketBackground);

            else if (parameter?.ToString() == "ProfilePage")
                _viewModel.ChangeOpacity(_viewModel.ProfilePage, _viewModel.ProfileBackground);
        }
    }
}
