using UnityEngine;

public class Enemy : MonoBehaviour
{
    private float _health=100;
    private float _damageValue = 30;

    private Animator animator;
    private void Start()
    {
        animator = GetComponentInChildren<Animator>();
    }
    public void Damage()
    {
        Debug.Log("Enemy damaged");
        
        animator.SetTrigger("Hit");

        _health -= _damageValue;
        Debug.Log(_health);

        if (_health < 0 )
        {
            Destroy(gameObject);
        }
    }

}
