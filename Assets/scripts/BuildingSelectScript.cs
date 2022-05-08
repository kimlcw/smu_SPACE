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
        A = 1, //������а�
        B, //�̼���
        C, //������
        D, //��Ȱ������
        G, //��1���а�
        M, //��ȭ�������а�(���ذ�)
        N, //�ι���ȸ���д��а�(���ϰ�)
        T, //�濵�������а�(�з��Ͼ���)
        R //�̷�����
        
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

    public void sel_N() //���ϰ�
    {
        Debug.Log("MySave = N���� �����Ǿ����ϴ�.");
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
        //���� ������ �ǹ��� ~��� �ڵ� �Է� �ʿ���
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
