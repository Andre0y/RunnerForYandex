using System.Collections;
using UnityEngine;

public class Bullet : MonoBehaviour
{
    [SerializeField] private GunData _gunData;

    private void Start()
    {
<<<<<<< HEAD:Assets/Scripts/Player/Gun/Bullet/Bullet.cs
        Destroy(gameObject, _gunData.FiringRange);
=======
        StartCoroutine(Destroy());
>>>>>>> 7e9006f972256e3e2900948386b295e96413ce64:Assets/Scripts/Bullet/Bullet.cs
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

    private IEnumerator Destroy()
    {
        yield return new WaitForSeconds(_bulletData.LifeTime);

        gameObject.SetActive(false);
    }
}
