﻿using Devius.Infrastructure.Data;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace Devius.Infrastructure.Localization
{
    public class Resource : EntityBase
    {
        [Required(ErrorMessage = "The {0} field is required.")]
        [StringLength(450)]
        public string Key { get; set; }

        public string Value { get; set; }

        [Required(ErrorMessage = "The {0} field is required.")]
        public string CultureId { get; set; }

        public Culture Culture { get; set; }
    }
}
