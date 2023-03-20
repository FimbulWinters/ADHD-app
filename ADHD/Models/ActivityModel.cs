using MongoDB.Bson;
using Realms;
using System.ComponentModel.DataAnnotations;


namespace ADHD.Models
{
    public partial class ActivityModel : IRealmObject
    {

        [Indexed]
        [PrimaryKey] 
        //public ObjectId id { get; set; } = ObjectId.GenerateNewId();
       
        [Realms.Required]
        [Display(Prompt ="Activity name")]
        public string ActivityName { get; set; }

        [Display(Prompt ="Activity Time String")]
        public string ActivityTimeString { get; set; }

        [Display(Prompt ="times")]
        public double ActivityTimes { get; set; }

        [Display(Prompt ="Activity type")]
        public string ActivityType { get; set; }

        
    }
}
