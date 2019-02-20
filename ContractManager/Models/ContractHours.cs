using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace ContractManager.Models
{
    public enum WeekDay {Mon,Tue,Wed,Thu,Fri,Sat,Sun}
        

    public class ContractHours
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Transaction_ID { get; set; }

        [ForeignKey("Property")]
        public int Property_ID { get; set; }

        [ForeignKey("ContractDetails")]
        public int Contract_ID { get; set; }

        [Required]
        public WeekDay Weekday { get; set; }
                                              
        [Required]
        public double DailyHours {get; set; }

        public DateTime HoursUpdatedDate { get; set; }

        public double WeeklyHours { get; set; }

        public double AvgMonthlyHours { get; set; }


        // Navigation Properties
        public virtual Property Property { get; set; }
        public virtual ContractDetails ContractDetails { get; set; }
    }

    

}