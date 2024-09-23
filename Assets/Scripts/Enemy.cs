using UnityEngine;

public class Enemy : MonoBehaviour, IShootable
{
    private float _health = 100;
    private float _damageValue = 30;

    private Animator animator;

    private void Start()
    {
        animator = GetComponentInChildren<Animator>();
        _health = 100f;
    }

    private void Damage()
    {
        Debug.Log("Enemy damaged");
        if (animator != null)
        {
            animator.Play("Base Layer.Hit To Body", 0, 0);
        }
        _health -= _damageValue;
        if (_health <= 0)
        {
            Debug.Log("died, health at "+ _health);
            Destroy(this.gameObject);
        }
    }

    public void GetDamage()
    {
        Damage();
    }
}
