public class WeaponUpgrade : Weapon, IUpgradble
{
    public void UpgradeFireRate(float increment)
    {
        Config.FireRate += increment;
    }

    public void UpgradeBulletSpeed(float increment)
    {
        Config.BulletSpeed += increment;
    }

    public void UpgradeDamage(float increment)
    {
        Config.Damage += increment;
    }

    public void UpgradeRange(float increment)
    {
        Config.BulletRange += increment;
    }
}

