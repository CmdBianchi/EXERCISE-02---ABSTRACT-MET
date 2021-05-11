using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EXERCISE_02___ABSTRACT_MET.Entities {
    //------------------------------- START -------------------------------//
    abstract class TaxPayer {

        public string Name { get; set; }
        public double AnualIncome { get; set; }

        //---------> CONSTRUCTOR
        public TaxPayer() {
        }
        public TaxPayer(string name, double anualIncome) {
            Name = name;
            AnualIncome = anualIncome;
        }

        //---------> MET
        public abstract double Tax();

    }
    //-------------------------------- END -------------------------------//
}
