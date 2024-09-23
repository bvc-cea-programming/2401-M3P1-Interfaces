using UnityEngine;

public class Tree : MonoBehaviour, IShootable
{
    private Animator animator;

    private void Start()
    {
        animator = GetComponent<Animator>();
              
    }
    private void ShakeTree()
    {
        Debug.Log("Tree Shook");
        if (animator != null)
        {
            animator.Play("Base Layer.Tree Shake", 0, 0);
        }
    }

    public void GetDamage()
    {
        ShakeTree();
    }
}
