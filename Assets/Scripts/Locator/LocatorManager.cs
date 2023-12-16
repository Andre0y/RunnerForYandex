using System.Collections.Generic;
using UnityEngine;

public class LocatorManager : MonoBehaviour
{
    private Dictionary<string, GameObject> _locators = new Dictionary<string, GameObject>();

    private static LocatorManager _instance;

    public static LocatorManager Instance
    {
        get
        {
            if (_instance == null)
            {
                GameObject gameObject = new GameObject("LocatorManager");
                gameObject.AddComponent<LocatorManager>();

                return _instance;
            }
            else
            {
                return _instance;
            }
        }
    }

    private void Awake()
    {
        _instance = this;

        Locator[] locators = FindObjectsOfType<Locator>(true);

        foreach (Locator locator in locators)
        {
            SetLocator(locator.GameObjectName, locator.gameObject);
        }

        DontDestroyOnLoad(gameObject);
    }

    private void SetLocator(string key, GameObject gameObject)
    {
        if (!_locators.ContainsKey(key))
        {
            _locators.Add(key, gameObject);
        }
        else
        {
            _locators[key] = gameObject;
        }
    }

    public GameObject GetLocator(string key)
    {
        if (_locators.TryGetValue(key, out GameObject locator))
        {
            return locator;
        }
        else
        {
            return null;
        }
    }
}
