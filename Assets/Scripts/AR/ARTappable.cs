using UnityEngine;
using UnityEngine.Events;

public class ARTappable : MonoBehaviour
{
    public UnityEvent onTap;

    public void Tap()
    {
        onTap.Invoke();
    }
}
