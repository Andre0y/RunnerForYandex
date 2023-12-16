using UnityEngine;

public class Gun : MonoBehaviour
{
    [SerializeField] private GunData _gunData;

    private Transform _shootPoint;
    private float _reload;
    private float _firingRange;

    public Transform ShootPoint => _shootPoint;
    public float Reload => _reload;
    public float FiringRange => _firingRange;

    private void Awake()
    {
        Initialize();
    }

    private void Initialize()
    {
        _shootPoint = LocatorManager.Instance.GetLocator(_gunData.ShootPoint).GetComponent<Transform>();
        _reload = _gunData.Reload;
        _firingRange = _gunData.FiringRange;
    }
}
