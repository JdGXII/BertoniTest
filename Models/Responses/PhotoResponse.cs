﻿using System;
using System.Collections.Generic;
using System.Text;

namespace Models.Responses
{
    public class PhotoResponse
    {
        public int AlbumId { get; set; }
        public int Id { get; set; }
        public string Title { get; set; }
        public string Url { get; set; }
        public string ThumbnailUrl { get; set; }
    }
}
