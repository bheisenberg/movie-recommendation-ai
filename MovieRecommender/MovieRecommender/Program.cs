﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MovieRecommender
{
    class Program
    {
        static void Main(string[] args)
        {
            Parser parser = new Parser();
            MovieRecommender movieRecommender = new MovieRecommender(parser.GetNeuralData());
        }
    }
}
