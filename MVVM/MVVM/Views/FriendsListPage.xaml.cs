using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MVVM.ViewModel;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;
using static MVVM.ViewModel.FriendListViewModel;

namespace MVVM.Views
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class FriendsListPage : ContentPage
    {
        public FriendsListPage()
        {
            InitializeComponent();
            BindingContext = new FriendsListViewModel() { Navigation = this.Navigation };
        }
    }
}