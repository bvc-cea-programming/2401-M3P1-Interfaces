using UnityEngine;

public class Tree : MonoBehaviour, IShootable
{
    private Animator animator;

    public void Start()
    {
        animator = GetComponent<Animator>();
        
    }

    public void getdamage()
    {
        ShakeTree();
    }

    private void ShakeTree()
    {
        animator.SetTrigger("Shake");
        Debug.Log("Tree Shook");
    }
}
