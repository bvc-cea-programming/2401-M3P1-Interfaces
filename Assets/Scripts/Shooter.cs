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

        IShootable enemy = hit.collider.gameObject.GetComponent<IShootable>();
        IShootable tree = hit.collider.gameObject.GetComponent<IShootable>();
        IShootable barell = hit.collider.gameObject.GetComponent<IShootable>();


        if (enemy != null)
        {
            enemy.GetDamage();
            return;
        }
        if (tree != null)
        {
            tree.GetDamage();
            return;
        }
        if(barell != null)
        {
            barell.GetDamage();
            return;
        }
    }
}
