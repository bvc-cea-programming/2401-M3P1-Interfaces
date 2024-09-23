using UnityEngine;

public class Tree : MonoBehaviour
{
    Animator animator;
    public void Start()
    {
        animator = GetComponent<Animator>();
    }
    public void ShakeTree()
    {
        animator.SetTrigger("Shake");
    }
}
