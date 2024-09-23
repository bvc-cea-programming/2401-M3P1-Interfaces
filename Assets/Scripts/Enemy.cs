using UnityEngine;
using UnityEngine.Animations;

public class Enemy : MonoBehaviour,IShootable
{
    private float _health=100;
    private float _damageValue = 30;
    private Animator  _animator;
    private bool isHit;


    private void Start()
    {
        _animator = GetComponent<Animator>();
    }
   
    private void Damage()
    {
        Debug.Log("Enemy damaged");
        _animator.SetTrigger("Hit");
        _health -= _damageValue;
        if (_health < 0)
        {
            Destroy(gameObject);
            Debug.Log("Enemy destroyed");
        }
    }
    public void GetDamage()
    {
        Damage();
    }

}
