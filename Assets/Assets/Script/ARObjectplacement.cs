using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.XR.ARFoundation;
using UnityEngine.XR.ARSubsystems;

[RequireComponent(typeof(ARRaycastManager))]
public class ARObjectplacement : MonoBehaviour
{
    public int i;
    public GameObject[] gameObjectToInstantiate;
    public crackerSelect crackerSelect;
    private GameObject spawnedObject;
    private ARRaycastManager raycastManager;
    private Vector2 touchPostion;

    static List<ARRaycastHit> hits = new List<ARRaycastHit>();

    private void Awake()
    {
        crackerSelect = GetComponent<crackerSelect>();
        raycastManager = GetComponent<ARRaycastManager>();
    }

    bool TryGetTouchPostion(out Vector2 touchPostion)
    {
        if (Input.touchCount > 0)
        {
            touchPostion = Input.GetTouch(index: 0).position;
            return true;
        }

        touchPostion = default;
        return false;
    }

    // Update is called once per frame
    void Update()
    {
        if (!TryGetTouchPostion(out Vector2 touchPostion))
            return;

        if (raycastManager.Raycast(touchPostion, hits, TrackableType.PlaneWithinPolygon))
        {
            var hitPos = hits[0].pose;

            if (spawnedObject == null)
            {
                i = crackerSelect.cracketNo;
                spawnedObject = Instantiate(gameObjectToInstantiate[i], hitPos.position, hitPos.rotation);
            }
            else
            {
                spawnedObject.transform.position = hitPos.position;
            }
        }
    }
}
