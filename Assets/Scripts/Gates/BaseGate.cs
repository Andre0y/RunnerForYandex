using UnityEngine;

public class BaseGate : MonoBehaviour
{
    protected virtual void OnTriggerEnter(Collider other)
    {
        if (other.TryGetComponent(out Player player))
        {
            gameObject.SetActive(false);
            DataManager.Instance.SaveData();
        }
    }
}
