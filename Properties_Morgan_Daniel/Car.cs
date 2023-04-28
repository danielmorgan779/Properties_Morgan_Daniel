using System;
using System.Collections.Generic;
using System.Text;

namespace Properties_Morgan_Daniel
{
    class Car
    {

        private string model; // A field and property called model

        public string Model { get { return model; } set { model = value; } } // A public field and property called Model

        public string Make { get; set; } // A getter and setter for the public Model property



    }
}
