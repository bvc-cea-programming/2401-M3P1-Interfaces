using UnityEngine;

public class Barrell : MonoBehaviour, IShootable
{
    [SerializeField] private GameObject explosionParticle;
    private void Start()
    {
    }
    public void GetDamage()
    {
        Explode();
    }
    private void Explode()
    {
        Instantiate(explosionParticle,transform.position,Quaternion.identity);
        Destroy(gameObject);
        Debug.Log("Barrell Exploded");
    }
}
