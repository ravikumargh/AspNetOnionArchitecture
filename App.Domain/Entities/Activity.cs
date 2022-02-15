using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace App.Domain.Entities
{
    [Table("activity_new")]
    public class Activity
    {
        [Key]
        [Column("activity_id")]
        public Int64 ActivityId { get; set; }
        [Column("name")]
        public string Name { get; set; }
        [Column("description")]
        public string Description { get; set; }
        [Column("is_favourite")]
        public bool isFavourite { get; set; }
        [Column("is_deleted")]
        public bool IsDeleted { get; set; }
        [Column("created_datetime")]
        public DateTime CreatedDatetime { get; set; }
        [Column("updated_datetime")]
        public DateTime UpdatedDatetime { get; set; }
    }
}
