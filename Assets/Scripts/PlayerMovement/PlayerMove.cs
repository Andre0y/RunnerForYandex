using UnityEngine;

public class PlayerMove : MonoBehaviour
{
    [SerializeField] private float _speedX;
    [SerializeField] private float _speedZ;
    [SerializeField] private float _moveZ;
    [SerializeField] private float _minPositionX;
    [SerializeField] private float _maxPositionX;

    private void FixedUpdate()
    {
        if (InputManager.IsMoving("Mouse X") && InputManager.IsLeftMouseButtonDown())
        {
            Vector3 newPositionX = transform.position + transform.right * InputManager.GetAxis("Mouse X");
            newPositionX.x = Mathf.Clamp(newPositionX.x, _minPositionX, _maxPositionX);

            transform.position = Vector3.MoveTowards(transform.position, newPositionX, _speedX * Time.fixedDeltaTime);
        }

        Vector3 newPositionZ = transform.position + transform.forward * _moveZ;

        transform.position = Vector3.MoveTowards(transform.position, newPositionZ, _speedZ * Time.fixedDeltaTime);
    }
}
