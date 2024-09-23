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
        if(hit.collider.TryGetComponent<Tree>(out Tree tree))
        {
           tree.ShakeTree();
        }

        if (hit.collider.TryGetComponent<Enemy>(out Enemy enemy))
        {
            enemy.Damage();
        }

        if (hit.collider.TryGetComponent<Barrell>(out Barrell barrell))
        {
            barrell.Explode();
        }
        Debug.Log(hit.collider.gameObject.name);
    }
}
