using UnityEngine;

public class FinalBlock : MonoBehaviour
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
            _gameRestarter.Restart();
        }
    }
}
