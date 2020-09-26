namespace Observer
{
    public interface IObservable
    {
        void Subscribe(IObserver<Temperature> Observer); //Agrego Reportador
        void Unsubscribe(IObserver<Temperature> Observer); //Elimino Reportador
        
    }
}