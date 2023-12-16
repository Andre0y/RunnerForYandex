using UnityEngine;

public class GunModel : MonoBehaviour
{
    [SerializeField] private GunData _gunData;
    
    private Transform _shootPoint;
    private float _reload;
    private int _damage;
    private float _firingRange;
    private float _bulletSpeed;
    
    private void Start()
    {
        Initialize();
    }

    private void Initialize()
    {
        _shootPoint = LocatorManager.Instance.GetLocator(_gunData.ShootPointName).GetComponent<Transform>();
        
        _reload = _gunData.Reload;
        _damage = _gunData.Damage;
        _firingRange = _gunData.FiringRange;
        _bulletSpeed = _gunData.BulletSpeed;
    }
}
