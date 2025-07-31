using Entitas;

using UnityEngine;

public sealed class PlayerMovementSystem : IExecuteSystem
{
  private readonly IGroup<GameEntity> _players;
  private readonly InputContext _input;

  public PlayerMovementSystem(Contexts contexts)
  {
    _players = contexts.game.GetGroup(GameMatcher.AllOf(
        GameMatcher.PlayerTag,
        GameMatcher.Position,
        GameMatcher.Velocity,
        GameMatcher.PlayerId
    ));
    _input = contexts.input;
  }

  public void Execute()
  {
    var inputEntity = _input.inputEntity;
    if (inputEntity == null) return;

    var input = inputEntity.input.value;
    var playerId = inputEntity.playerId.value;

    foreach (var e in _players)
    {
      if (e.playerId.value != playerId) continue;

      Vector2 velocity = e.velocity.value;
      Vector2 newPosition = e.position.value + input * velocity * Time.deltaTime;
      e.ReplacePosition(newPosition);
    }
  }
}

