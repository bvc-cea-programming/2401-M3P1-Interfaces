using UnityEngine;

public class Enemy : MonoBehaviour, IShootable
{
    private float _health=100;
    private float _damageValue = 30;
    public Animator animator;
    public void Start()
    {
        animator=GetComponentInChildren<Animator>();
    }
    public void Damage()
    {
       
        if (animator != null)
        {
            animator.SetTrigger("Hit");
           
        }
         _health = _health - _damageValue;
        

        if (_health==0)
        {
            Destroy(gameObject);
        }

        Debug.Log("Enemy damaged");
    }
    public void GetDamage()
    {
        Damage();
    }
}
