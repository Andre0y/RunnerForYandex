using UnityEngine;

public class PlayerMove : MonoBehaviour
{
    [SerializeField] private float _speedX;
    [SerializeField] private float _speedZ;
    [SerializeField] private float _minPositionX;
    [SerializeField] private float _maxPositionX;
    
    private bool _isMoving = true;
    private IPlayerMovement _playerMovement;

    private const string MouseX = "Mouse X";

    private void Start()
    {
        _playerMovement = new PlayerMovement(transform);
    }

    private void Update()
    {
        HandleInput();

        if (_isMoving)
        {
            _playerMovement.Move(Vector3.forward, _speedZ);
        }
    }

    private void HandleInput()
    {
        if(InputManager.IsMoving(MouseX) && InputManager.IsLeftMouseButtonDown())
        {
            float movementVectorX = InputManager.GetAxis(MouseX);
            float newPositionX = Mathf.Clamp(transform.position.x + movementVectorX, _minPositionX, _maxPositionX);
            _playerMovement.Move(new Vector3(newPositionX - transform.position.x, 0, 0), _speedX);
        }
    }

    public void SetMove(bool isMoving)
    {
        _isMoving = isMoving;
    }
}
