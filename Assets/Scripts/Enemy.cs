using UnityEngine;

public class Enemy : MonoBehaviour
{
    private float _health = 100;
    private float _damageValue = 30;

    // Reference to the Animator component
    private Animator enemyAnimator;

    private void Start()
    {
        // Get the Animator component attached to the "Character" child object
        enemyAnimator = GetComponentInChildren<Animator>();
    }

    public void Damage()
    {
        // Trigger the "Hit" animation using the Animator
        if (enemyAnimator != null)
        {
            enemyAnimator.SetTrigger("Hit");
        }
        else
        {
            Debug.LogWarning("Animator not found on the enemy!");
        }

        // Reduce health
        _health -= _damageValue;
        Debug.Log("Enemy Health: " +  _health);

        // Destroy the enemy if health is below or equal to zero
        if (_health <= 0)
        {
            Debug.Log("Enemy destroyed");
            Destroy(gameObject);
        }

        Debug.Log("Enemy damaged");
    }
}