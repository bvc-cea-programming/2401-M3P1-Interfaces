using System.Threading;
using Unity.VisualScripting;
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


       Enemy enemy = hit.collider.gameObject.GetComponent<Enemy>();

       Tree tree= hit.collider.gameObject.GetComponent<Tree>();

       Barrell barrell= hit.collider.gameObject.GetComponent<Barrell>();

        if (enemy != null)
        {
            enemy.Damage();
            return; 
        }
        if (tree != null)
        {
            tree.ShakeTree();
          
        }
        if (barrell != null)
        {
            barrell.Explode();
          
        }

    }
}
