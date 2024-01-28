using UnityEngine;

public class AddDamageGate : BaseGate
{
    [SerializeField] private int _additiveDamage;
    protected override void OnTriggerEnter(Collider other)
    {
        if (other.TryGetComponent(out Player player))
        {
            DataManager.Instance.PlayerInfo.BulletData.UpgradeDamage(_additiveDamage);
            SaveData();
        }

        base.OnTriggerEnter(other);
    }
}
