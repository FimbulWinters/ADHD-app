using ADHD.Models;
using CommunityToolkit.Mvvm.ComponentModel;
using Realms;

namespace ADHD.ViewModels
{
    public partial class ChartViewModel: ObservableObject
    {
        Realm realm = Realm.GetInstance();

        public List<ActivityModel> Days { get; set; }

        public void addActivity (ActivityModel activity)
        {
            realm.Write(() =>
            {
                realm.Add(new ActivityModel()
                {
                    ActivityName = activity.ActivityName,
                    ActivityTimeString = activity.ActivityTimeString,
                    ActivityTimes = activity.ActivityTimes,
                    ActivityType = activity.ActivityType,

                });
            });
        }

        public void GetActivities()
        {
            var days = realm.All<ActivityModel>();
            foreach (var day in days)
                Days.Add(day);
        }


        
        public ChartViewModel() 
        {
            Days = new List<ActivityModel>();
            foreach (ActivityModel day in Days)
                new ActivityModel() { ActivityName = $"{day.ActivityName}", ActivityTimes =day.ActivityTimes };
               
           
           
        }
    }
}
