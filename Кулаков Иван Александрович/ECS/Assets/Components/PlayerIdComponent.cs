using Entitas;
using Entitas.CodeGeneration.Attributes;

[Input, Game]
public sealed class PlayerIdComponent : IComponent
{
  public int value;
}