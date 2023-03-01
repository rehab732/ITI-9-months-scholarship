using Observer_Task;
using Observer_Task.WithEvents;
using Observer_Task.withoutEvents;

internal class Program
{
    private static void Main(string[] args)
    {
        #region Without Events

        /*

        var observable = new Observable();
        var observerA = new observerA();
        var observerB = new observerB();
        Console.WriteLine("=======================");
        observable.Attach(observerA);
        observable.Attach(observerB);
        Console.WriteLine("=======================");

        observable.State= 1;
        observable.State = 2;
        Console.WriteLine("=======================");

        observable.Detach(observerB);
        Console.WriteLine("=======================");

        observable.State = 3;*/
        #endregion

        var Observable = new ObservableEvent();
        var observerA = new ObserversBEvent();
        var observerB = new ObserversAEvent();
        Observable.statechanged += observerA.ReactToEvent;
        Observable.statechanged += observerB.ReactToEvent;
        Observable.State = 1;
        Observable.State = 2;
        Observable.statechanged += observerB.ReactToEvent;
        Observable.State = 3;


    }
}