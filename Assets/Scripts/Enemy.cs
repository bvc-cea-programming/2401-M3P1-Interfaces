using UnityEngine;

public class Enemy : MonoBehaviour, IShootable
{
    private float _health=100;
    private float _damageValue = 30;
    Animator _animator;
    private void Start()
    {
     _animator = transform.GetChild(0).GetComponent<Animator>();
    }
    public void GetDamage()
    {
        Damage();
    }
    private void Damage()
    {
        _health -= _damageValue;
        if (_health <= 0)
        {
            Destroy(gameObject);
        }
        _animator.SetTrigger("Hit");
        Debug.Log("Enemy damaged");
    }

}
