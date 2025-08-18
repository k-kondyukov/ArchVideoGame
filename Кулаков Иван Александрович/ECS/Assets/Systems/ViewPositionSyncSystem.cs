using Entitas;

using UnityEngine;

public sealed class ViewPositionSyncSystem : IExecuteSystem
{
  private readonly IGroup<GameEntity> _entities;

  public ViewPositionSyncSystem(Contexts contexts)
  {
    _entities = contexts.game.GetGroup(GameMatcher.AllOf(
        GameMatcher.Position,
        GameMatcher.View
    ));
  }

  public void Execute()
  {
    foreach (var e in _entities)
    {
      var view = e.view.gameObject;

      // ✅ Добавляем проверку на null/уничтожение
      if (view == null || view.gameObject == null) continue;

      view.transform.position = e.position.value;
    }
  }
}
