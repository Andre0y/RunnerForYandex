using UnityEngine;

public class AddDamageGate : BaseGate
{
    [SerializeField] private int _additiveDamage;
    protected override void OnTriggerEnter(Collider other)
    {
        if (other.TryGetComponent(out Player player))
        {
            BulletData.UpgradeDamage(Mathf.Clamp(_additiveDamage, 1, int.MaxValue));
        }

        base.OnTriggerEnter(other);
    }
}
