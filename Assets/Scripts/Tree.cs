using UnityEngine;

public class Tree : MonoBehaviour
{
    private Animator mAnimator;

    public void ShakeTree()
    {
        mAnimator = GetComponentInChildren<Animator>();
        mAnimator.SetTrigger("Shake");
        Debug.Log("Tree Shook");
    }
}
