using UnityEngine;

public class GunModel : MonoBehaviour
{
    [SerializeField] private GunData _gunData;
    [SerializeField] private BulletData _bulletData;
    [SerializeField] private Transform _shootPoint;
    [SerializeField] private float _reload;

    private void Start()
    {
        Initialize();
    }

    private void Initialize()
    {
        _shootPoint = LocatorManager.Instance.GetLocator(_gunData.ShootPointName).GetComponent<Transform>();
        _reload = _gunData.Reload;
    }
}
