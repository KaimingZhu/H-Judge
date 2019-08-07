﻿using hjudge.WebHost.Configurations;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace hjudge.WebHost.Models.Problem
{
    public class ProblemEditModel : ResultModel
    {
        public int Id { get; set; }
        [Required]
        public string Name { get; set; } = string.Empty;
        [Required, Range(1, 10)]
        public int Level { get; set; }
        [Required]
        public string Description { get; set; } = string.Empty;
        [Required, Range(1, 2)]
        public int Type { get; set; }
        public bool Hidden { get; set; }
        public ProblemConfig Config { get; set; } = new ProblemConfig();
    }
}