using Entitas;

using UnityEngine;

public sealed class PlayerMovementSystem : IExecuteSystem
{
  private readonly IGroup<GameEntity> _players;
  private readonly InputContext _input;
  private readonly float _moveSpeed;

  public PlayerMovementSystem(Contexts contexts, float moveSpeed)
  {
    _players = contexts.game.GetGroup(GameMatcher.AllOf(
        GameMatcher.PlayerTag,
        GameMatcher.Velocity,
        GameMatcher.PlayerId
    ));
    _input = contexts.input;
    _moveSpeed = moveSpeed;
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

      // input (-1..1) * скорость
      Vector2 velocity = input * _moveSpeed;
      e.ReplaceVelocity(velocity);
    }
  }
}

