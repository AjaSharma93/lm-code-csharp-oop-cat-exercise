namespace OopCatExercise
{
    public class CheetahCat:Cat{
        public string Setting { get; private set; }
        public int AverageHeight { get; private set; }
        public CheetahCat():base(){
            AverageHeight = 189;
            Setting = "wild";
        }
        public override string Eat(){
            return "Zzzzzzz";
        }

        public override void WakeUp(){
            IsAsleep = false;
        }
    }
}