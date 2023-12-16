using UnityEngine;

[CreateAssetMenu(fileName = "BulletData", menuName = "New Bullet Data")]
public class BulletData : ScriptableObject
{
    public int Damage;
    public int Speed;
    public int LifeTime;

    public int UpgradeDamage(int additiveDamage) => Damage += additiveDamage;

    public int UpgradeSpeed(int additiveSpeed) => Speed += additiveSpeed;

    public int UpgradeLifeTime(int additiveLifeTime) => LifeTime += additiveLifeTime;
}
