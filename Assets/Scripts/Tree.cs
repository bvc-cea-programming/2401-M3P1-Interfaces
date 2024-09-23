using UnityEngine;

public class Tree : MonoBehaviour, IShootable
{

    Animator animator;
    public void Start()
    {
        animator = GetComponent<Animator>();
    }
    public void GetDamage()
    {
        ShakeTree();
    }
    private void ShakeTree()
    {
        animator.SetTrigger("Shake");
    }
}
