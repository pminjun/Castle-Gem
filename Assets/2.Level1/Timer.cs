using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Timer : MonoBehaviour
{
    public Image image_fill;
    public float time_cooltime = 180.0f;
    private float time_current;
    private float time_start;
    private bool isEnded = true;

    void Start()
    {
        Init_UI();
        Trigger_Skill();
    }

    void Update()
    {
        if (isEnded)
            return;
        Check_CoolTime();
    }

    private void Init_UI()
    {
        image_fill.type = Image.Type.Filled;
        image_fill.fillClockwise = false;
    }

    private void Check_CoolTime()
    {
        time_current = Time.time - time_start;
        if (time_current < time_cooltime)
        {
            Set_FillAmount(time_cooltime - time_current);
        }
        else if (!isEnded)
        {
            End_CoolTime();
        }
    }

    private void End_CoolTime()
    {
        Set_FillAmount(0);
        isEnded = true;
        Debug.Log("Skills Available!");
    }

    private void Trigger_Skill()
    {
        if (!isEnded)
        {
            Debug.Log("Hold On");
            return;
        }

        Reset_CoolTime();
        Debug.Log("Trigger_Skill!");
    }

    private void Reset_CoolTime()
    {
        time_current = time_cooltime;
        time_start = Time.time;
        Set_FillAmount(time_cooltime);
        isEnded = false;
    }
    private void Set_FillAmount(float _value)
    {
        image_fill.fillAmount = _value / time_cooltime;
    }
}
