using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Stage1_Button_Corrext : MonoBehaviour
{

    public GameObject correct_img;

    public GameObject thisQuiz;
    public GameObject nextQuiz;

    public void OnClick()
    {
        correct_img.SetActive(true);
        Invoke("ImgReset", 1.0f);
        //SetNextStage();
    }

    void ImgReset()
    {
        correct_img.SetActive(false);
        SetNextStage();
    }

    void SetNextStage()
    {
        thisQuiz.SetActive(false);
        nextQuiz.SetActive(true);

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
