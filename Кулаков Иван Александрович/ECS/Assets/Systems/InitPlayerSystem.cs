using Entitas;

using UnityEngine;

public sealed class InitPlayerSystem : IInitializeSystem
{
  private readonly GameContext _context;

  public InitPlayerSystem(Contexts contexts)
  {
    _context = contexts.game;
  }

  public void Initialize()
  {
    var entity = _context.CreateEntity();
    entity.isPlayerTag = true;
    entity.AddPlayerId(0);
    entity.AddPosition(new Vector2(0, -4));
    entity.AddVelocity(new Vector2(5f, 0));
  }
}