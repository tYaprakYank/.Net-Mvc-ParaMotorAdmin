﻿using System;
using System.Collections.Generic;

namespace occupy.Models.Entitles;

public partial class Slide
{
    public int Id { get; set; }

    public string? Title { get; set; }

    public string? Subtitle { get; set; }

    public string? Url { get; set; }

    public string? UrlText { get; set; }

    public string? Image { get; set; }

    public string? UrlTarget { get; set; }

    public bool? Isview { get; set; }

    public int? Order { get; set; }
}
