
public class ProfilePlayer 
{
   private ProfilePlayer(float speedCar)
    {
        CurrentState = new SubscribeProperty<GameState>();
        CurrentCar = new Car(speedCar);
    }

    public SubscribeProperty<GameState> CurrentState { get; }


    public Car CurrentCar { get; }
}
