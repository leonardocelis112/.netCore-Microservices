﻿using System;
namespace MangoWeb
{
    public class SD
    {
        public static string? ProductAPIBase { get; set; }
        public enum ApiType {
            GET,
            POST,
            PUT,
            DELETE
        }
    }
}

