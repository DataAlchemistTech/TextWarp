﻿using System;
using System.Collections.Generic;

namespace TextWarp.Models.Database
{
    public partial class Wynwood
    {
        public int Id { get; set; }
        public string MediaId { get; set; } = null!;
        public string? Title { get; set; }
        public DateTime? CreatedAt { get; set; }
        public DateTime? DeletedAt { get; set; }
        public string? Description { get; set; }
        public string? Ourl { get; set; }
        public double? Owidth { get; set; }
        public double? Oheight { get; set; }
        public string? Turl { get; set; }
        public double? Twidth { get; set; }
        public double? Theight { get; set; }
    }
}
