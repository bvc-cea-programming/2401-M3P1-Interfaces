using UnityEngine;

public class Tree : MonoBehaviour
{
    public Animator animator;

    private void Start()
    {
        animator = GetComponent<Animator>();
    }
    public void ShakeTree()
    {
        if (animator != null)
        {
            animator.SetTrigger("Shake");
        }
            
        Debug.Log("Tree Shook");
    }
}
