

using ADHD.Models;
using CommunityToolkit.Mvvm.ComponentModel;
using CommunityToolkit.Mvvm.Input;
using Realms;
using Realms.Sync;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;

namespace ADHD.ViewModels
{
    public partial class FormViewModel : ObservableObject
    {

        private Realm realm;
        
        public FormViewModel()
        {
           realm = Realm.GetInstance(AppConfig.RealmAppId);
        }

        [ObservableProperty]
        ObservableCollection<ActivityModel> dailyActivities;

        [ObservableProperty]
        string activityName;
        [ObservableProperty]
        double activityTimes;
        [ObservableProperty]
        string activityType;

       

        [RelayCommand]
        async void AddActivity()
        {

           
            ActivityModel activity = new ActivityModel
            {
                ActivityName = ActivityName,
                ActivityTimeString = "fishy",
                ActivityTimes = ActivityTimes,
                ActivityType = ActivityType
            };
            


            realm.Write(() =>
            {
                realm.Add(activity);
            });

            await App.Current.MainPage.DisplayAlert("success", "your activity has been added", "ok");
            ActivityName = string.Empty;
            ActivityTimes = double.Parse("0");
            ActivityType = string.Empty;
        }

        
    }

}
