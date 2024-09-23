using UnityEngine;

public class Tree : MonoBehaviour
{
    private Animator anim;

    private void Start()
    {
        anim = GetComponent<Animator>();
    }
    public void ShakeTree()
    {
        anim.SetTrigger("Shake");
        Debug.Log("Tree Shook");
    }
}
