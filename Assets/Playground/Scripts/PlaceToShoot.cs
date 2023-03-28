using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.XR.ARFoundation;
using UnityEngine.XR.ARSubsystems;

[RequireComponent(typeof(ARRaycastManager))]
public class PlaceToShoot : MonoBehaviour
{
    [SerializeField] private GameObject prefabToPlace;
    private List<String> placedPrefabList = new List<string>();
    private ARRaycastManager arRaycastManager;
    private List<ARRaycastHit> rcHits = new List<ARRaycastHit>();
    private GameObject objectToReplace;

    private void Awake()
    {
        arRaycastManager = GetComponent<ARRaycastManager>();
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.touchCount > 0)
        {
            HandlePlaneInteraction(Input.GetTouch(0).position);
        }

        if (Input.GetMouseButtonDown(0))
        {
            HandlePlaneInteraction(Input.mousePosition);
        }
    }

    private void HandlePlaneInteraction(Vector3 touchPos)
    {
        RaycastHit hit;
        Ray ray = Camera.main.ScreenPointToRay(touchPos);

        if (Physics.Raycast(ray, out hit))
        {
            Debug.Log("hit.collider.gameObject.name: " + hit.collider.gameObject.name);
            if (!hit.collider.gameObject.name.Contains("ARPlane"))
            {
                Debug.Log("!!!!   hit.collider.gameObject.name.Contains('ARPlane'): " +
                          hit.collider.gameObject.name.Contains("ARPlane"));
            }
            else if (arRaycastManager.Raycast(touchPos, rcHits, TrackableType.PlaneWithinPolygon))
            {
                var hitPos = rcHits[0].pose;

                if (!placedPrefabList.Contains(prefabToPlace.name))
                {   
                    Debug.Log("@ Place To Shoot with !placedPrefabList.Contains(prefabToPlace.name)");
                    GameObject instantiatedObj = Instantiate(prefabToPlace, hitPos.position, hitPos.rotation);
                    placedPrefabList.Add(prefabToPlace.name);
                }
                else if (prefabToPlace.name  == "Cannon")
                {   
                    Debug.Log( "@ PlaceToShoot else if (prefabToPlace.name + '(Clone)' == 'Cannon(clone)')");
                    objectToReplace = GameObject.Find(prefabToPlace.name + "(Clone)");
                    Destroy(objectToReplace);
                    placedPrefabList.Remove(prefabToPlace.name);
                    GameObject instantiatedObj = Instantiate(prefabToPlace, hitPos.position, hitPos.rotation);
                    placedPrefabList.Add(prefabToPlace.name);
                }
                else
                {
                    objectToReplace = GameObject.Find(prefabToPlace.name + "(Clone)");
                    objectToReplace.transform.position = hitPos.position;
                }
            }
        }
    }

    private void OnDestroyGameObject()
    {
        
    }

    public void UpdatePrefab(GameObject newPrefab)
        {
            Debug.Log("UpdatePrefab(GameObject newPrefab.tag) + newPr: " + newPrefab.tag);
            prefabToPlace = newPrefab;
        }
    
    
}



