using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;


public class BuildingSelectScript : MonoBehaviour
{
    public GameObject time_obj;
    public int fin_hour = 0;
    public int fin_minute = 0;
    public int fin_5day = 0;
    public Text out_text;

    public enum Build_Save
    {
        A = 1, //사범대학관
        B, //미술관
        C, //가정관
        D, //생활예술관
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
        
    }

    // Update is called once per frame
    void Update()
    {
        //Debug.Log(MySave);
 
       Time_FINAL();

        DontDestroyOnLoad(this.gameObject);
    }

    public void sel_A()
    {
        MySave = Build_Save.A;
        out_text.text = "A";
    }

    public void sel_G()
    {
        MySave = Build_Save.G;
        out_text.text = "G";
    }

    public void sel_M()
    {
        MySave = Build_Save.M;
        out_text.text = "M";
    }

    public void sel_N() //자하관
    {
        Debug.Log("MySave = N으로 설정되었습니다.");
        MySave = Build_Save.N;
        out_text.text = "N";
    }

    public void sel_T()
    {
        MySave = Build_Save.T;
        out_text.text = "T";

    }

    public void sel_R()
    {
        MySave = Build_Save.R;
        out_text.text = "R";
    }


    public void Time_FINAL()
    {
        fin_hour = time_obj.GetComponent<CurrentTime>().hour;
        //Debug.Log(fin_hour);
        fin_minute = GameObject.Find("script").GetComponent<CurrentTime>().minute;
        // Debug.Log(fin_minute)
        fin_5day = GameObject.Find("script").GetComponent<CurrentTime>().day_5_int;
    }


    public void FIN_Scene()
    {
        if (MySave == Build_Save.N)
            Scene_N();
    }

    public void Scene_N()
    {
        //만약 선택한 건물이 ~라면 코드 입력 필요함
        if(fin_5day == 0)
           SceneManager.LoadScene("N_Mon");
        //if (fin_5day == 1)
        //    SceneManager.LoadScene("N_TUE");
        //if (fin_5day == 2)
        //    SceneManager.LoadScene("N_WED");
        //if (fin_5day == 3)
        //    SceneManager.LoadScene("N_THUR");
        //if (fin_5day == 4)
        //    SceneManager.LoadScene("N_FRI");
    }

}
