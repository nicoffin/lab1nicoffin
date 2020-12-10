namespace lab1nicoffin
{
    public class Pitcher
    {
        public string Name{get; set;}

        public string Team{get; set;}

        public string Throws{get; set;}

        public IPitch pitchBehavior;
        public void SetPitchBehavior(IPitch value){
            pitchBehavior = value;
        }

        public Pitcher(){
            SetPitchBehavior(new Fastball());
        }
    }
}