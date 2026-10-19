using UnityEngine;

public class ARTouchInteractor : MonoBehaviour
{
    public Camera arCamera;

    void Update()
    {
        if (Input.touchCount == 0) return;

        Touch touch = Input.GetTouch(0);
        if (touch.phase != TouchPhase.Began) return;

        Ray ray = arCamera.ScreenPointToRay(touch.position);

        if (Physics.Raycast(ray, out RaycastHit hit))
        {
            ARTappable tappable = hit.collider.GetComponent<ARTappable>();

            if (tappable != null)
            {
                tappable.Tap();
            }
        }
    }
}
