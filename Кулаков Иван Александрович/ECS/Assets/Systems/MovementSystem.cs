using Entitas;

using UnityEngine;

public sealed class MovementSystem : IExecuteSystem
{
  private readonly IGroup<GameEntity> _movables;

  public MovementSystem(Contexts contexts)
  {
    _movables = contexts.game.GetGroup(GameMatcher.AllOf(
        GameMatcher.Position,
        GameMatcher.Velocity));
  }

  public void Execute()
  {
    float deltaTime = Time.deltaTime;

    foreach (var e in _movables)
    {
      Vector2 position = e.position.value;
      Vector2 velocity = e.velocity.value;

      Vector2 newPosition = position + velocity * deltaTime;
      e.ReplacePosition(newPosition);
    }
  }
}
