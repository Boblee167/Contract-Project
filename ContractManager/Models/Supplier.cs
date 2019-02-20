using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace ContractManager.Models
{

    public class Supplier
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Supplier_ID { get; set; }

        [Required]
        public string SupplierName { get; set; }

        [Required]
        public string SupplierAddress { get; set; }

        [Required]
        [EmailAddress]
        public string SupplierEMail { get; set; }

        [Required]
        public string SupplierContact { get; set; }

        [Required]
        public string SupplierPhoneNo { get; set; }

       



        // Navigation Properties




    }
}