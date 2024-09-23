using UnityEngine;

public class Tree : MonoBehaviour
{
    public Animator anim;


    public void Start()
    {
        anim = GetComponent<Animator>();
    }

    public void ShakeTree()
    {
        Debug.Log("Tree Shook");
        anim.SetTrigger("Shake");
    }
}
