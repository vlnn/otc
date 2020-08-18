namespace calc {
    public class Calc {
        private int _total;

        public int Total { get => _total; set => _total = value; }

        public int GetTotal() => Total;

        public void Add(int x) => Total += x;

        public void Reset() => Total = 0;
    }

}
