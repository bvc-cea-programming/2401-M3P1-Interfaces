using UnityEngine;

public class Barrell : MonoBehaviour
{
    [SerializeField] private GameObject explosionParticle;

    public void Explode()
    {
        Debug.Log("Barrell Exploded");
        Instantiate(explosionParticle, transform.position, Quaternion.identity);
        Destroy(gameObject);
    }
}
