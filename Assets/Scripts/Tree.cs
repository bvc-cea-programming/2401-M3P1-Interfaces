using UnityEngine;

public class Tree : MonoBehaviour,IShootable
{
    private Animator anim;

    private void Start()
    {
        anim = GetComponent<Animator>();
    }

    public void GetDamage()
    {
        ShakeTree();
    }

    private void ShakeTree()
    {
        anim.SetTrigger("Shake");
        Debug.Log("Tree Shook");
    }
}
