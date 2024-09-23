using UnityEngine;

public class Tree : MonoBehaviour, IShootable
{
    public Animator anim;


    public void Start()
    {
        anim = GetComponent<Animator>();
    }
    
    public void GetDamage()
    {
        ShakeTree();
    }

    private void ShakeTree()
    {
        Debug.Log("Tree Shook");
        anim.SetTrigger("Shake");
    }
}
