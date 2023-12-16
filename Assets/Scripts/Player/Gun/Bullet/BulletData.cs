using UnityEngine;

[CreateAssetMenu(fileName = "BulletData", menuName = "New Bullet Data")]
public class BulletData : ScriptableObject
{
    [SerializeField] private GunData _gunData;

    public int UpgradeDamage(int additiveDamage) => _gunData.Damage += additiveDamage;

    public float UpgradeSpeed(float additiveSpeed) => _gunData.BulletSpeed += additiveSpeed;

    public float UpgradeLifeTime(float additiveFiringRange) => _gunData.FiringRange += additiveFiringRange;
}
