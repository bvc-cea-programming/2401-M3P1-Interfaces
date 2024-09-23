using UnityEngine;

public class Enemy : MonoBehaviour
{
    private float _health=100;
    private float _damageValue = 30;
    private Animator Animator;

    private void Start()
    {
        Animator = transform.GetChild(0).GetComponent<Animator>();
        
    }
    public void Damage()
    {
        Debug.Log("Enemy damaged");
        _health -= _damageValue;
        if(_health <= 0)
        {
            Destroy(gameObject);
        }
        Animator.SetTrigger("Hit");

    }

}
