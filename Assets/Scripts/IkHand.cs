using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class IkHand : MonoBehaviour
{
    public Transform handFrame = null;

    private Animator animator = null;

    private void Start()
    {
        animator = transform.GetComponent<Animator>();
    }

    private void OnAnimatorIK(int layerIndex)
    {
        animator.SetIKPositionWeight(AvatarIKGoal.RightHand, 1.0f);
        animator.SetIKPosition(AvatarIKGoal.RightHand, handFrame.position);
        animator.SetIKRotationWeight(AvatarIKGoal.RightHand, 1.0f);
        animator.SetIKRotation(AvatarIKGoal.RightHand, handFrame.rotation);
    }
}
