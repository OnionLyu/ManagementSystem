using ModLogin.Models;
using Prism.Commands;
using Prism.Events;
using Prism.Mvvm;
using Prism.Regions;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ModLogin.ViewModels
{
    public class UserLoginViewModel:BindableBase
    {
        private readonly IRegionManager _regionManager;
        private readonly IEventAggregator _eventAggregator;

        private User _user = new ();
        public User user
        {
            get => _user;
            private set => SetProperty(ref _user, value);
        }

        public UserLoginViewModel(IRegionManager regionManager, IEventAggregator aggregator)
        {
            _regionManager = regionManager;
            _eventAggregator = aggregator;
        }
        public DelegateCommand LoginCommand => new(() =>
        {
            //Add login logic here.........
        });
    }
}
