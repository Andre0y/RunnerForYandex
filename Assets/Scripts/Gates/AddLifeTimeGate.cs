using UnityEngine;

public class AddLifeTimeGate : BaseGate
{
    [SerializeField] private int _additiveLifeTime;

    protected override void OnTriggerEnter(Collider other)
    {
        if (other.TryGetComponent(out Player player))
        {
            BulletData.UpgradeLifeTime(_additiveLifeTime);
        }

        base.OnTriggerEnter(other);
    }
}
