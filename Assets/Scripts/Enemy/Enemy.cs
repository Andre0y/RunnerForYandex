using TMPro;
using UnityEngine;
using UnityEngine.Events;

public class Enemy : MonoBehaviour
{
    [SerializeField] private int _health;

    private TextMeshProUGUI _healthText;

    public UnityAction<int> BulletHitted;
    public int Health => _health;

    private void Start()
    {
        _healthText = GetComponentInChildren<TextMeshProUGUI>();
        _healthText.text = _health.ToString();
    }

    private void OnEnable()
    {
        BulletHitted += OnBulletHit;
    }

    private void OnDestroy()
    {
        BulletHitted -= OnBulletHit;
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
