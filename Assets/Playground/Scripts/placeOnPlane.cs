
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.XR.ARFoundation;
using UnityEngine.XR.ARSubsystems;

[RequireComponent(typeof(ARRaycastManager))]
public class placeOnPlane : MonoBehaviour
{

    [SerializeField] private GameObject prefaToPlace;
    private GameObject placedObject;
    private ARRaycastManager raycastManager;
    private ARPlaneManager _planeManager;
    private List<ARRaycastHit> rcHits = new List<ARRaycastHit>();
    
    void Awake(){
        raycastManager = GetComponent<ARRaycastManager>();
        _planeManager = GetComponent<ARPlaneManager>();
    }
    
    void Update() {
        if (IsMouseClickOnPlane()) {
            LogPlaneInfo();
            HandleClickInteraction();
        }
    }

    private void HandleClickInteraction() {
        var hitPose = rcHits[0].pose;
        if (!IsOnPlane(prefaToPlace)) 
        {
            Instantiate(prefaToPlace, hitPose.position, hitPose.rotation);
        }
    }

    private bool IsOnPlane(GameObject go) {
        Debug.Log("Tag: " + go.tag );
        return GameObject.FindGameObjectsWithTag(go.tag).Length > 0;
    }

    private bool IsMouseClickOnPlane() {
        if (!Input.GetMouseButtonDown(0)) {
            return false;
        }

        if (!raycastManager.Raycast(Input.mousePosition, rcHits, TrackableType.PlaneWithinPolygon)) {
            return false;
        }

        return true;
    }

    // TEMP FOR PLANE DETECTION
    private void LogPlaneInfo() {
        if (_planeManager.trackables.count == 0) {
            return;
        }

        foreach (var plane in _planeManager.trackables) {
            Debug.Log(plane.boundary);
        }
    }

    public void UpdatePrefabToPlace(GameObject obj) {
        Debug.Log("@UpdatePrefab>ToÜPlace + obj.tag: " + obj.tag);
        prefaToPlace = obj;
    }
}
