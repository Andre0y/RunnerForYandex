using UnityEngine;

public class PlayerShoot : MonoBehaviour
{
    [SerializeField] private Bullet _bullet; 

    private float _timeBetweenShoots;
    private float _timeAfterShoot;
    
    private Vector3 _bulletSpawnPosition;
    private Gun _gun;

    private void Start()
    {
        _gun = GetComponentInChildren<Gun>();
        _bulletSpawnPosition = _gun.ShootPoint.position;

        _timeBetweenShoots = _gun.Reload;
    }

    private void Update()
    {
        Shoot();
    }

    private void Shoot()
    {
        _timeAfterShoot += Time.deltaTime;

        if (_timeAfterShoot >= _timeBetweenShoots)
        {
            Instantiate(_bullet, _bulletSpawnPosition, Quaternion.identity);
            _timeAfterShoot = 0;
        }
    }
}
