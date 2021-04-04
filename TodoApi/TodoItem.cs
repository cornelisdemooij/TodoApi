using System;

namespace TodoApi
{
    public class TodoItem
    {
        public string description { get; set; }

        public DateTime creation { get; set; }

        public DateTime deadline { get; set; }

        public bool done { get; set; }
    }
}
