using Entitas;

using UnityEngine;

public sealed class CollisionDetectionSystem : IExecuteSystem
{
  private readonly IGroup<GameEntity> _players;
  private readonly IGroup<GameEntity> _asteroids;

  private const float PlayerRadius = 1.5f;
  private const float AsteroidRadius = 0.8f;

  public CollisionDetectionSystem(Contexts contexts)
  {
    _players = contexts.game.GetGroup(GameMatcher.PlayerTag);
    _asteroids = contexts.game.GetGroup(GameMatcher.AsteroidTag);
  }

  public void Execute()
  {
    foreach (var player in _players)
    {
      Vector2 playerPos = player.position.value;

      foreach (var asteroid in _asteroids)
      {
        Vector2 asteroidPos = asteroid.position.value;

        float dist = Vector2.Distance(playerPos, asteroidPos);
        if (dist < PlayerRadius + AsteroidRadius)
        {
          // Коллизия обнаружена
          player.isDestroyed = true; // или любой компонент, который обозначает смерть
          return;
        }
      }
    }
  }
}
