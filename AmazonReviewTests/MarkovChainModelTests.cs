using MarkovService;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.Text;

namespace AmazonReviewTests
{
    [TestClass]
    public class MarkovChainModelTests
    {
        [TestMethod]
        public void ModelTrainingTest()
        {
            var markovModel = new MarkovChainModel();
            markovModel.TrainModel();
        }
    }
}
