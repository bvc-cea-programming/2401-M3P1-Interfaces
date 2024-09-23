using UnityEngine;

public class Shooter : MonoBehaviour
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
        Debug.Log(hit.collider.gameObject.name);
        if (hit.collider.GetComponent<Enemy>())
        {
            hit.collider.GetComponent<Enemy>().Damage();
        }
        else if (hit.collider.GetComponent<Tree>())
        {
            hit.collider.GetComponent<Tree>().ShakeTree();
        }
        else if (hit.collider.GetComponent<Barrell>()) 
        {
            hit.collider.GetComponent<Barrell>().Explode();
        }
    }
}
