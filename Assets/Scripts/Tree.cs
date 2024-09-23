using UnityEngine;

public class Tree : MonoBehaviour
{
    [SerializeField] private Animator shakeTree;
    private void Start()
    {
        shakeTree = GetComponent<Animator>();
        Debug.Log("shakeTree is "+ shakeTree);
        ShakeTree();
    }
    public void ShakeTree()
    {
        Debug.Log("Tree Shook");
        
        //shakeTree.Play();
    }
}
