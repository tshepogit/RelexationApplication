using System;
using System.Collections.Generic;
using System.Text;

namespace RelexationApplication
{
    public class Story
    {
        public int StoryId { get; set; }
        public string Title { get; set; }
        public string Author { get; set; }
        public string Reference { get; set; }
        public string Detail { get; set; }
        public int CategoryId { get; set; }
    }
}
