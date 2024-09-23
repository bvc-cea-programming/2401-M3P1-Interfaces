using UnityEngine;

public class Tree : MonoBehaviour, IShootable
{
    private Animator animator;

    private void Start()
    {
        animator = GetComponent<Animator>();
    }
    public void GetDamage()
    {
        ShakeTree();
    }
    
    private void ShakeTree()
    {
        Debug.Log("Tree Shook");
        animator.SetTrigger("Shake");
    }
}
