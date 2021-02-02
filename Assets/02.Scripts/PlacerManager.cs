#pragma warning disable IDE0051, IDE0052, IDE0044
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.XR.ARFoundation;
using UnityEngine.XR.ARSubsystems;

public class PlacerManager : MonoBehaviour
{
    public GameObject warrior;
    private bool isCreated = false;

    private ARRaycastManager raycastManager;
    private List<ARRaycastHit> hits = new List<ARRaycastHit>();
    private GameObject warriorObj;

    void Start()
    {
        raycastManager = GetComponent<ARRaycastManager>();
    }

    void Update()
    {
        if (Input.touchCount == 0) return;

        Touch touch = Input.GetTouch(0);
        //처음 터치가 시작됐을 때 한번 동작하기위서
        if (touch.phase == TouchPhase.Began)
        {
            if (raycastManager.Raycast(touch.position, hits, TrackableType.All))
            {
                if (!isCreated)
                {
                    warriorObj = Instantiate(warrior, hits[0].pose.position, hits[0].pose.rotation);
                    isCreated = true;
                }
                else
                {
                    warriorObj.GetComponent<WarriorCtrl>().MoveWarrior(hits[0].pose.position);
                }
            }
        }      
    }
}
