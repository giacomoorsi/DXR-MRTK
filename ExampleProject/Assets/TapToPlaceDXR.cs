using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TapToPlaceDXR : MonoBehaviour
{

    bool placementInProgress;
    GameObject otherCube;
    Vector3 otherCubeDistance;

    // Start is called before the first frame update
    void Start()
    {
        placementInProgress = false;
        otherCube = GameObject.Find("DxRVis");

        GetComponent<Microsoft.MixedReality.Toolkit.Utilities.Solvers.TapToPlace>().OnPlacingStarted.AddListener(StartPlacement);
        GetComponent<Microsoft.MixedReality.Toolkit.Utilities.Solvers.TapToPlace>().OnPlacingStopped.AddListener(EndPlacement);

    }

    void StartPlacement()
    {
        placementInProgress = true;
        otherCubeDistance = (otherCube.transform.position - transform.position);
        Debug.Log("Placement started!");
        Debug.Log("Other cube distance" + otherCubeDistance.magnitude);
    }
    void EndPlacement()
    {
        placementInProgress = false;
        Debug.Log("Placement stopped!");
    }

    // Update is called once per frame
    void Update()
    {
        if (placementInProgress)
        {
            //otherCube.GetComponent<Renderer>().material.color = Random.ColorHSV(0f, 1f, 1f, 1f, 0.5f, 1f);
            otherCube.transform.position = (transform.position + otherCubeDistance);
            otherCube.transform.rotation = transform.rotation;
            Debug.Log("Distance: " + (transform.position - otherCubeDistance).magnitude);
        }
    }
}
