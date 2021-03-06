﻿using System.Collections.Generic;
using BaseProject.Application.Common;
using BaseProject.Domain;
using Whoever.Common.Mapping;

namespace BaseProject.Application.Roles
{
    public class RolesViewModel
    {
        public int Id{ get; set; }
        public string Name{ get; set; }
        public bool Checked { get; set; }
    }
}
