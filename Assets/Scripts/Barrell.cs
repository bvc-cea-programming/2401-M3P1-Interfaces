using UnityEngine;

public class Barrell : MonoBehaviour
{
    [SerializeField] private GameObject explosionParticle;

    public void Explode()
    {
        Debug.Log("Barrell Exploded");
        Destroy(gameObject);
        Instantiate(explosionParticle,transform.position,Quaternion.identity);
    }
}
