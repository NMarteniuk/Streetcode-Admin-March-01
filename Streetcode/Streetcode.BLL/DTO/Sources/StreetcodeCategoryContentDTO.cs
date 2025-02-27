﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Streetcode.BLL.Dto.Sources
{
    public class StreetcodeCategoryContentDto
    {
        [Required]
        [MaxLength(1000)]
        public string Text { get; set; }

        [Required]
        public int SourceLinkCategoryId { get; set; }

        [Required]
        public int StreetcodeId { get; set; }
    }
}
