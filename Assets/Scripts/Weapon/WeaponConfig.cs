using UnityEngine;

[CreateAssetMenu(fileName = "New Weapon", menuName = "Weapon system/Weapon")]
public class WeaponConfig : ScriptableObject
{
    public float FireRate;
    public GameObject BulletPrefab;
    public float BulletSpeed;
    public float Damage;
    public float Range;
}

