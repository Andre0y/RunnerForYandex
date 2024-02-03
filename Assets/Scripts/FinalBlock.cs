using UnityEngine;

public class FinalBlock : MonoBehaviour
{
    public GameObject _next_levl;
    public GameObject _this_levl;
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
            _next_levl.gameObject.SetActive(true);
            _this_levl.gameObject.SetActive(false);
        }
    }
}
