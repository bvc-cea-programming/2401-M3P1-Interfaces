using UnityEngine;

public class Barrell : MonoBehaviour, IShootable
{
    [SerializeField] private GameObject explosionParticle;

    public void GetDamage()
    {
        Explode();
    }
    private void Explode()
    {
        Instantiate(explosionParticle, transform.position, transform.rotation);
        Destroy(gameObject);
        Debug.Log("Barrell Exploded");
    }
}
