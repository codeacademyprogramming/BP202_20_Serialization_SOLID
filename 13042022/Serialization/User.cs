using System;
using System.Collections.Generic;
using System.Text;

namespace Serialization
{
    [Serializable]
    public class User
    {
        public string Name { get; set; }
        public string Surname { get; set; }
        public byte Age { get; set; }

    }
}
