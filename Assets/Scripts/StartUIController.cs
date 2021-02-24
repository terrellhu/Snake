using System.Collections;
using System.Collections.Generic;
using UnityEngine.UI;
using UnityEngine;

public class StartUIController : MonoBehaviour
{
    public Text lastText;
    public Text bestText;
    public Toggle blue;
    public Toggle yellow;
    public Toggle border;
    public Toggle noBorder;

    private void Awake()
    {
        lastText.text = "上次：长度" + PlayerPrefs.GetInt("lastl", 0) + "，分数" + PlayerPrefs.GetInt("lasts", 0);
        bestText.text = "最佳：长度" + PlayerPrefs.GetInt("bestl", 0) + "，分数" + PlayerPrefs.GetInt("bests", 0);
    }

    private void Start()
    {
        if(PlayerPrefs.GetString("sh", "sh01") == "sh01")
        {
            blue.isOn = true;
            BlueSelected(blue.isOn);
        }
        else
        {
            yellow.isOn = true;
            YellowSelected(yellow.isOn);
        }
        if (PlayerPrefs.GetInt("border", 1) == 1)
        {
            border.isOn = true;
            BorderSelected(border.isOn);
        }
        else
        {
            noBorder.isOn = true;
            NoBorderSelected(noBorder.isOn);
        }
    }

    public void StartGame()
    {
        UnityEngine.SceneManagement.SceneManager.LoadScene(1);
    }

    public void BlueSelected(bool isOn)
    {
        if (isOn)
        {
            PlayerPrefs.SetString("sh", "sh01");
            PlayerPrefs.SetString("sb01", "sb0101");
            PlayerPrefs.SetString("sb02", "sb0102");
        }
    }
    public void YellowSelected(bool isOn)
    {
        if (isOn)
        {

            PlayerPrefs.SetString("sh", "sh02");
            PlayerPrefs.SetString("sb01", "sb0201");
            PlayerPrefs.SetString("sb02", "sb0202");
        }
    }
    public void BorderSelected(bool isOn)
    {
        if (isOn)
        {
            PlayerPrefs.SetInt("border", 1);
        }
    }
    public void NoBorderSelected(bool isOn)
    {
        if (isOn)
        {
            PlayerPrefs.SetInt("border", 0);
        }
    }
}
