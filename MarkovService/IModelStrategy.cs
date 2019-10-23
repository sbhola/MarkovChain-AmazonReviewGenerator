using System;
using System.Collections.Generic;
using System.Text;

namespace MarkovService
{
    public interface IModelStrategy
    {
        public void TrainModel();

        public String GenerateReview();
    }
}
