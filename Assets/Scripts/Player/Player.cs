using UnityEngine;

public class Player : MonoBehaviour
{
    [SerializeField] private PlayerShoot _playerShoot;

    private void OnTriggerEnter(Collider other)
    {
        if (other.TryGetComponent(out Enemy enemy))
        {
            _playerShoot.Gun.gameObject.SetActive(false);
            gameObject.SetActive(false);
        }
    }
}
