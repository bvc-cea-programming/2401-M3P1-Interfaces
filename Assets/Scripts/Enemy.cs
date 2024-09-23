using UnityEngine;

public class Enemy : MonoBehaviour, IShootable
{
    private float _health=100;
    private float _damageValue = 30;
    private Animator _anim;

    private void Awake()
    {
        _anim = GetComponentInChildren<Animator>();
    }

    private void Damage()
    {
        _anim.SetTrigger("Hit");
        _health -= _damageValue;

        if (_health < 0) Destroy(gameObject);
        Debug.Log("Enemy damaged");
    }

    public void GetDamage()
    {
        Damage();
    }
}
