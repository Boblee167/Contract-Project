using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace ContractManager.Models
{
    public class ContractDetails
    {
        public enum Service
        {
            [Display(Name = "Security")] Security,
            [Display(Name = "Office Cleaning")] Cleaning,
            [Display(Name = "Transport")] Transport,
            [Display(Name = "Waste")] Waste,
            [Display(Name = "Fire_Equipment")] Fire_Equipment
        }

        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Contract_ID { get; set; }

        [Required]
        public int Supplier_ID { get; set; }

       [Required]
        public DateTime StartDate { get; set; }

        [Required]
        public DateTime FinishDate { get; set; }

        [Required]
        public Service services { get; set; }

        [Required]
        public Double HourlyPrice { get; set; }
        
        public String GoodsDesc { get; set; }

        public Double GoodsPrice { get; set; }

        //Navigation Property
        public virtual Supplier Supplier { get; set; }

        









    }
}