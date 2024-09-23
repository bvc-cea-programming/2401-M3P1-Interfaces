using UnityEngine;

public class Barrell : MonoBehaviour
{
    [SerializeField] private GameObject explosionParticle;

    public void Explode()
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
}