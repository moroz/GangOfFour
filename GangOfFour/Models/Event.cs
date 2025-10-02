using System;
using System.ComponentModel.DataAnnotations;
using Medo;

namespace GangOfFour.Models
{
    public class Event
    {
        [Key] public Guid EventId { get; set; } = Uuid7.NewGuid();

        [Required, StringLength(100)] public string TitleEn { get; set; }
        [Required, StringLength(2000)] public string DescriptionEn { get; set; }
        [Required] public DateTime StartsAt { get; set; }
        [Required] public DateTime EndsAt { get; set; }

        public DateTime CreatedAt { get; set; } = DateTime.UtcNow;
        public DateTime UpdatedAt { get; set; } = DateTime.UtcNow;
    }
}