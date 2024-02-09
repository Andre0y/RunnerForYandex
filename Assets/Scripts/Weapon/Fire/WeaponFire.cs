using UnityEngine;

public class WeaponFire : Weapon, IFireble
{
    [SerializeField] private ObjectPull _bulletPool;
    [SerializeField] private Transform _firePoint;

    private float fireRateTime;

    private void Update()
    {
        fireRateTime += Time.deltaTime;

        if(CanFire() == true)
        {
            Fire();

            fireRateTime = 0;
        }
    }

    public void Fire()
    {
        WeaponAnimator.PlayFireAnimation();

        GameObject bulletObject = _bulletPool.Get();

   
        Bullet bullet = bulletObject.GetComponent<Bullet>();

        bullet.Initialize(Config.BulletSpeed, Config.BulletRange);
        bullet.transform.position = _firePoint.position;
        bullet.transform.rotation = _firePoint.rotation;
        bulletObject.SetActive(true);
    }

    private bool CanFire()
    {
        return fireRateTime > Config.FireRate;
    }
}

