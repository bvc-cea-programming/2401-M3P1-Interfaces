using UnityEngine;

public class Barrell : MonoBehaviour, IShootable
{
    [SerializeField] private GameObject explosionParticle;

    private void Explode()
    {
        Debug.Log("Barrell Exploded");
        Instantiate(explosionParticle, transform.position, Quaternion.identity);
        Destroy(this.gameObject);
    }

    public void GetDamage()
    {
        Explode();
    }
}
