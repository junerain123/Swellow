﻿using Swellow.Shared.SqlModel.People;
using Swellow.Shared.SqlModel.Works;
using System;
using System.Collections.Generic;
using System.Text;

namespace Swellow.Shared.SqlModel.Middle
{
    // <影视，导演>
    public class VideoDirector
    {
        public int IdVideo { get; set; }
        public Video Video { get; set; }

        public int IdCast { get; set; }
        public Cast Cast { get; set; }
    }
}