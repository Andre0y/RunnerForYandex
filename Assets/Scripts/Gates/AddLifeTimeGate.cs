using UnityEngine;

public class AddLifeTimeGate : BaseGate
{
    [SerializeField] private int _additiveLifeTime;

    private GunData _gunData;

    protected override void OnTriggerEnter(Collider other)
    {
        if (other.TryGetComponent(out Player player))
        {
            _gunData = player.GetComponentInChildren<GunData>();
            _gunData.UpgradeLifeTime(_additiveLifeTime);
        }

        base.OnTriggerEnter(other);
    }
}
