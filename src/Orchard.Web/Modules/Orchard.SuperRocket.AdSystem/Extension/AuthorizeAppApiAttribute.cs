using System;

namespace Orchard.SuperRocket.AdSystem.Extension
{
    public class AuthorizeAppApiAttribute : Attribute {
        public AuthorizeAppApiAttribute() {
            Enabled = true;
        }
        public AuthorizeAppApiAttribute(bool enabled) {
            Enabled = enabled;
        }

        public bool Enabled { get; set; }
    }
}
