using System;
using System.Collections.Generic;
using System.Runtime.Serialization;
using System.Text;

namespace core
{
    [Serializable]
    public class Message
    {
        public string Content { get; set; }
        public object Data { get; set; }
        public string Type { get; set; }
    }
}
