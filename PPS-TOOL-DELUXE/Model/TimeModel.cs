namespace PPS_TOOL_DELUXE.Model
{
    public class TimeModel
    {
        public int T0 { get; }
        public int T1 { get; }
        public int T2 { get; }
        public int T3 { get; }

        public TimeModel(int t0, int t1, int t2, int t3)
        {
            this.T0 = t0;
            this.T1 = t1;
            this.T2 = t2;
            this.T3 = t3;
        }
    }
}
