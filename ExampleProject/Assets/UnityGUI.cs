using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class UnityGUI : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        foreach (Transform child in transform)
        {
            Button btn = child.GetComponent<Button>();
            if (btn != null)
            {
                Debug.Log("Trovato bottone" + child.name);
                child.gameObject.AddComponent<UnityUIClicker>();
            }
        }
    }

    // Update is called once per frame
    void Update()
    {

    }
}
