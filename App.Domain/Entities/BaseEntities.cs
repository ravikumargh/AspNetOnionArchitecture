using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace App.Domain.Entities
{
    public class BaseEntities
    {
        [Column("isdeleted")]
        public bool IsDeleted { get; set; }
        [Column("createddatetime")]
        public DateTime CreatedDatetime { get; set; }
        [Column("updateddatetime")]
        public DateTime UpdatedDatetime { get; set; }
    }
}
