using UnityEngine;

public class PlayerTracker : MonoBehaviour
{
    [SerializeField] private Transform _target;
    [SerializeField] private Vector2 _offset;
    [SerializeField] private float _moveSpeed = 4f;

    private void OnValidate()
    {
        if (_target == null)
        {
            _target = GameObject.Find("Player").transform;
        }

        if (_offset == Vector2.zero && _target != null)
        {
            _offset.x = _target.position.z - transform.position.z;
            _offset.y = _target.position.y - transform.position.y;
        }
    }

    private void LateUpdate()
    {
        Vector3 newPosition = new Vector3(0, _target.position.y - _offset.y, _target.position.z - _offset.x);

        transform.position = Vector3.MoveTowards(transform.position,  newPosition, _moveSpeed);
    }
}
