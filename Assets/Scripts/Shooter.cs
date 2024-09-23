using UnityEngine;

public class Shooter : MonoBehaviour
{
    Tree tree;
    Enemy enemy;
    Barrell barrell;

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
        tree = hit.collider.gameObject.GetComponent<Tree>();
        enemy = hit.collider.gameObject.GetComponent<Enemy>();
        barrell = hit.collider.gameObject.GetComponent<Barrell>();

        Debug.Log(hit.collider.gameObject.name);
        if (tree != null)
        {
            tree.ShakeTree();
        }
        else if (enemy != null)
        {
            enemy.Damage();
        } else if (barrell != null)
        {
            barrell.Explode();
        }
    }
}
