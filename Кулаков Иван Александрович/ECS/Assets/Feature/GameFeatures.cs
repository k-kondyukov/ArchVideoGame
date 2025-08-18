using Entitas;

public class GameFeatures : Systems
{
  public GameFeatures(Contexts contexts)
  {
    Add(new InitPlayerSystem(contexts));
    Add(new InputSystem(contexts));
    Add(new PlayerMovementSystem(contexts, 5));
    Add(new AsteroidSpawnSystem(contexts, 1.5f));
    Add(new MovementSystem(contexts));
    Add(new OutOfBoundsSystem(contexts));
    Add(new CollisionDetectionSystem(contexts));
    Add(new GameOverSystem(contexts));
    Add(new RestartSystem());
    Add(new ViewSystem(contexts));
    Add(new ViewPositionSyncSystem(contexts));
  }
}
