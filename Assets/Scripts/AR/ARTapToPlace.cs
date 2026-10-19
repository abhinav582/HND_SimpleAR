using System.Collections.Generic;
using UnityEngine;
using UnityEngine.XR.ARFoundation;
using UnityEngine.XR.ARSubsystems;

public class ARTapToPlace : MonoBehaviour
{
    public ARRaycastManager raycastManager;
    public ARPlaneManager planeManager;

    [Header("Game To Place")]
    public GameObject gamePrefab;

    private GameObject placedGame;
    private static List<ARRaycastHit> hits = new List<ARRaycastHit>();

    void Update()
    {
        if (Input.touchCount == 0) return;

        Touch touch = Input.GetTouch(0);
        if (touch.phase != TouchPhase.Began) return;

        if (placedGame != null) return;

        if (raycastManager.Raycast(touch.position, hits, TrackableType.PlaneWithinPolygon))
        {
            Pose hitPose = hits[0].pose;
            placedGame = Instantiate(gamePrefab, hitPose.position, hitPose.rotation);
            HidePlanes();
        }
    }

    void HidePlanes()
    {
        foreach (ARPlane plane in planeManager.trackables)
        {
            plane.gameObject.SetActive(false);
        }

        planeManager.enabled = false;
    }

    public void ResetGame()
    {
        if (placedGame != null)
        {
            Destroy(placedGame);
        }

        planeManager.enabled = true;

        foreach (ARPlane plane in planeManager.trackables)
        {
            plane.gameObject.SetActive(true);
        }
    }
}
