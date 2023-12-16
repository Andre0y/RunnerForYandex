using UnityEngine;

[CreateAssetMenu(fileName = "GunData", menuName = "GunManagment/GunData", order = 1)]
public class GunData : ScriptableObject
{
    public string ShootPointName;
    public float Reload;
    public int Damage;
    public float FiringRange;
    public float BulletSpeed;
}
