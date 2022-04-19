using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace App.Domain.Entities
{
    [Table("item")]
    public class Item : BaseEntities
    {
        [Key]
        [Column("itemid")]
        public Int64 ItemId { get; set; }
        [Column("name")]
        public string Name { get; set; }
        [Column("description")]
        public string Description { get; set; }
        [Column("isfavourite")]
        public bool isFavourite { get; set; }
        [Column("type")]
        public int ItemType { get; set; }
    }
}
