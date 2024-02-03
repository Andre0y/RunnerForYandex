using TMPro;
using UnityEngine;
using UnityEngine.Events;

public class Enemy_stand : MonoBehaviour
{
    [SerializeField] private GameRestarter _gameRestarter;

    private void OnValidate()
    {
        if (!_gameRestarter)
        {
            _gameRestarter = FindObjectOfType<GameRestarter>();
        }
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.TryGetComponent(out Player player))
        {
            player.gameObject.SetActive(false);
            _gameRestarter.Restart();
        }
    }
}
