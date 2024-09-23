using UnityEngine;

public class Barrell : MonoBehaviour
{
    [SerializeField] private GameObject explosionParticle;

    public void Explode()
    {

        Instantiate(explosionParticle, transform.position,Quaternion.identity);
        Destroy(gameObject);

        Debug.Log("Barrell Exploded");
    }
}
