using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class ArrayList : MonoBehaviour
{
    public TextMeshProUGUI Txt_Bumin;
    public Button Button;

    public TMP_InputField intput;

    string[] character = { "������", "���ѳ�", "�ռ���", "����ȣ", "������", "������", "������", "������" };
    List<string> characterList = new List<string>();

    public void ArrayGacha() // character.Length
    {
        int randomValue = Random.Range(0, character.Length); // 8 , 0 ~ 7

        Debug.Log("������? " + character[randomValue] + "�� �����ϴ�.");
        Txt_Bumin.text = "������? " + character[randomValue] + "�� �����ϴ�.";
    }

    public void ListGacha() // characterList.Count
    {
        int randomValue = Random.Range(0, characterList.Count);  // 8 , 0 ~ 7
        Txt_Bumin.text = "������? " + characterList[randomValue] + "�� �����ϴ�.";
    }

    public void OnButtonClick(int _num)
    {
        // character �迭���� ��� �̸��� �ֽ��ϴ�.
        // characterList���� �ƹ� �����͵� �����ϴ�.

        // character �迭�� �����͸� charcterList���ٰ� �־��ִ� ���� �����ô�.
        // �츮�� ��� �ݺ����� ����ؼ� ����� ���ô�.

        for(int i = 0; i < character.Length; i++) // i < 8 -> 0 ~ 7
        {
            characterList.Add(character[i]);
        }

        for(int i = 0; i < characterList.Count;i++)
        {
            Debug.Log(characterList[i]);
        }
    }



    private void Start()
    {
        Test();
    }


    int[] arr = { 1, 2, 6, 12, 15, 32 }; 
    int Test() 
    { 
        for (int i = 0; i < arr.Length; i++) 
        { 
            if (arr[i] % 3 == 0) 
            { 
                return arr[i]; 
            } 
        } 

        return 3; 
    }












}
