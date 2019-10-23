using System;
using System.Collections.Generic;
using System.Text;

namespace Models
{
    public class AmazonReview
    {
        public string ReviewerID { get; set; }
        public string Asin { get; set; }
        public string ReviewerName { get; set; }
        public List<int> Helpful { get; set; }
        public string ReviewText { get; set; }
        public double Overall { get; set; }
        public string Summary { get; set; }
        public int UnixReviewTime { get; set; }
        public string ReviewTime
        {
            get; set;
        }
    }
}
