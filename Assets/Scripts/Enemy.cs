using UnityEngine;

public class Enemy : MonoBehaviour
{
    private float _health=100;
    private float _damageValue = 30;
    private Animator mAnimator;

    public void Damage()
    {
        mAnimator = GetComponentInChildren<Animator>();
        mAnimator.SetTrigger("Hit");
        Debug.Log("Enemy damaged");
        _health -= _damageValue;
        if (_health <= 0)
        {
            Destroy(gameObject);
        }
    }

}
