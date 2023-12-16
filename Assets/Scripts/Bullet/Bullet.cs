using UnityEngine;

public class Bullet : MonoBehaviour
{
    [SerializeField] private BulletData _bulletData;

    private void Start()
    {
        Destroy(gameObject, _bulletData.LifeTime);
    }

    private void Update()
    {
        Move();
    }

    private void Move()
    {
        transform.Translate(Vector3.forward * Time.deltaTime * _bulletData.Speed);
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.TryGetComponent(out Enemy enemy))
        {
            Destroy(gameObject);
            enemy.BulletHit?.Invoke(_bulletData.Damage);
        }
    }
}
