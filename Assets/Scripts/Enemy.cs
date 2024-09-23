using UnityEngine;

public class Enemy : MonoBehaviour
{
    private float _health=100;
    private float _damageValue = 30;
    public Animator anim;

    public void Start()
    {
        anim = gameObject.transform.GetChild(0).GetComponent<Animator>();
    }

    public void Damage()
    {
        Debug.Log("Enemy damaged");
        anim.SetTrigger("Hit");
        _health = _health - _damageValue;
        if(_health <= 0)
        {
            Destroy(gameObject);
        }
    }

}
