using System;
namespace OopCatExercise
{
	public abstract class Cat : ICat
	{
		public bool IsAsleep { get; protected set; }

		public Cat(){
			IsAsleep = false;
		}

		public abstract void WakeUp();
		public void GoToSleep(){
			IsAsleep = true;
		}
		public abstract string Eat();

	}
}
