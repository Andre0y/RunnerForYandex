using Assets.Scripts.ObjectPool;
using UnityEngine;
using UnityEngine.Pool;

public class Bullet : MonoBehaviour, IPoolObject
{
  

    public float Speed { get; private set; }
    public float BulletRange { get; private set; }
   
    private ObjectPull objectPull;

    private float _distanceTravelled;

    public void Active() // Замена Start
    {
        _distanceTravelled = 0f;
        gameObject.SetActive(true);
    }

    public void Deactive() // Замена OnDestory
    {
        gameObject.SetActive(false);
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
            objectPull.Pull(gameObject);
        }
    }
    public void Initialize(float speed, float bulletRange)
    {
        Speed = speed;
        BulletRange = bulletRange;
    }

    public void Construct(ObjectPull objectPull)
    {
        this.objectPull = objectPull;
    }
}
