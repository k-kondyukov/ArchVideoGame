using Entitas;
using Entitas.CodeGeneration.Attributes;
using UnityEngine;

[Game]
public class PositionComponent : IComponent
{
    public Vector2 value;
}

[Game]
public class MoveComponent : IComponent
{
    public Vector2 target;
}

[Game]
public class MoverComponent : IComponent
{
}

[Game]
public class MoveCompleteComponent : IComponent
{
}

[Game]
public class DirectionComponent : IComponent
{
    public Vector2 value;
}

[Game]
public class SpriteComponent : IComponent
{
    public string name;
}

[Game]
public class SizeComponent : IComponent
{
    public Vector2 value;
}

[Game]
public class PlayerComponent : IComponent
{
}

[Game]
public class MeteorComponent : IComponent
{
}

[Game]
public class ViewComponent : IComponent
{
    public GameObject gameObject;
}

[Game]
public class HealthComponent : IComponent
{
    public int value;
}


[Input, Unique]
public class LeftArrowComponent : IComponent
{
}

[Input, Unique]
public class RightArrowComponent : IComponent
{
}

[Input, Unique]
public class UpArrowComponent : IComponent
{
}

[Input, Unique]
public class DownArrowComponent : IComponent
{
}

[Input]
public class ArrowDirectionComponent : IComponent
{
    public Vector2 direction;
}

[Input]
public class ArrowDownComponent : IComponent
{
    public Vector2 direction;
}

[Input]
public class ArrowUpComponent : IComponent
{
    public Vector2 direction;
}