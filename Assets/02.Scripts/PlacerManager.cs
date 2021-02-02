using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.XR.ARFoundation;
using UnityEngine.XR.ARSubsystems;

public class PlacerManager : MonoBehaviour
{
    public GameObject warrior;
    private bool isCreated = false;

    private List<ARRaycastHit> hits = new List<ARRaycastHit>();
    
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
