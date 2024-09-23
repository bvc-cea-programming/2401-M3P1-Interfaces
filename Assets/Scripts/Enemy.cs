using UnityEngine;

public class Enemy : MonoBehaviour
{
    private float _health=100;
    private float _damageValue = 30;
    private Animator _anim;

    private void Awake()
    {
        _anim = GetComponentInChildren<Animator>();
    }

    public void Damage()
    {
        _anim.SetTrigger("Hit");
        _health -= _damageValue;

        if (_health < 0) Destroy(gameObject);
        Debug.Log("Enemy damaged");
    }

}
