using UnityEngine;

public class Bullet : MonoBehaviour
{
    [SerializeField] private GunData _gunData;

    private void Start()
    {
        Destroy(gameObject, _gunData.FiringRange);
    }

    private void Update()
    {
        Move();
    }

    private void Move()
    {
        transform.Translate(Vector3.forward * Time.deltaTime * _gunData.BulletSpeed);
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.TryGetComponent(out Enemy enemy))
        {
            Destroy(gameObject);
            enemy.BulletHitted?.Invoke(_gunData.Damage);
        }
    }
}
