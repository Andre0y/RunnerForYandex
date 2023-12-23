using UnityEngine;

[CreateAssetMenu(fileName = "BulletData", menuName = "New Bullet Data")]
public class BulletData : ScriptableObject
{
    [SerializeField] private GunData _gunData;
}
