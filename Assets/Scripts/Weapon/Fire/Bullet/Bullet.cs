using UnityEngine;

public class Bullet : MonoBehaviour
{
    public float Speed { get; private set; }
    public float BulletRange { get; private set; }

    private float _distanceTravelled;

    private void OnEnable()
    {
        _distanceTravelled = 0f;
    }

    private void Update()
    {
        MoveBullet();
    }

    private void MoveBullet()
    {
        float distanceToMove = Speed * Time.deltaTime;
        transform.Translate(Vector3.forward * distanceToMove);
        _distanceTravelled += distanceToMove;

        CheckDistanceTravelled();
    }

    private void CheckDistanceTravelled()
    {
        if (_distanceTravelled >= BulletRange)
        {
            gameObject.SetActive(false);
        }
    }
    public void Initialize(float speed, float bulletRange)
    {
        Speed = speed;
        BulletRange = bulletRange;
    }
}
