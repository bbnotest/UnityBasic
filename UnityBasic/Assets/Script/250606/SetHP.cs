using System.Collections;
using System.Collections.Generic;
using System.Security.Cryptography;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class SetHP : MonoBehaviour
{
    public TextMeshProUGUI Txt_HP;
    public TextMeshProUGUI Txt_text;

    public Image Img_HPbar;

    public int MaxHP;
    float nowHP;
    // 최소체력은 0

    int Damage;
    public int HealPoint;

    void Awake()
    {
        nowHP = MaxHP;
        Initialize();
    }

    void Initialize() // Initialize()
    {
        RefreshU();
    }

    public void OnClickDamage() // 데미지
    {
        Damage = Random.Range(5, 21);

        nowHP -= Damage; // 데미지를 받는다.
        if (nowHP < 0) // 그런데 0보다 낮아지면 0으로 고정한다.
        {
            nowHP = 0;
        }

        Txt_text.text = $"{Damage}데미지를 받았다!";
        RefreshU();
    }

    public void OnClickHeal() // 회복
    {
        nowHP += HealPoint;
        if (nowHP > MaxHP)
        {
            nowHP = MaxHP;
        }
        RefreshU();
    }

    void RefreshU() // RefreshUI
    {
        Img_HPbar.fillAmount = nowHP / MaxHP;
        Txt_HP.text = $"{nowHP} / {MaxHP}"; // 50 / 100
    }
}
