﻿using Swellow.Shared.SqlModel.MetaData.Media;
using Swellow.Shared.SqlModel.MetaData.Property;
using System.ComponentModel.DataAnnotations;

namespace Swellow.Shared.SqlModel.MetaData.Middle
{
    // <影视，标签>
    public class WorkTag
    {
        [Required]
        public int WorkId { get; set; }
        [Required]
        public Work? Work { get; set; }


        [Required]
        public int TagId { get; set; }
        [Required]
        public Tag? Tag { get; set; }
    }
}