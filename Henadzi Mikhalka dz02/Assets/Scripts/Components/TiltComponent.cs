using Entitas;
using Entitas.CodeGeneration.Attributes;
using UnityEngine;

[Game]
public class TiltComponent : IComponent
{
    public float angleY;
    public float angleZ;
}

