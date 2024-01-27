using UnityEngine;

[CreateAssetMenu(fileName = "BulletData", menuName = "New Bullet Data")]
public class BulletData : ScriptableObject
{
    public int Damage;
    public int Speed;
    public int LifeTime;

    public void UpgradeDamage(int additiveDamage)
    {
        Damage += additiveDamage;
        Damage = Mathf.Clamp(Damage, 1, int.MaxValue);
    }

    public void UpgradeSpeed(int additiveSpeed)
    {
        Speed += additiveSpeed;
        Speed = Mathf.Clamp(Speed, 20, int.MaxValue);
    }

    public void UpgradeLifeTime(int additiveLifeTime)
    {
        LifeTime += additiveLifeTime;
        LifeTime = Mathf.Clamp(LifeTime, 1, int.MaxValue);
    }
}
