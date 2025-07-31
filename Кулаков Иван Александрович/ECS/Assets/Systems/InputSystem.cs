using Entitas;

using UnityEngine;

public sealed class InputSystem : IExecuteSystem
{
  private readonly InputContext _input;

  public InputSystem(Contexts contexts)
  {
    _input = contexts.input;
  }

  public void Execute()
  {
    float h = Input.GetAxisRaw("Horizontal");
    var inputEntity = _input.inputEntity;

    if (inputEntity == null)
    {
      inputEntity = _input.SetInput(new Vector2(h, 0));
      inputEntity.AddPlayerId(0);
    }
    else
    {
      inputEntity.ReplaceInput(new Vector2(h, 0));
    }
  }
}
