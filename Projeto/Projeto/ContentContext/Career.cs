using System.Collections.Generic;

namespace Projeto.ContentContext
{
    public class Career : Content
    {
        public IList<CareerItem> Items { get; set; }
        public int TotalCourses => Items.Count;

        public Career(string title, string url) : base(title, url)
        {
            Items = new List<CareerItem>();
        }
    }
}
