using UnityEngine;

public class AddSpeedGate : BaseGate
{
    [SerializeField] private int _additiveSpeed;

    protected override void OnTriggerEnter(Collider other)
    {
        if (other.TryGetComponent(out Player player))
        {
            BulletData.UpgradeSpeed(_additiveSpeed);
        }

        base.OnTriggerEnter(other);
    }
}
