using UnityEngine;

public class Barrell : MonoBehaviour, IShootable
{
    [SerializeField] private GameObject explosionParticle;

    private void Explode()
    {
        Instantiate(explosionParticle, transform.position, Quaternion.identity);
        Destroy(gameObject);
        Debug.Log("Barrell Exploded");
    }

    public void GetDamage()
    {
        Explode();
    }
}
