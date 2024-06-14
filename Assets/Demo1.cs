using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Demo1 : MonoBehaviour
{
    [SerializeField] private int ageAN;
    [SerializeField] private int ageDung;
    [SerializeField] private int ageKhoa;
    [SerializeField] private int ageTri;
    [SerializeField] private int ageTu;


    [SerializeField] private int ruler;

    [SerializeField] private int month;
    // Start is called before the first frame update
    void Start()
    {
        //demoIfElse();
        //demoIfElse2();
        // demoSwitchCase();
        demoIfElse(ageAN, "AN");
        demoIfElse(ageDung, "Dung");
        demoIfElse(ageKhoa, "Khoa");
        demoIfElse(ageTri, "Tri");
        demoIfElse(ageTu, "Tu");

        
    }

    // Update is called once per frame
    void Update()
    {

    }
    void demoIfElse(int ageStudent, string nameStudent)
    {
        if (ageStudent >= 7 && ageStudent <= 12)// Ân từ 7 tới 12 tuổi là Ân đang học tiểu học
        {
            Debug.Log(nameStudent + " dang hoc tieu hoc");
        }
        else if (ageStudent >= 13 && ageStudent <= 16)// Ân đang  học cấp 2
        {
            Debug.Log(nameStudent + " dang hoc cap 2");
        }
        else if (ageStudent >= 16 && ageStudent <= 18)// Ân đang học cấp 3
        {
            Debug.Log(nameStudent + "dang hoc cap 3");
        }
        else
        {
            Debug.Log(nameStudent + " hoc dai hoc");
        }
    }
    void demoIfElse2()
    {
        if (ruler == 15 || ruler == 20)
        {
            Debug.Log("An se mua cay thuoc nay");
        }
        else if (ruler > 20)
        {
            Debug.Log("An se hoi me");
        }
        else if (ruler == 10)
        {
            Debug.Log("An se di ve");
        }
        else if (ruler != 20)
        {
            Debug.Log("An se mua het");
        }

    }
    void demoSwitchCase()
    {
        switch (month)
        {

            case 1:
                Debug.Log("Day la thang 1");
                break;
            case 2:
                Debug.Log("Day la thang 2");
                break;
            case 3:
                Debug.Log("Day la thang 3");
                break;
                
            case 4:
                Debug.Log("Day la thang 4");
                break;
            case 5:
                Debug.Log("Day la thang 5");
                break;
            case 6:
                Debug.Log("Day la thang 6");
                break;
            case 7:
                Debug.Log("Day la thang 7");
                break;
            case 8:
                if (ageAN > 18)
                {
                    Debug.Log("Me se mua xe may");

                }
                else 
                {
                    Debug.Log("Me se cho di hoc he");
                }
                Debug.Log("Day la thang 8");
                break;
            case 9:
                Debug.Log("Day la thang 9");
                break;
            case 10:
                Debug.Log("Day la thang 10");
                break;
            case 11:
                Debug.Log("Day la thang 11");
                break;
            case 12:
                Debug.Log("Day la thang 12");
                break;
            default:
                Debug.Log("Ban da nhap sai thang");
                break;




        }
    }

}
      
