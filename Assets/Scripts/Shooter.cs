using UnityEngine;

public class Shooter : MonoBehaviour
{
    private void Update()
    {
        if (Input.GetMouseButtonDown(0))
        {
            Shoot();
        }
    }

    private void Shoot()
    {
        if (Physics.Raycast(Camera.main.ScreenPointToRay(Input.mousePosition), out RaycastHit hit))
        {
            ExecuteCommand(hit);
        }
    }
    private void ExecuteCommand(RaycastHit hit)
    {
        // Check if the object hit has the IShootable interface
        IShootable shootable = hit.collider.gameObject.GetComponent<IShootable>();

        if (shootable != null)
        {
            // Call the GetDamage method on the object
            shootable.GetDamage();
        }
        else
        {
            Debug.Log(hit.collider.gameObject.name + " does not have implement IShootable");
        }
    }
}