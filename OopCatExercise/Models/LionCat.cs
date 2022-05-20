namespace OopCatExercise
{
    public class LionCat:Cat{
        public string Setting { get; private set; }
        public int AverageHeight { get; private set; }
        public LionCat():base(){
            AverageHeight = 1100;
            Setting = "wild";
        }
        public override string Eat(){
            return "Roar!!!!";
        }

        public override void WakeUp(){
            IsAsleep = false;
        }
    }
}