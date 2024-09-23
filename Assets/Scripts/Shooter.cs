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

        Barrell barrel = hit.collider.GetComponent<Barrell>();
        if (barrel != null)
        {
            barrel.Explode();
        }

        Tree tree = hit.collider.GetComponent<Tree>();
        if(tree != null)
        {
            tree.ShakeTree();
            return;
        }

        Enemy enemy = hit.collider.GetComponent<Enemy>();
        if (enemy != null)
        {
            enemy.Damage();
        }
    }
}
