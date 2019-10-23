using Models;
using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;

namespace MarkovService
{
    public class MarkovChainModel : IModelStrategy
    {
        private FileReader _filereader;
        public MarkovChainModel()
        {
            _filereader = new FileReader();
        }
        public string GenerateReview()
        {
            throw new NotImplementedException();
        }

        public void TrainModel()
        {
            List<AmazonReview> reviews = _filereader.GetReviews(@"C:\temp\loyal\reviews_Video_Games_5.json\Video_Games_5.json");
            List<String> textReviews = reviews.ConvertAll(x => x.ReviewText);
            textReviews.Take(10);

            // Create a new model
            var model = new StringMarkov(2);

            // Train the model
            model.Learn(textReviews.Take(50));

            // Create some permutations
            Console.WriteLine(model.Walk().First());

            String res = model.Walk().First();
            Console.WriteLine(res);

            
        }
    }
}
