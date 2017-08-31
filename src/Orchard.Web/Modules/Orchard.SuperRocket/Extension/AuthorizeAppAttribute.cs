﻿using System;

namespace Orchard.SuperRocket.AdSystem.Extension
{
    public class AuthorizeAppAttribute : Attribute {
        public AuthorizeAppAttribute() {
            Enabled = true;
        }
        public AuthorizeAppAttribute(bool enabled) {
            Enabled = enabled;
        }

        public bool Enabled { get; set; }
    }
}
