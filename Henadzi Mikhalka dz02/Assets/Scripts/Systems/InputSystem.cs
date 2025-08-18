using Entitas;
using Entitas.Unity;
using UnityEngine;

public sealed class InputSystem : IExecuteSystem
{
    private Contexts _contexts;

    public InputSystem(Contexts contexts)
    {
        _contexts = contexts;
    }

    public void Execute()
    {
        var x = Input.GetAxis("Horizontal");
        var y = Input.GetAxis("Vertical");

        _contexts.game.ReplaceInput(new Vector3(x, y, 0f));
    }
}
