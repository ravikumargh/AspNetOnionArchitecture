using System;
using System.Collections.Generic;
using System.Text;

namespace App.Domain.ViewModels
{
    public class ActivityModel
    {
        public Int64 ActivityId { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public bool? IsDeleted { get; set; }
        public DateTime? CreatedDatetime { get; set; }
        public DateTime? UpdatedDatetime { get; set; }
        public bool? Isassessment { get; set; }
        public bool? Ispractise { get; set; }
        public bool? Saveforlater { get; set; }
        public int TaskCount { get; set; }
        public bool? isFavourite { get; set; }
    }
}
