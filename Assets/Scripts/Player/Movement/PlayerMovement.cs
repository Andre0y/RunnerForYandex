using UnityEngine;

public class PlayerMovement : IPlayerMovement
{
    private Transform _playerTransform;

    public PlayerMovement(Transform playerTransform)
    {
        _playerTransform = playerTransform;
    }

    public void Move(Vector3 direction, float speed)
    {
        Vector3 newPosition = _playerTransform.position + direction * speed * Time.deltaTime;
        _playerTransform.position = newPosition;
    }
}

