using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;


public class BuildingSelectScript : MonoBehaviour
{

    public int s_fin_5day = 0;
    //public Text out_text;


    public Button A_bt;
    public Button G_bt;
    public Button M_bt;
    public Button N_bt;
    public Button T_bt;
    public Button R_bt;



    public enum Build_Save
    {
        A = 1, //사범대학관
        G, //제1공학관
        M, //문화예술대학관(월해관)
        N, //인문사회과학대학관(자하관)
        T, //경영경제대학관(밀레니엄관)
        R //미래백년관
        
    }

    Build_Save MySave = 0;




            // Start is called before the first frame update
    void Start()
    {
        s_fin_5day = GameObject.Find("script").GetComponent<CurrentTime>().day_5_int;
        Debug.Log(s_fin_5day);





    }




    public void sel_A()
    {
        MySave = Build_Save.A;

        //out_text.text = "A";

            //(r, g, b, a) 
            ColorBlock A_cb = A_bt.colors;
            A_cb.selectedColor = new Color(111/255f, 111/255f, 111/255f, 1f);
            A_bt.colors = A_cb;





    }

    public void sel_G()
    {
        MySave = Build_Save.G;
        //out_text.text = "G";

        ColorBlock G_cb = G_bt.colors;
        G_cb.selectedColor = new Color(111 / 255f, 111 / 255f, 111 / 255f, 1f);
        G_bt.colors = G_cb;
    }

    public void sel_M()
    {
        MySave = Build_Save.M;
        //out_text.text = "M";


        ColorBlock M_cb = M_bt.colors;
        M_cb.selectedColor = new Color(111 / 255f, 111 / 255f, 111 / 255f, 1f);
        M_bt.colors = M_cb;

    }

    public void sel_N() //자하관
    {
        Debug.Log("MySave = N으로 설정되었습니다.");
        MySave = Build_Save.N;
        //out_text.text = "N";


        ColorBlock N_cb = N_bt.colors;
        N_cb.selectedColor = new Color(111 / 255f, 111 / 255f, 111 / 255f, 1f);
        N_bt.colors = N_cb;
    }

    public void sel_T()
    {
        MySave = Build_Save.T;
        //out_text.text = "T";


        ColorBlock T_cb = T_bt.colors;
        T_cb.selectedColor = new Color(111 / 255f, 111 / 255f, 111 / 255f, 1f);
        T_bt.colors = T_cb;
    }

    public void sel_R()
    {
        MySave = Build_Save.R;
        //out_text.text = "R";

        ColorBlock R_cb = R_bt.colors;
        R_cb.selectedColor = new Color(111 / 255f, 111 / 255f, 111 / 255f, 1f);
        R_bt.colors = R_cb;
    }



    public void FIN_Scene()
    {
        if (MySave == Build_Save.N)
            Scene_N();
        else if (MySave == Build_Save.A)
            Scene_A();
        else if (MySave == Build_Save.G)
            Scene_G();
        else if (MySave == Build_Save.M)
            Scene_M();
        else if (MySave == Build_Save.R)
            Scene_R();
        else if (MySave == Build_Save.T)
            Scene_T();
    }    


    public void Scene_N()
    {
        Debug.Log(s_fin_5day);
        Debug.Log("s_fin_5day의 값이고 지금 Scene_N 함수 발동함.");
        switch(s_fin_5day)
        {
            case (0):
                Debug.Log("N_MON 씬을 띄워줄게.");
                SceneManager.LoadScene("N_MON");
                break;
            case (1):
                Debug.Log("N_TUE 씬을 띄워줄게.");
                SceneManager.LoadScene("N_TUE");
                break;
            case (2):
                Debug.Log("N_WED 씬을 띄워줄게.");
                SceneManager.LoadScene("N_WED");
                break;
            case (3):
                Debug.Log("N_THUR 씬을 띄워줄게.");
                SceneManager.LoadScene("N_THUR");
                break;
            case (4):
                Debug.Log("N_FRI 씬을 띄워줄게.");
                SceneManager.LoadScene("N_FRI");
                break;
        }
    }

    public void Scene_A()
    {
        Debug.Log(s_fin_5day);
        Debug.Log("s_fin_5day의 값이고 지금 Scene_A 함수 발동함.");
        switch (s_fin_5day)
        {
            case (0):
                Debug.Log("A_MON 씬을 띄워줄게.");
                SceneManager.LoadScene("A_MON");
                break;
            case (1):
                Debug.Log("A_TUE 씬을 띄워줄게.");
                SceneManager.LoadScene("A_TUE");
                break;
            case (2):
                Debug.Log("A_WED 씬을 띄워줄게.");
                SceneManager.LoadScene("A_WED");
                break;
            case (3):
                Debug.Log("A_THUR 씬을 띄워줄게.");
                SceneManager.LoadScene("A_THUR");
                break;
            case (4):
                Debug.Log("A_FRI 씬을 띄워줄게.");
                SceneManager.LoadScene("A_FRI");
                break;
        }
    }

    public void Scene_G()
    {
        Debug.Log(s_fin_5day);
        Debug.Log("s_fin_5day의 값이고 지금 Scene_G 함수 발동함.");
        switch (s_fin_5day)
        {
            case (0):
                Debug.Log("G_MON 씬을 띄워줄게.");
                SceneManager.LoadScene("G_MON");
                break;
            case (1):
                Debug.Log("G_TUE 씬을 띄워줄게.");
                SceneManager.LoadScene("G_TUE");
                break;
            case (2):
                Debug.Log("G_WED 씬을 띄워줄게.");
                SceneManager.LoadScene("G_WED");
                break;
            case (3):
                Debug.Log("G_THUR 씬을 띄워줄게.");
                SceneManager.LoadScene("G_THUR");
                break;
            case (4):
                Debug.Log("G_FRI 씬을 띄워줄게.");
                SceneManager.LoadScene("G_FRI");
                break;
        }
    }

    public void Scene_M()
    {
        Debug.Log(s_fin_5day);
        Debug.Log("s_fin_5day의 값이고 지금 Scene_M 함수 발동함.");
        switch (s_fin_5day)
        {
            case (0):
                Debug.Log("M_MON 씬을 띄워줄게.");
                SceneManager.LoadScene("M_MON");
                break;
            case (1):
                Debug.Log("M_TUE 씬을 띄워줄게.");
                SceneManager.LoadScene("M_TUE");
                break;
            case (2):
                Debug.Log("M_WED 씬을 띄워줄게.");
                SceneManager.LoadScene("M_WED");
                break;
            case (3):
                Debug.Log("M_THUR 씬을 띄워줄게.");
                SceneManager.LoadScene("M_THUR");
                break;
            case (4):
                Debug.Log("M_FRI 씬을 띄워줄게.");
                SceneManager.LoadScene("M_FRI");
                break;
        }
    }

    public void Scene_R()
    {
        Debug.Log(s_fin_5day);
        Debug.Log("s_fin_5day의 값이고 지금 Scene_R 함수 발동함.");
        switch (s_fin_5day)
        {
            case (0):
                Debug.Log("R_MON 씬을 띄워줄게.");
                SceneManager.LoadScene("R_MON");
                break;
            case (1):
                Debug.Log("R_TUE 씬을 띄워줄게.");
                SceneManager.LoadScene("R_TUE");
                break;
            case (2):
                Debug.Log("R_WED 씬을 띄워줄게.");
                SceneManager.LoadScene("R_WED");
                break;
            case (3):
                Debug.Log("R_THUR 씬을 띄워줄게.");
                SceneManager.LoadScene("R_THUR");
                break;
            case (4):
                Debug.Log("R_FRI 씬을 띄워줄게.");
                SceneManager.LoadScene("R_FRI");
                break;
        }
    }

    public void Scene_T()
    {
        Debug.Log(s_fin_5day);
        Debug.Log("s_fin_5day의 값이고 지금 Scene_T 함수 발동함.");
        switch (s_fin_5day)
        {
            case (0):
                Debug.Log("T_MON 씬을 띄워줄게.");
                SceneManager.LoadScene("T_MON");
                break;
            case (1):
                Debug.Log("T_TUE 씬을 띄워줄게.");
                SceneManager.LoadScene("T_TUE");
                break;
            case (2):
                Debug.Log("T_WED 씬을 띄워줄게.");
                SceneManager.LoadScene("T_WED");
                break;
            case (3):
                Debug.Log("T_THUR 씬을 띄워줄게.");
                SceneManager.LoadScene("T_THUR");
                break;
            case (4):
                Debug.Log("T_FRI 씬을 띄워줄게.");
                SceneManager.LoadScene("T_FRI");
                break;
        }
    }

}
