using System;
using System.Linq;


namespace calc {
    public class StringCalculator {
        public int Add(string args) {
            if (IsEmpty(args)) {
                return 0;
            }
            return ParseArgument(args);
        }

        private int ParseArgument(string input) {
            if (input.Contains(',')) {
                return ParseMultiple(input);
            }
            return int.Parse(input);
        }
        private int ParseMultiple(string input) {
            string[] parts = input.Split(',');
            var numbers = parts.Select((number)=>int.Parse(number));
            return numbers.Sum();
        }

        private bool IsEmpty(string input) {
            return input == "";
        }
    }
}
