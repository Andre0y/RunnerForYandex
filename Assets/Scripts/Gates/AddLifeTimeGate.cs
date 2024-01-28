using UnityEngine;

public class AddLifeTimeGate : BaseGate
{
    [SerializeField] private int _additiveLifeTime;

    protected override void OnTriggerEnter(Collider other)
    {
        if (other.TryGetComponent(out Player player))
        {
            DataManager.Instance.PlayerInfo.BulletData.UpgradeLifeTime(_additiveLifeTime);
            SaveData();
        }

        base.OnTriggerEnter(other);
    }
}
