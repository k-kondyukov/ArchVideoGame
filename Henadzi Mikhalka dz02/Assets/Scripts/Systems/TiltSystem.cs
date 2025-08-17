using Entitas;
using Entitas.Unity;
using UnityEngine;

public sealed class TiltSystem : IExecuteSystem
{
    private Contexts _contexts;

    public TiltSystem(Contexts contexts)
    {
        _contexts = contexts;
    }

    public void Execute()
    {
        var setup = _contexts.game.gameSetup.value;
        var player = _contexts.game.playerEntity;
        var view = player.view.value;
        var rotation = view.transform.rotation.eulerAngles;
        var angleY = Mathf.Clamp(player.tilt.angleY, -50, 50);
        var angleZ = Mathf.Clamp(player.tilt.angleZ, -10, 10);

        angleY += _contexts.game.input.value.x * setup.tiltY;
        angleZ -= _contexts.game.input.value.x * setup.tiltZ;

        if (angleY > 0) angleY -= 3f;
        if (angleY < 0) angleY += 3f;
        if (angleZ > 0) angleZ -= 1f;
        if (angleZ < 0) angleZ += 1f;

        rotation.y = angleY;
        rotation.z = angleZ;
        view.transform.rotation = Quaternion.Euler(rotation);
    }
}
