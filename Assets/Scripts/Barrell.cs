using Unity.VisualScripting;
using UnityEngine;

public class Barrell : MonoBehaviour, IShootable
{
    [SerializeField] private GameObject explosionParticle;

    public void Start()
    {
        
    }
    public void getdamage()
    {
        Explode();
    }
    private void Explode()
    {
        Debug.Log("Barrell Exploded");
        Destroy(gameObject);
        Instantiate(explosionParticle, transform.position, Quaternion.identity);
    }
}
