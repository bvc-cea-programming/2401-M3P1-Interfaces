using UnityEngine;

public class Tree : MonoBehaviour
{
    private Animator _anim;

    private void Awake()
    {
        _anim = GetComponent<Animator>();
    }
    public void ShakeTree()
    {
        _anim.SetTrigger("Shake");
        Debug.Log("Tree Shook");
    }
}
