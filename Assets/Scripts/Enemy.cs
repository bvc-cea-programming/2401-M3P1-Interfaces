using System.Collections;
using UnityEngine;

public class Enemy : MonoBehaviour,IShootable
{
    private float _health=100;
    private float _damageValue = 30;
    private Animator anim;

    private void Start()
    {
        anim = gameObject.GetComponentInChildren<Animator>();
    }

    public void GetDamage()
    {
        Damage();
    }

    private void Damage()
    {
        anim.SetTrigger("Hit");
        Debug.Log("Enemy damaged");

        _health = (_health - _damageValue);
        Debug.Log($"Health = {_health}");

        if (_health <= 0)
        {
            StartCoroutine(Destroy());
        }
    }

    IEnumerator Destroy()
    {
        yield return new WaitForSeconds(2f);
        Destroy(gameObject);
    }
}
