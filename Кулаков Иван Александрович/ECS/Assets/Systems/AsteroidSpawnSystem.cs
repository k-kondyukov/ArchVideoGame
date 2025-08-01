using Entitas;

using UnityEngine;

public sealed class AsteroidSpawnSystem : IExecuteSystem, IInitializeSystem
{
  private readonly GameContext _gameContext;
  private float _timer;
  private readonly float _spawnInterval; // интервал появления астероидов
  private readonly float _screenWidth = 10f; // нужно будет подставить по экрану

  public AsteroidSpawnSystem(Contexts contexts, float spawnInterval)
  {
    _gameContext = contexts.game;
    _spawnInterval = spawnInterval;
  }

  public void Initialize()
  {
    _timer = _spawnInterval;
  }

  public void Execute()
  {
    _timer -= Time.deltaTime;
    if (_timer <= 0f)
    {
      SpawnAsteroid();
      _timer = _spawnInterval;
    }
  }

  private void SpawnAsteroid()
  {
    float x = Random.Range(-_screenWidth, _screenWidth);
    var asteroid = _gameContext.CreateEntity();
    asteroid.isAsteroidTag = true;
    asteroid.AddPosition(new Vector2(x, 10f));
    asteroid.AddVelocity(new Vector2(0f, -5f)); // падает вниз
  }
}
