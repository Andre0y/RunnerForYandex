using UnityEngine;

public class AddDamageGate : BaseGate
{
    [SerializeField] private int _additiveDamage;

    private GunData _gunData;
    
    protected override void OnTriggerEnter(Collider other)
    {
        if (other.TryGetComponent(out Player player))
        {
            _gunData = player.GetComponentInChildren<GunData>();
            _gunData.UpgradeDamage(_additiveDamage);
        }

        base.OnTriggerEnter(other);
    }
}
