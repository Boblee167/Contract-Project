using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace ContractManager.Models
{
        public enum Property_Team
        {
            [Display(Name = "Team North")] Team_North,
            [Display(Name = "Team South")] Team_South
        }
        public enum Property_Type
        {
            [Display(Name = "DEASP Office")] DEASP,
            [Display(Name = "Branch Office")] Branch_Office,
            [Display(Name = "HSE Location")] HSE_Location
        }

    public enum Music
    {
        [Display(Name = "None")] None,
        [Display(Name = "Radio")] Radio,
        [Display(Name = "CD")] CD
    }
       
    public class Property
        {
            [Key]
            [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
            public int Property_ID { get; set; }
                 
            [Required]
            public string Address { get; set; }

            [Required]
            public string County { get; set; }

            [Required]
            public Property_Type Type { get; set; }

            [Required]
            public string Cost_Centre { get; set; }

            [Required]
            public string OPW_Building_Code { get; set; }

            [Required]
            public Property_Team Team { get; set; }

            [Required]
            public int SquareFootage { get; set; }

            [Required]
            public int StaffCapacity { get; set; }

            [Required]
            public Music music { get; set; }


        // Navigation Properties
                    

    }
}

