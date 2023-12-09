using UnityEngine;

public class Gun : MonoBehaviour
{
    [SerializeField] private Transform _shootPoint;
    [SerializeField] private float _reload;
    [SerializeField] private float _firingRange;
    [SerializeField] private float _damage;

    public Transform ShootPoint => _shootPoint;

    public float Damage => _damage;
    public float Reload => _reload;
    public float FiringRange => _firingRange;
}
