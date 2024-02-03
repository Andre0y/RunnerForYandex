using UnityEngine;

public class WeaponFire : Weapon, IFireble
{
    [SerializeField] private BulletObjectPool _bulletPool;
    [SerializeField] private Transform _firePoint;

    private float _fireInterval;
    private float _lastFireTime;

    private void Update()
    {
        Fire();
    }

    public void Fire()
    {
        if (CanFire())
        {
            _lastFireTime = Time.time;
            WeaponAnimator.PlayFireAnimation();

            GameObject bulletObject = _bulletPool.Get();
            Bullet bullet = _bulletPool.GetComponent<Bullet>();
            bullet.Initialize(Config.BulletSpeed, Config.BulletRange);
            bullet.transform.position = _firePoint.position;
            bullet.transform.rotation = _firePoint.rotation;
            bulletObject.SetActive(true);
        }
    }

    private bool CanFire()
    {
        return Time.time - _lastFireTime >= _fireInterval;
    }
}

