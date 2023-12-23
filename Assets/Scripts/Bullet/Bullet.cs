using System.Collections;
using UnityEngine;

public class Bullet : MonoBehaviour
{
    [SerializeField] private BulletData _bulletData;

    private void Start()
    {
        StartCoroutine(Destroy());
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
            gameObject.SetActive(false);
            enemy.BulletHit?.Invoke(_bulletData.Damage);
        }
    }

    private IEnumerator Destroy()
    {
        yield return new WaitForSeconds(_bulletData.LifeTime);

        gameObject.SetActive(false);
    }
}
