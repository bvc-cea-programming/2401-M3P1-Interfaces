using UnityEngine;

public class Barrell : MonoBehaviour
{
    [SerializeField] private GameObject explosionParticle;
    private void Start()
    {
    }
    public void Explode()
    {
        Instantiate(explosionParticle,transform.position,Quaternion.identity);
        Destroy(gameObject);
        Debug.Log("Barrell Exploded");
    }
}
