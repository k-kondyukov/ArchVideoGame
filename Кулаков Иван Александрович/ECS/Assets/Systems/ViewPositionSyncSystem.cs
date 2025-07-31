using Entitas;

using UnityEngine;

public sealed class ViewPositionSyncSystem : IExecuteSystem
{
  private readonly IGroup<GameEntity> _viewGroup;

  public ViewPositionSyncSystem(Contexts contexts)
  {
    _viewGroup = contexts.game.GetGroup(GameMatcher.AllOf(GameMatcher.Position, GameMatcher.View));
  }

  public void Execute()
  {
    foreach (var e in _viewGroup)
    {
      e.view.gameObject.transform.position = e.position.value;
    }
  }
}