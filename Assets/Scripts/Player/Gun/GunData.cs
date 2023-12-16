using UnityEngine;

[CreateAssetMenu(fileName = "GunData", menuName = "GunManagment/GunData", order = 1)]
public class GunData : ScriptableObject
{
    public string ShootPoint;
    public float Reload;
    public float FiringRange;
}
