namespace lab1nicoffin
{
    public class Lefty : Pitcher
    {
        public Lefty(){
            Throws = "left";
            SetPitchBehavior(new Curveball());
        }
       

    }
}