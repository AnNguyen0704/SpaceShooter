using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using UnityEngine.SceneManagement;

public class DemGIo : MonoBehaviour
{
    public TextMeshProUGUI timeText;
    float StarTime;
    public float thoiGianKichHoatTinhNang;
    private bool TinhNangDaKichHoat = false;
    // Start is called before the first frame update
    void Start()
    {
        StarTime = Time.time;
    }

    // Update is called once per frame
    void Update()
    {
        float ThoiGianDaTroiQua;
        ThoiGianDaTroiQua = Time.time - StarTime;
        int minutes = (int)ThoiGianDaTroiQua / 60;
        int second = (int)ThoiGianDaTroiQua % 60;
        timeText.text = string.Format("{0:00}:{1:00}", minutes, second);



        
    }
}
