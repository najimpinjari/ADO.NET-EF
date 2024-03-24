using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace EF_CF1.models
{
    [Table("EFStudent")]
    public class Studnet
    {
        [Key]
        public int RollNumber { get; set; }

        [Required]
        [Column("StudentName",TypeName ="varchar")]
        [MaxLength(50)]
        public string Name { get; set; }

        [MaxLength(100)]
        public string City   { get; set; }

        [Required]
        //[Index("Ix_Student_email ",IsClustered = false,IsUnique =true)]
        public string Email   { get; set; }

        [NotMapped]
        public string ConfirmEmail   { get; set; }

        [ForeignKey("Trainer")] //for making foreign key
        public int TrainerId { get; set; } //make foreign key

        public  Trainer Trainer { get; set; }
    }
}