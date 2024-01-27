using UnityEngine;

public class AddLifeTimeGate : BaseGate
{
    [SerializeField] private int _additiveLifeTime;

    protected override void OnTriggerEnter(Collider other)
    {
        if (other.TryGetComponent(out Player player))
        {
            BulletData.UpgradeLifeTime(Mathf.Clamp(_additiveLifeTime, 1, int.MaxValue));
        }

        base.OnTriggerEnter(other);
    }
}
