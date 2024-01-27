using System.Collections;
using UnityEngine;

public class MoveWeapon : MonoBehaviour
{
    [SerializeField] private float _recoilTime;
    private Vector3 _direction = Vector3.forward;
    [SerializeField] private float _speedX;
    [SerializeField] private float _speedZ;
    [SerializeField] private float _moveZ;
    [SerializeField] private float _minPositionX;
    [SerializeField] private float _maxPositionX;
    [SerializeField] private float _recoilForce;

    private Vector3 _newPositionZ;
    private Vector3 _offsetZ;
    private float _startPositionY;

    private void Start()
    {
        _startPositionY = transform.position.y;
    }

    private void Update()
    {
        if (InputManager.IsMoving("Mouse X") && InputManager.IsLeftMouseButtonDown())
        {
            Vector3 newPositionX = transform.position + transform.right * InputManager.GetAxis("Mouse X");
            newPositionX.x = Mathf.Clamp(newPositionX.x, _minPositionX, _maxPositionX);

            transform.position = Vector3.MoveTowards(transform.position, newPositionX, _speedX * Time.deltaTime);
        }

        _newPositionZ = transform.position + transform.forward * _moveZ + _offsetZ;

        transform.position = Vector3.MoveTowards(transform.position, _newPositionZ, _speedZ * Time.deltaTime);
        transform.position = new Vector3(transform.position.x, _startPositionY, transform.position.z);
    }
}
