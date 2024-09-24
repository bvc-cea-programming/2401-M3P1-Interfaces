using UnityEngine;

public class Tree : MonoBehaviour , IShootable
{
    private Animator mAnimator;

    private void ShakeTree()
    {
        mAnimator = GetComponentInChildren<Animator>();
        mAnimator.SetTrigger("Shake");
        Debug.Log("Tree Shook");
    }
    public void GetDamage()
    {
        ShakeTree();
    }
}
