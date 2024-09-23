using UnityEngine;

public class Enemy : MonoBehaviour
{
    private float _health=100;
    private float _damageValue = 30;


    
    public void Damage()
    {
        Debug.Log("Enemy damaged");
      
    }

}
