using System;
using System.Linq;


namespace calc {
    public class StringCalculator {

        private char delimiter = ',';

        public int Add(string args) {
            if (IsNonCalculable(args)){
                return 0;
                } else {
                return GetNumbers(args);
            }
        }
       
        private bool IsNonCalculable(string input){
            return (IsEmpty(input) || IsWrongFormat(input));
        }

        private bool IsEmpty(string input){
            return input.Length == 0;
        }

        private bool IsWrongFormat(string input){
            var splittedInput = Split(input);
            bool[] isValid = {};
            foreach (string rawNumber in splittedInput){
                isValid.Append(int.TryParse(rawNumber, out _));
            }
            return !isValid.All(x => x);
        }

        private string[] Split(string input){
            return input.Split(delimiter);
        }

        private int GetNumber(string input){
            return int.Parse(input);
        }

        private int GetNumbers(string input) {
            if (input.Contains(delimiter)) {
                return ParseMultiple(input);
            }
            return GetNumber(input);
        }

        private int ParseMultiple(string input) {
            string[] parts = Split(input);
            var numbers = parts.Select((number)=>int.Parse(number));
            return numbers.Sum();
        }
    }
}
