﻿using Swellow.Shared.SqlModel.MetaData.Media.Television;
using System;
using System.Collections.Generic;
using System.Text;

namespace Swellow.Shared.Dto.Mediadata.Media.Television
{
    public class SeasonDetail
    {
        public int Id { get; set; }
        public int No { get; set; } = 1;
        public string? Outline { get; set; }
        public int? Year { get; set; }
        public int? EndYear { get; set; }
        //public string? Directory { get; set; }
        public string? Poster { get; set; }
        //public IEnumerable<Episode>? Episodes { get; set; } = new List<Episode>();
        //public int? WorkId { get; set; }
        //public Work? Work { get; set; }
    }
}
