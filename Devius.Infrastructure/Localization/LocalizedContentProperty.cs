using Devius.Infrastructure.Data;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace Devius.Infrastructure.Localization
{
    public class LocalizedContentProperty : EntityBase
    {
        public Guid EntityId { get; set; }

        [StringLength(450)]
        public string EntityType { get; set; }

        [Required]
        public string CultureId { get; set; }

        public Culture Culture { get; set; }

        [Required]
        [StringLength(450)]
        public string ProperyName { get; set; }

        public string Value { get; set; }
    }
}
