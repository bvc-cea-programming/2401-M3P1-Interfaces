using UnityEngine;

public class Tree : MonoBehaviour
{
    private Animator animator;

    private void Start()
    {
        animator = GetComponent<Animator>();
              
    }
    public void ShakeTree()
    {
        Debug.Log("Tree Shook");
        if (animator != null)
        {
            animator.Play("Base Layer.Tree Shake", 0, 0);
        }
    }
}
