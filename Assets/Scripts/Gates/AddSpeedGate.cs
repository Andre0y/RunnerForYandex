using UnityEngine;

public class AddSpeedGate : BaseGate
{
    [SerializeField] private int _additiveSpeed;

    protected override void OnTriggerEnter(Collider other)
    {
        if (other.TryGetComponent(out Player player))
        {
            DataManager.Instance.PlayerInfo.BulletData.UpgradeSpeed(Mathf.Clamp(_additiveSpeed, 20, int.MaxValue));
        }

        base.OnTriggerEnter(other);
    }
}
