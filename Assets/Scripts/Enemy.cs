using UnityEngine;
using UnityEngine.Animations;

public class Enemy : MonoBehaviour
{
    private float _health=100;
    private float _damageValue = 30;
    private Animator  _animator;
    private bool isHit;


    private void Start()
    {
        _animator = GetComponent<Animator>();
        _animator.SetBool("Hit",true);
       
    }
   
    public void Damage()
    {
      //  Debug.Log("Enemy damaged");
        _health -= _damageValue;
        if (_health < 0)
        {
            Destroy(gameObject);
            Debug.Log("Enemy destroyed");
        }

    }

}
