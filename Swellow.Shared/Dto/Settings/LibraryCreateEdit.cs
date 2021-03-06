﻿using Swellow.Shared.SqlModel.LocalData;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace Swellow.Shared.Dto.Settings
{
    public class LibraryCreateEdit
    {
        // 1 名称
        [Display(Name = "名称")]
        [Required(ErrorMessage = "{0}是必填项")]
        [MaxLength(50, ErrorMessage = "{0}的长度不能超过{10}")]
        public string Name { get; set; } = "新媒体库";

        // 2 类型
        //[Display(Name = "类型")]
        //[Required(ErrorMessage = "{0}是必填项")]
        //public LibraryType Type { get; set; }

        // 3 预览图路径
        //public IBrowserFile? Picture { get; set; }
        public string? Picture { get; set; }

        // 4【集合导航】包含的文件夹的路径们
        [Display(Name = "名称")]
        [Required(ErrorMessage = "{0}是必填项")]
        [MinLength(1, ErrorMessage = "至少选择一个文件夹")]
        public List<string>? Directorys { get; set; }
    }
}
