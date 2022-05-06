using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BuildingSelectScript : MonoBehaviour
{
    public GameObject time_obj;
    public int fin_hour = 0;
    public int fin_minute = 0;

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

    public enum Class_color
    {
        blue = 0, //사용 가능
        red = 1 // 사용 불가능
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
    }

    public void sel_B()
    {
        MySave = Build_Save.B;
    }

    public void sel_C()
    {
        MySave = Build_Save.C;
    }
    public void sel_D()
    {
        MySave = Build_Save.D;
    }

    public void sel_G()
    {
        MySave = Build_Save.G;
    }

    public void sel_M()
    {
        MySave = Build_Save.M;
    }

    public void sel_N() //자하관
    {
        MySave = Build_Save.N;
        if( && )
        {

        }
    }

    public void sel_T()
    {
        MySave = Build_Save.T;
    }

    public void sel_R()
    {
        MySave = Build_Save.R;
    }


    public void Time_FINAL()
    {
         fin_hour = time_obj.GetComponent<CurrentTime>().hour;
        //Debug.Log(fin_hour);
        fin_minute = GameObject.Find("script").GetComponent<CurrentTime>().minute;
       // Debug.Log(fin_minute)
    }
}
