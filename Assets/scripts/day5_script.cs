using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;


public class day5_script : MonoBehaviour
{
    public Sprite Mon_s;
    public Sprite Tue_s;
    public Sprite Wed_s;
    public Sprite Thur_s;
    public Sprite Fri_s;
    Image thisImg;
    int db_5day = 0;
    // Start is called before the first frame update
    void Start()
    {

        thisImg = GetComponent<Image>();

    }


    // Update is called once per frame
    void Update()
    {
        db_5day = GameObject.Find("script").GetComponent<CurrentTime>().day_5_int;

        switch (db_5day)
        {
            case 0:
                {
                    thisImg.sprite = Mon_s;
                    break;
                }

            case 1:
                {
                    thisImg.sprite = Tue_s;
                    break;
                }

            case 2:
                {
                    thisImg.sprite = Wed_s;
                    break;
                }

            case 3:
                {
                    thisImg.sprite = Thur_s;
                    break;
                }

            case 4:
                {
                    thisImg.sprite = Fri_s;
                    break;
                }


        }
    }
}
