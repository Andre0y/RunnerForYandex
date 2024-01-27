using UnityEngine;

public class WeaponRecoil : MonoBehaviour
{
    [SerializeField] private float _recoilForce;

    public void Move(float recoilTime, Vector3 direction, ref Vector3 offset)
    {
        offset.z = Mathf.Lerp(offset.z, (offset.z - _recoilForce) * direction.z, recoilTime);
    }
}
