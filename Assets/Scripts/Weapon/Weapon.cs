using UnityEngine;


public class Weapon : MonoBehaviour
{
    [SerializeField] protected WeaponConfig Config;

    protected WeaponAnimator WeaponAnimator;

    private void Awake()
    {
        Animator animator = GetComponent<Animator>();
        WeaponAnimator = new WeaponAnimator(animator);
    }
}

