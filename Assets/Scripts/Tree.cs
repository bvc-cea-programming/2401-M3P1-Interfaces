using UnityEngine;

public class Tree : MonoBehaviour
{
    private Animator animator;

    public void Start()
    {
        animator = GetComponent<Animator>();
        
    }

    public void ShakeTree()
    {
        animator.SetTrigger("Shake");
        Debug.Log("Tree Shook");
    }
}
