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
        //animator = GetComponent<Animator>();
        animator.SetTrigger("Shake");
    }
}
