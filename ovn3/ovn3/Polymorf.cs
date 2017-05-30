using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ovn3 {
    class Polymorf {
    }

    /// <summary>
    /// 3.3
    /// 11. Varför är polyformism viktig? DRY
    /// 12. Specialiserad
    /// 
    /// 
    /// </summary>
    public abstract class UserError {
        public abstract string UEMessage();
    }

    class NumericInputError : UserError {
        public override string UEMessage() {
            return "You tried to use a numeric input in a text field. This fired an error!";
        }
    }

    class TextInputError : UserError {
        public override string UEMessage() {
            return "You tried to use a text input in a numeric field. This fired an error!";
        }
    }

    class ProgramInputError : UserError {
        public override string UEMessage() {
            return "You tried to use this program in a bad way. This fired an error!";
        }
    }

    class CatInputError : UserError {
        public override string UEMessage() {
            return "You tried to feed the cat with a potatoe. You are f***g fired!";
        }
    }

    class SleepInputError : UserError {
        public override string UEMessage() {
            return "You didn't tried to do a input. This fired an error!";
        }
    }

}
