using System.Collections.Generic;
using UnityEngine;

public class BulletObjectPool : MonoBehaviour
{
    [SerializeField] private Bullet _bulletPrefab;
    [SerializeField] private int _countAddedObjectsToPool;

    private Queue<GameObject> _objects = new Queue<GameObject>();

    private void AddObjects(int count)
    {
        for (int i = 0; i < count; i++)
        {
            Bullet newBullet = Instantiate(_bulletPrefab);
            newBullet.gameObject.SetActive(false);
            _objects.Enqueue(newBullet.gameObject);
            newBullet.transform.SetParent(transform);
        }
    }

    public GameObject Get()
    {
        if(_objects.Count == 0)
        {
            AddObjects(_countAddedObjectsToPool);
        }

        return _objects.Dequeue();
    }

    public void ReturnToPull(GameObject objectToReturn)
    {
        objectToReturn.SetActive(false);
        _objects.Enqueue(objectToReturn);
    }
}

