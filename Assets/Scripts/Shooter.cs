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
        if (hit.collider.gameObject.name == "Barrell")
        {
            hit.collider.gameObject.GetComponent<Barrell>().Explode();
        }
        if (hit.collider.gameObject.name == "Tree")
        {
            hit.collider.gameObject.GetComponent<Tree>().ShakeTree();
        }
        if (hit.collider.gameObject.name == "Enemy")
        {
            hit.collider.gameObject.GetComponent<Enemy>().Damage();
        }
    }
}
