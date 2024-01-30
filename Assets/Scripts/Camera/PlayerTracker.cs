using UnityEngine;

public class PlayerTracker : MonoBehaviour
{
    [SerializeField] private Vector3 _offset;
    
    private Transform _target;

    private void Start()
    {
        InitializeTarget();
    }

    private void LateUpdate()
    {
        if (_target == null)
            return;

        FollowTarget();
    }

    private void InitializeTarget()
    {
        if(_target == null)
        {
            Player player = FindObjectOfType<Player>();

            if(player != null)
            {
                _target = player.transform;
            }
        }
    }

    private void FollowTarget()
    {
        Vector3 targetPosition = _target.position + _offset;
        targetPosition.x = 0;

        transform.position = targetPosition;
    }
}
