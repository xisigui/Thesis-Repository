using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

public class AnimationController : MonoBehaviour
{
    public RectTransform BoxRect;

    public UnityEvent onCompleteCallback;

    public void OnEnable()
    {
        BoxRect.transform.localScale = Vector3.zero;
        BoxRect.LeanScale(Vector3.one, 0.2f).setEaseInOutExpo();
    }
}
