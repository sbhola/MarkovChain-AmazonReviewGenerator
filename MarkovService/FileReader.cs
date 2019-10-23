using Models;
using System.Collections.Generic;
using System.IO;
using Newtonsoft.Json;

namespace MarkovService
{
    public class FileReader
    {
        public List<AmazonReview> GetReviews(string filePath)
        {
            StreamReader file = new System.IO.StreamReader(filePath);
            string line;
            List<AmazonReview> result = new List<AmazonReview>();
            while ((line = file.ReadLine()) != null)
            {
                AmazonReview review = JsonConvert.DeserializeObject<AmazonReview>(line);
                result.Add(review);
            }
            return result;
        }
    }
}
