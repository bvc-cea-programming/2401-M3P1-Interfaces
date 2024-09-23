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
        if(hit.collider.gameObject.name == "Enemy")
        {
            hit.collider.gameObject.GetComponent<Enemy>().Damage();
        }
        else if(hit.collider.gameObject.name == "Barrell")
        {
            hit.collider.gameObject.gameObject.GetComponent<Barrell>().Explode();
        }
        else if(hit.collider.gameObject.name == "Tree")
        {
            hit.collider.gameObject.GetComponent<Tree>().ShakeTree();
        }
        Debug.Log(hit.collider.gameObject.name);
    }
}
