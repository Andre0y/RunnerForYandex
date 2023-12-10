using TMPro;
using UnityEngine;
using UnityEngine.Events;

public class Enemy : MonoBehaviour
{
    [SerializeField] private int _health;

    private TextMeshProUGUI _textMeshPro;

    public UnityAction<int> BulletHit;
    public int Health => _health;

    private void Start()
    {
        BulletHit += OnBulletHit;
        
        _textMeshPro = GetComponentInChildren<TextMeshProUGUI>();
        _textMeshPro.text = _health.ToString();
    }
    
    private void OnBulletHit(int damage)
    {
        _health -= damage;
        _textMeshPro.text = _health.ToString();
        
        if (_health <= 0)
        {
            Destroy(gameObject);
        }
    }
}
