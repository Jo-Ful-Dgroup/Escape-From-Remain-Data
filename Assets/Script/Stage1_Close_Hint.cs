using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Stage1_Close_Hint : MonoBehaviour
{
    public GameObject stage1_hint;
    
    public void OnClick()
    {
        stage1_hint.SetActive(false);
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
