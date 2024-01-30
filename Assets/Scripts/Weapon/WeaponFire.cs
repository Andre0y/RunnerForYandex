using UnityEngine;

public class WeaponFire : Weapon, IFireble
{
    private float _fireInterval;
    private float _lastFireTime;

    public void Fire()
    {
        if (CanFire())
        {
            _lastFireTime = Time.time;
            WeaponAnimator.PlayFireAnimation();
        }
    }

    private bool CanFire()
    {
        return Time.time - _lastFireTime >= _fireInterval;
    }
}

