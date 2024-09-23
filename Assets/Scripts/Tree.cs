using UnityEngine;

public class Tree : MonoBehaviour
{
    // Reference to the Animator component
    private Animator treeAnimator;

    private void Start()
    {
        // Get the Animator component attached to this tree
        treeAnimator = GetComponent<Animator>();
    }

    public void ShakeTree()
    {
        // Trigger the "Shake" animation using the Animator
        if (treeAnimator != null)
        {
            treeAnimator.SetTrigger("Shake");
        }
        else
        {
            Debug.LogWarning("Animator not found on this tree!");
        }

        Debug.Log("Tree Shook");
    }
}