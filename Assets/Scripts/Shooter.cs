using UnityEngine;

public class Shooter : MonoBehaviour
{
    IShootable shootableObject;

    private void Update()
    {
        if(Input.GetMouseButtonDown(0))
        {
            Shoot();
        }
    }

    private void Shoot()
    {
        if(Physics.Raycast(Camera.main.ScreenPointToRay(Input.mousePosition),out RaycastHit hit))
        {
            ExecuteCommand(hit);
        }
    }

    private void ExecuteCommand(RaycastHit hit)
    {
        shootableObject = hit.collider.gameObject.GetComponent<IShootable>();

        Debug.Log(hit.collider.gameObject.name);
        if (shootableObject != null)
        {
            shootableObject.GetDamage();
        }
        


    }
}
