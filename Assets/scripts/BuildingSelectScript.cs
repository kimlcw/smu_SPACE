using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BuildingSelectScript : MonoBehaviour
{
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

    public void sel_N()
    {
        MySave = Build_Save.N;
    }

    public void sel_T()
    {
        MySave = Build_Save.T;
    }

    public void sel_R()
    {
        MySave = Build_Save.R;
    }
}
