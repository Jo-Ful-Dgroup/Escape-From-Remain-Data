using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Stage1_Button_Uncorrect : MonoBehaviour
{

    public GameObject uncorrect_img;
    public GameObject hintButton;

    public void OnClick()
    {
        uncorrect_img.SetActive(true);
        Invoke("ImgReset", 1.0f);

    }

    void ImgReset()
    {
        uncorrect_img.SetActive(false);
        hintButton.SetActive(true);
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
