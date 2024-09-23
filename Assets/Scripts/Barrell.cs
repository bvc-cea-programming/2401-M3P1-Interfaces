using UnityEngine;

public class Barrell : MonoBehaviour, IShootable
{
    [SerializeField] private GameObject explosionParticle;

    private void Explode()
    {
        // Instantiate the explosion particle effect at the barrell's position
        if (explosionParticle != null)
        {
            Instantiate(explosionParticle, transform.position, Quaternion.identity);
        }
        else
        {
            Debug.LogWarning("Explosion particle not assigned to the barrell!");
        }

        // Destroy the barrell
        Debug.Log("Barrell Exploded");
        Destroy(gameObject);
    }

    // Implement the GetDamage method from IShootable
    public void GetDamage()
    {
        Explode();
    }
}