using Entitas;
using UnityEngine;

public class EmitInputSystem : IInitializeSystem, IExecuteSystem
{
    readonly InputContext _context;
    private InputEntity _leftArrowEntity;
    private InputEntity _rightArrowEntity;
    private InputEntity _upArrowEntity;
    private InputEntity _downArrowEntity;

    public EmitInputSystem(Contexts contexts)
    {
        _context = contexts.input;
    }

    public void Initialize()
    {
        // initialise the unique entities that will hold the mouse button data
        _context.isLeftArrow = true;
        _leftArrowEntity = _context.leftArrowEntity;

        _context.isRightArrow = true;
        _rightArrowEntity = _context.rightArrowEntity;

        _context.isUpArrow = true;
        _upArrowEntity = _context.upArrowEntity;

        _context.isDownArrow = true;
        _downArrowEntity = _context.downArrowEntity;
    }

    public void Execute()
    {
        Vector2 left = Vector2.left;
        Vector2 right = Vector2.right;
        Vector2 up = Vector2.up;
        Vector2 down = Vector2.down;

        if (Input.GetKeyDown(KeyCode.LeftArrow))
            _leftArrowEntity.ReplaceArrowDown(left);
        
        if (Input.GetKeyDown(KeyCode.LeftArrow))
            _leftArrowEntity.ReplaceArrowDirection(left);
        
        if (Input.GetKeyDown(KeyCode.LeftArrow))
            _leftArrowEntity.ReplaceArrowUp(left);

        if (Input.GetKeyDown(KeyCode.RightArrow))
            _rightArrowEntity.ReplaceArrowDown(right);

        if (Input.GetKeyDown(KeyCode.RightArrow))
            _rightArrowEntity.ReplaceArrowDirection(right);

        if (Input.GetKeyDown(KeyCode.RightArrow))
            _rightArrowEntity.ReplaceArrowUp(right);

        if (Input.GetKeyDown(KeyCode.UpArrow))
            _upArrowEntity.ReplaceArrowDown(up);

        if (Input.GetKeyDown(KeyCode.UpArrow))
            _upArrowEntity.ReplaceArrowDirection(up);

        if (Input.GetKeyDown(KeyCode.UpArrow))
            _upArrowEntity.ReplaceArrowUp(up);

        if (Input.GetKeyDown(KeyCode.DownArrow))
            _downArrowEntity.ReplaceArrowDown(down);

        if (Input.GetKeyDown(KeyCode.DownArrow))
            _downArrowEntity.ReplaceArrowDirection(down);

        if (Input.GetKeyDown(KeyCode.DownArrow))
            _downArrowEntity.ReplaceArrowUp(down);

    }
}
