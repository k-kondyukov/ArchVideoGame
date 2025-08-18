using Entitas;
using UnityEngine;
using System.Collections.Generic;

public sealed class ViewSystem : ReactiveSystem<GameEntity>
{
  private readonly Transform _parent;

  public ViewSystem(Contexts contexts) : base(contexts.game)
  {
    _parent = new GameObject("Entities").transform;
  }

  protected override ICollector<GameEntity> GetTrigger(IContext<GameEntity> context)
  {
    return context.CreateCollector(GameMatcher.Position.Added());
  }

  protected override bool Filter(GameEntity entity)
  {
    return entity.hasPosition && !entity.hasView;
  }

  protected override void Execute(List<GameEntity> entities)
  {
    foreach (var entity in entities)
    {
      GameObject prefab = null;

      if (entity.isPlayerTag)
        prefab = Resources.Load<GameObject>("Prefabs/Player");
      else if (entity.isAsteroidTag)
        prefab = Resources.Load<GameObject>("Prefabs/Asteroid");

      if (prefab == null)
        continue;

      var go = Object.Instantiate(prefab, entity.position.value, Quaternion.identity, _parent);
      entity.AddView(go);

      var view = go.GetComponent<IView<GameEntity>>();
      if (view != null)
        view.Entity = entity;
    }
  }
}
