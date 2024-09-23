using UnityEngine;

public class Shooter : MonoBehaviour, IShootable
{
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
        if (hit.collider.gameObject.GetComponent<IShootable>() != null)
        {
            hit.collider.gameObject.GetComponent<IShootable>().GetDamage();
        }
        Debug.Log(hit.collider.gameObject.name);
    }
}
