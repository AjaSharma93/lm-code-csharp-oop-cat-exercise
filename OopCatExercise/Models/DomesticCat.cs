namespace OopCatExercise
{
    public class DomesticCat:Cat{
        public string Setting { get; private set; }
        public int AverageHeight { get; private set; }
        public DomesticCat():base(){
            AverageHeight = 23;
            Setting = "domestic";
        }
        public override string Eat(){
            return "Purrrrrrr";
        }

        public override void WakeUp(){
            IsAsleep = false;
        }
    }
}