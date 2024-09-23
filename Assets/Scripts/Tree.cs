using UnityEngine;

public class Tree : MonoBehaviour, IShootable
{
    private Animator _anim;

    private void Awake()
    {
        _anim = GetComponent<Animator>();
    }
    private void ShakeTree()
    {
        _anim.SetTrigger("Shake");
        Debug.Log("Tree Shook");
    }

    public void GetDamage()
    {
        ShakeTree();
    }
}
