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
        GameObject hitObject = hit.collider.gameObject;

        // Check if the object hit is a Barrell
        Barrell barrell = hitObject.GetComponent<Barrell>();
        if (barrell != null)
        {
            barrell.Explode();
            return;
        }

        // Check if the object hit is a Tree
        Tree tree = hitObject.GetComponent<Tree>();
        if (tree != null)
        {
            tree.ShakeTree();
            return;
        }

        // Check if the object hit is an Enemy
        Enemy enemy = hitObject.GetComponent<Enemy>();
        if (enemy != null)
        {
            enemy.Damage();
            return;
        }

        Debug.Log(hitObject.name + "has no valid command");
        Debug.Log(hit.collider.gameObject.name);
    }
}