using Assets.Scripts.ObjectPool;
using System.Collections.Generic;
using UnityEngine;

// Назвать monoPool Который хранит Компоненты PoolObject, в котором есть логика
// активации и деакцивации объека


public class ObjectPull : MonoBehaviour
{
    [SerializeField] private GameObject _prefab;
    [SerializeField] private int _coutObjectStart;

    private Queue<GameObject> _objects = new Queue<GameObject>();

    private void Start()
    {
        Prewarm();
    }

    public void Prewarm()
    {
        for (int i = 0; i < _coutObjectStart; i++)
        {
            CreateObject();
        }
    }
    private GameObject CreateObject()
    {
        GameObject newObj = Instantiate(_prefab);

        _objects.Enqueue(newObj);

        newObj.GetComponent<IPoolObject>()?.Construct(this);
        newObj.GetComponent<IPoolObject>()?.Deactive();

        return newObj;
    }

    public GameObject Get()
    {
        GameObject obj;

        if (_objects.Count == 0)
        {
            obj = CreateObject();
        }
        else
        {
            obj = _objects.Dequeue();
        }

        obj.GetComponent<IPoolObject>()?.Active();

        return obj;
    }

    public void Pull(GameObject obj)
    {
        _objects.Enqueue(obj);
        obj.GetComponent<IPoolObject>()?.Deactive();
    }
}

   

