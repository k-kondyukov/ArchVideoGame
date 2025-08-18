using Entitas;

using UnityEngine;

public sealed class InputSystem : IExecuteSystem
{
  private readonly Contexts _contexts;

  public InputSystem(Contexts contexts)
  {
    _contexts = contexts;
  }

  public void Execute()
  {
    float h = Input.GetAxisRaw("Horizontal");
    var inputContext = _contexts.input;

    // Если уже есть InputEntity — обновим значение
    if (inputContext.hasInput)
    {
      inputContext.input.value = new Vector2(h, 0);
    }
    else
    {
      var inputEntity = inputContext.SetInput(new Vector2(h, 0));
      inputEntity.AddPlayerId(0); // Важно для привязки
    }
  }
}

