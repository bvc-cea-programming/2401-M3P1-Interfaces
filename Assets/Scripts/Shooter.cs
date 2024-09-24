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
        if (hit.collider.gameObject.GetComponent<Enemy>() != null)
        {
            Enemy enemy = hit.collider.gameObject.GetComponent<Enemy>();
            enemy.Damage();
        }
        if (hit.collider.gameObject.GetComponent<Barrell>() != null)
        {
            Barrell barrell = hit.collider.gameObject.GetComponent<Barrell>();
            barrell.Explode();
        }
        if (hit.collider.gameObject.GetComponent<Tree>() != null)
        {
            Tree tree = hit.collider.gameObject.GetComponent<Tree>();
            tree.ShakeTree();
        }

    }
}
