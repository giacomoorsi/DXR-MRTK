using System.Collections;
using System.Collections.Generic;
using Microsoft.MixedReality.Toolkit.Input;
using UnityEngine;
using UnityEngine.UI;

public class UnityUIClicker : MonoBehaviour, Microsoft.MixedReality.Toolkit.Input.IMixedRealityTouchHandler
{
    public void OnTouchCompleted(HandTrackingInputEventData eventData)
    {
        Debug.Log("Touch completato su " + gameObject.transform.name);
        GetComponent<Button>().onClick.Invoke();
    
    }

    public void OnTouchStarted(HandTrackingInputEventData eventData)
    {
        //Debug.Log("Touch avviato!!");
    }

    public void OnTouchUpdated(HandTrackingInputEventData eventData)
    {
        //Debug.Log("Touch updated!!");
    }

    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {

    }
}
