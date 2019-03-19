using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace ContractManager.Models
{

    public class Supplier
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Supplier_ID { get; set; }

        [Required]
        public string SupplierNumber { get; set; }

        [Required]
        public string SupplierName { get; set; }

        [Required]
        public string SupplierAddress { get; set; }

        [Required]
        public string SupplierCounty { get; set; }

        [Required]
        public string SupplierContact { get; set; }

        [Required]
        [EmailAddress]
        public string SupplierEMail { get; set; }
            
            
        // Navigation Properties

        public virtual List<ContractDetails> ContractDetails { get; set; }


    }
}