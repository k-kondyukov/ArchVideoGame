using Entitas;

using UnityEngine;

public sealed class OutOfBoundsSystem : IExecuteSystem
{
  private readonly GameContext _gameContext;
  private readonly IGroup<GameEntity> _asteroids;
  private readonly float _bottomBound = -6f; // Нижняя граница экрана

  public OutOfBoundsSystem(Contexts contexts)
  {
    _gameContext = contexts.game;
    _asteroids = _gameContext.GetGroup(GameMatcher.AsteroidTag);
  }

  public void Execute()
  {
    foreach (var asteroid in _asteroids.GetEntities())
    {
      if (asteroid.hasPosition && asteroid.position.value.y < _bottomBound)
      {
        asteroid.Destroy();
      }
    }
  }
}