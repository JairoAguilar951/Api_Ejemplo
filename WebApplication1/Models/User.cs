namespace WebApplication1.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class User
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int Id_User { get; set; }

        [Required]
        
        public string Name { get; set; }
        
        public string Lastname { get; set; }

        public int? Age { get; set; }

        public string Location { get; set; }
        
        public string Description { get; set; }
        
        public string Title { get; set; }
        
        public string Phrase { get; set; }

        public bool Status { get; set; }

        [Required]
        public string Password { get; set; }

        [Required]
        public string Background { get; set; }

        [Required]
        public string Email { get; set; }

        [Required]
        public string Type { get; set; }
    }
}
