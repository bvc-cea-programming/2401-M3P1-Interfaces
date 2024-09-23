using UnityEngine;

public class Enemy : MonoBehaviour
{
    private float _health=100;
    private float _damageValue = 30;
    public Animator _animator;

    private void Start()
    {
        _animator = GetComponentInChildren<Animator>();
    }

    public void Damage()
    {
        if (_animator != null)
        {
            _animator.SetTrigger("Hit");
        }

        _health -= _damageValue;

        if (_health < 0)
        {
            Destroy(gameObject);
        }
        Debug.Log("Enemy damaged");
    }

}
