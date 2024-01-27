using TMPro;
using UnityEngine;
using UnityEngine.Events;

public class Enemy : MonoBehaviour
{
    [SerializeField] private int _health;
    [SerializeField] private GameRestarter _gameRestarter;

    private TextMeshProUGUI _healthText;

    public UnityAction<int> BulletHit;
    public int Health => _health;

    private void OnValidate()
    {
        if (!_gameRestarter)
        {
            _gameRestarter = FindObjectOfType<GameRestarter>();
        }
    }

    private void Start()
    {
        _healthText = GetComponentInChildren<TextMeshProUGUI>();
        _healthText.text = _health.ToString();
    }

    private void OnEnable()
    {
        BulletHit += OnBulletHit;
    }

    private void OnDestroy()
    {
        BulletHit -= OnBulletHit;
    }

    private void OnBulletHit(int damage)
    {
        TakeDamage(damage);
        
        if (_health <= 0)
        {
            Destroy(gameObject);
        }
    }

    private void TakeDamage(int amount)
    {
        _health -= amount;
        _healthText.text = _health.ToString();
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.TryGetComponent(out Player player))
        {
            gameObject.SetActive(false);
            player.gameObject.SetActive(false);
            _gameRestarter.Restart();
        }
    }
}
