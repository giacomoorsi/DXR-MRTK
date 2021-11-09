using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class ButtonTest : MonoBehaviour
{
    int counter = 0;
    // Start is called before the first frame update
    void Start()
    {
        Button btn = gameObject.GetComponent<Button>();

        btn.onClick.AddListener(Click);
    }

    void Click()
    {
        Debug.Log("Button cliccato");
        gameObject.GetComponentInChildren<Text>().text = counter.ToString();
        counter++;
    }


    // Update is called once per frame
    void Update()
    {
        
    }
}
