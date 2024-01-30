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
        transform.Translate(Vector3.up * Time.deltaTime * DataManager.Instance.PlayerInfo.BulletData.Speed);
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.TryGetComponent(out Enemy enemy))
        {
            gameObject.SetActive(false);
            enemy.BulletHit?.Invoke(DataManager.Instance.PlayerInfo.BulletData.Damage);
        }
    }

    private IEnumerator Destroy()
    {
        yield return new WaitForSeconds(DataManager.Instance.PlayerInfo.BulletData.LifeTime);

        gameObject.SetActive(false);
    }
}
