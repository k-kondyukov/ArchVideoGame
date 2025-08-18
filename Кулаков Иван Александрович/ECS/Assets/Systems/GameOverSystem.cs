using Entitas;

using UnityEngine;

public sealed class GameOverSystem : IExecuteSystem
{
  private readonly IGroup<GameEntity> _destroyedPlayers;

  public GameOverSystem(Contexts contexts)
  {
    _destroyedPlayers = contexts.game.GetGroup(GameMatcher.Destroyed);
  }

  public void Execute()
  {
    if (_destroyedPlayers.count > 0)
    {
      // Остановить время
      Time.timeScale = 0;

      // Можно вызвать событие, открыть UI "Game Over"
      Debug.Log("Game Over!");
    }
  }
}
