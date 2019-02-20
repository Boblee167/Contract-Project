using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace ContractManager.Models
{
    public enum WeekDay {Mon,Tues,Wed,Thur,Fri,Sat,Sun}
        

    public class ContractHours
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int CleaningHour_id { get; set; }

        [Required]
        public int Contract_ID { get; set; }

        [Required]
        public int Property_ID { get; set; }
     
        [Required]
        public WeekDay weekDay { get; set; }
                                              
        [Required]
        public double Hours {get; set; }

        public DateTime HoursupDatedDate { get; set; }

        public double weeklyHours { get; set; }

        public double AnnualHours { get; set; }

        public double AvgMonthlyHours { get; set; }

    }
}