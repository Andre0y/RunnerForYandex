using TMPro;
using UnityEngine;
using UnityEngine.Events;

public class Enemy : MonoBehaviour
{
    [SerializeField] private int _health;

    private TextMeshProUGUI _healthText;

    public UnityAction<int> BulletHit;
    public int Health => _health;

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
}
