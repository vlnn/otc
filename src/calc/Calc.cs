using System;
using System.Linq;


namespace calc {
    public class StringCalculator {
        public int Add(string args) {
            if (IsNonCalculable(args)){
                return 0;
                } else {
                return GetNumber(args);
            }
        }
       
        private bool IsNonCalculable(string input){
            return (IsEmpty(input) || IsWrongFormat(input));
        }

        private bool IsEmpty(string input){
            return input.Length == 0;
        }

        private bool IsWrongFormat(string input){
            return !int.TryParse(input, out _);
        }

        private int GetNumber(string input){
            return int.Parse(input);
        }
    }
}
