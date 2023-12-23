using UnityEngine;

public class AddSpeedGate : BaseGate
{
    [SerializeField] private int _additiveSpeed;

    private GunData _gunData;

    protected override void OnTriggerEnter(Collider other)
    {
        if (other.TryGetComponent(out Player player))
        {
            _gunData = player.GetComponentInChildren<GunData>();
            _gunData.UpgradeSpeed(_additiveSpeed);
        }

        base.OnTriggerEnter(other);
    }
}
