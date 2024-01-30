using UnityEngine;

public class WeaponAnimator
{
    private Animator _animator;

    private static readonly int FireHash = Animator.StringToHash("Fire");

    public WeaponAnimator(Animator animator)
    {
        _animator = animator;
    }

    public void PlayFireAnimation()
    {
        if (_animator != null)
        {
            _animator.SetTrigger(FireHash);
        }
    }
}

