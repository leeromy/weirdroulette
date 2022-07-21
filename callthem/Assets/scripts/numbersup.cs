using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class numbersup : MonoBehaviour
{ int scoreNum = 0;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space))
        {
        }
        int v = scoreNum++;
        this.GetComponent
            <Text>().text
        = "Score :" + scoreNum;
         
    }
}
