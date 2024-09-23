using UnityEngine;

public class Tree : MonoBehaviour
{
    [SerializeField] private Animator shakeTree;
    private void Start()
    {
        shakeTree = GetComponent<Animator>();
        ShakeTree();
    }
    public void ShakeTree()
    {
        Debug.Log("Tree Shook");
        shakeTree.Play("Base Layer.Tree Shake", 0);

    }
}
