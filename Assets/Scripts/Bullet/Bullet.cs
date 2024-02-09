using System.Collections;
using UnityEngine;
using Agava.YandexGames;

public class Bullet : MonoBehaviour
{
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
        transform.Translate(Vector3.up * Time.deltaTime * 15f);
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.TryGetComponent(out Enemy enemy))
        {
            gameObject.SetActive(false);
            enemy.BulletHit?.Invoke(15);
        }
    }

    private IEnumerator Destroy()
    {
        yield return new WaitForSeconds(1);

        gameObject.SetActive(false);
    }
}
