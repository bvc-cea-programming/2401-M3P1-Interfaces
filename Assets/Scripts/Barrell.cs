using UnityEngine;

public class Barrell : MonoBehaviour
{
    [SerializeField] private GameObject explosionParticle;

    public void Explode()
    {
        Instantiate(explosionParticle, transform.position,transform.rotation);
        Destroy(gameObject );

        Debug.Log("Barrell Exploded");
    }
}
