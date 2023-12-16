using UnityEngine;

public class Locator : MonoBehaviour
{
    [SerializeField] private string _gameObjectName;

    public string GameObjectName => _gameObjectName;
}
