using UnityEngine;

public class Tree : MonoBehaviour,IShootable
{
    [SerializeField] private Animator shakeTree;
    void Awake()
    {
        shakeTree = GetComponent<Animator>();
    }
  
    private void ShakeTree()
    {
        Debug.Log("Tree Shook");
        shakeTree.SetTrigger("Shake");

    }
    public void GetDamage()
    {
        ShakeTree();
    }
}
