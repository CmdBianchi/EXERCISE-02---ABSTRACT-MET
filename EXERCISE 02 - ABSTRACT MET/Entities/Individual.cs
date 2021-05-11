using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
namespace EXERCISE_02___ABSTRACT_MET.Entities {
    //------------------------------- START -------------------------------//
    class Individual :TaxPayer {
        public double HealthExpenditures { get; set; }

        public Individual() {
        }

        //---------> CONSTRUCTOR
        public Individual(string name, double anualIncome, double healthExpenditures) : base(name, anualIncome) {
            HealthExpenditures = healthExpenditures;
        }

        public override double Tax() {
            if (AnualIncome < 20000.0) {
                return AnualIncome * 0.15 - HealthExpenditures * 05;
            }
            else {
                return AnualIncome * 0.25 - HealthExpenditures * 05;
            }
        }

    }
    //-------------------------------- END -------------------------------//
}
