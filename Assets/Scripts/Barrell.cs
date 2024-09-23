using UnityEngine;

public class Barrell : MonoBehaviour,IShootable
{
    [SerializeField] private GameObject explosionParticle;

    private void Explode()
    {
        Debug.Log("Barrell Exploded");
        Destroy(gameObject);
        Instantiate(explosionParticle,this.transform.position,Quaternion.identity);
    }
    public void GetDamage()
    {
        Explode();
    }
}
