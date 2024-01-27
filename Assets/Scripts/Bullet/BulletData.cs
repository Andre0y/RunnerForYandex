using UnityEngine;

[CreateAssetMenu(fileName = "BulletData", menuName = "New Bullet Data")]
public class BulletData : ScriptableObject
{
    public int Damage;
    public int Speed;
    public int LifeTime;

    public int UpgradeDamage(int additiveDamage) => Mathf.Clamp(Damage += additiveDamage, 1, int.MinValue);

    public int UpgradeSpeed(int additiveSpeed) => Mathf.Clamp(Speed += additiveSpeed, 20, int.MaxValue);

    public int UpgradeLifeTime(int additiveLifeTime) => Mathf.Clamp(LifeTime += additiveLifeTime, 1, int.MaxValue);
}
