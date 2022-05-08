using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class N201_THUR_script : MonoBehaviour
{
    //N201
    public Sprite change_img;
    public Sprite change_img_R;
    Image thisImg;
    int my_h = 0;

    // Start is called before the first frame update
    void Start()
    {
        my_h = GameObject.Find("script").GetComponent<BuildingSelectScript>().fin_hour;

        thisImg = GetComponent<Image>();

    }

    // Update is called once per frame
    void Update()
    {
        if (my_h >= 8 && my_h < 9)
            ChangeImage_B();
        else if (my_h >= 14 && my_h < 15)
            ChangeImage_B();
        else if (my_h >= 18 && my_h < 22)
            ChangeImage_B();
        else
            ChangeImage_R();
    }

    public void ChangeImage_B()
    {
        thisImg.sprite = change_img;
    }
    public void ChangeImage_R()
    {
        thisImg.sprite = change_img_R;
    }


}
