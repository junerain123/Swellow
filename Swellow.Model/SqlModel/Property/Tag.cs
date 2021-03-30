﻿using Swellow.Model.SqlModel.Middle;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace Swellow.Model.SqlModel.Property
{
    // 【多对多】标签
    public class Tag
    {
        public Tag()
        {
            VideoTags = new List<WorkTag>();
        }

        // 0 主键 ID
        [Key]
        public int Id { get; set; }

        // 1 名称
        public string Name { get; set; }

        // 1 【集合导航】【中间件】<影视作品，标签>
        public List<WorkTag> VideoTags { get; set; }
    }
}
