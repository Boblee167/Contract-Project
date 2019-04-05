using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

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

           
    public class Property
        {
        
            [Key]
            [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
            public int Property_ID { get; set; }
                 
            [Required]
            public string Prop_Address { get; set; }

            [Required]
            public string Prop_County { get; set; }

            [Required]
            public Property_Type Type { get; set; }

            [Required]
            public string Cost_Centre { get; set; }

            [Required]
            public string OPW_Building_Code { get; set; }

            [Required]
            public Property_Team Team { get; set; }

            [Required]
            public int SquareMetre { get; set; }

            [Required]
            public int StaffCapacity { get; set; }

            public int CarParkSpots{ get; set; }

            [Required]
            public DateTime DateOpened { get; set; }

            public DateTime DateClosed { get; set; }

            public int? Lease_ID { get; set; }


        // Navigation Properties

        public List<ContractHour> ContractHour { get; set; }

    }
}

