using Microsoft.MixedReality.Toolkit.Utilities.Solvers;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DXRTapToPlace : MonoBehaviour
{
    private TapToPlace taptoplaceParent;
    private GameObject parent;
    // Start is called before the first frame update
    void Start()
    {
        parent = gameObject.transform.parent.gameObject;
       // taptoplaceParent = parent.AddComponent<TapToPlace>();
    }

    // Update is called once per frame
    void Update()
    {
        /*
        if (Input.GetKeyDown(KeyCode.U))
        {
            taptoplaceParent.StartPlacement();
        }
        if (Input.GetKeyDown(KeyCode.I))
        {
            taptoplaceParent.StopPlacement();
        }*/
    }
}
