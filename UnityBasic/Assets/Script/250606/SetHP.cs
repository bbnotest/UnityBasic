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
    // �ּ�ü���� 0

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

    public void OnClickDamage() // ������
    {
        Damage = Random.Range(5, 21);

        nowHP -= Damage; // �������� �޴´�.
        if (nowHP < 0) // �׷��� 0���� �������� 0���� �����Ѵ�.
        {
            nowHP = 0;
        }

        Txt_text.text = $"{Damage}�������� �޾Ҵ�!";
        RefreshU();
    }

    public void OnClickHeal() // ȸ��
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
