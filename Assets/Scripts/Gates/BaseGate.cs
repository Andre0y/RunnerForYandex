using UnityEngine;

public class BaseGate : MonoBehaviour
{
    [SerializeField] protected BulletData BulletData;

    protected virtual void OnTriggerEnter(Collider other)
    {
        if (other.TryGetComponent(out Player player))
        {
            gameObject.SetActive(false);
        }
    }
}
