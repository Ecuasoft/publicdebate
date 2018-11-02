using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace PublicDebate.Data
{
    public class DebateDbEntity
    {
        public Guid Id { get; set; }
        [Required]
        [MaxLength(500)]
        public string Title { get; set; }
        [Required]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public DateTimeOffset CreationDate { get; set; }
        [Required]
        [DatabaseGenerated(DatabaseGeneratedOption.Computed)]
        public DateTimeOffset ModificationDate { get; set; }
        [Required]
        public Guid CreatedBy { get; set; }
    }
}