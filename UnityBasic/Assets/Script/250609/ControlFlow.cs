using System.Collections;
using System.Collections.Generic;
using UnityEditor.Experimental.GraphView;
using UnityEngine;

public class ControlFlow : MonoBehaviour
{
    int count;

    void Awake()
    {
        count = 0;
    }


    // [ ��ȭ : �� �ٿ� ]
    
    // ������ �� 1~ 100 ���̿� ���� �����
    // Input Field�� �Էµ� ����
    // ������ ������ ũ�� "ũ��" , ������ "�۴�"
    // Count ����
    // ��������� ������� 



    // ------------------- �ݺ��� �׽�Ʈ�� ���� ���� -------------------

    public void Gacha()
    {
        // [ for�� ]
        for (int i = 0; i < 10; i++) // ����, ����, �ݺ�
        {

        }

        // [ while�� ]
        int number = 0; // ����
        while(number < 10) // ����
        {

            number++; // �ݺ�
        }
    }



    // ------------------- switch�� �׽�Ʈ�� ���� ���� -------------------

    public int selectNumbe = 5;

    public void GachaSwitch()
    {
        switch(selectNumbe) //
        {
            case 0:
                // ���� �Ӹ� ĳ���Ͱ� ���´�
                Debug.Log("'���� �Ӹ�'�� �̾Ҵ�!");
                break;

            case 1:
                // �Ķ� �Ӹ� ĳ���Ͱ� ���´�
                Debug.Log("'�Ķ� �Ӹ�'�� �̾Ҵ�!");
                break;

            case 2:
                // ��ȫ �Ӹ� ĳ���Ͱ� ���´�
                Debug.Log("'��ȫ �Ӹ�'�� �̾Ҵ�!");
                break;

            default:
                // �Ķ� �Ӹ� ���� ĳ���Ͱ� ���´�.
                Debug.Log("'�Ķ� �Ӹ� ����'�� �̾Ҵ�!");
                break;
        }
    }

}

