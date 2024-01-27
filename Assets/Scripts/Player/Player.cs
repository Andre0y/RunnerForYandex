using UnityEngine;

public class Player : MonoBehaviour
{
    private void OnTriggerEnter(Collider other)
    {
        if (other.TryGetComponent(out Enemy enemy))
        {
            gameObject.SetActive(false);
            enemy.gameObject.SetActive(false);
        }
    }
}
