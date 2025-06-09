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


    // [ 심화 : 업 다운 ]
    
    // 랜덤한 수 1~ 100 사이에 값을 만들고
    // Input Field에 입력된 값이
    // 랜덤한 값보다 크면 "크다" , 작으면 "작다"
    // Count 증가
    // 결과적으로 몇번만에 



    // ------------------- 반복문 테스트를 위한 내용 -------------------

    public void Gacha()
    {
        // [ for문 ]
        for (int i = 0; i < 10; i++) // 변수, 조건, 반복
        {

        }

        // [ while문 ]
        int number = 0; // 변수
        while(number < 10) // 조건
        {

            number++; // 반복
        }
    }



    // ------------------- switch문 테스트를 위한 내용 -------------------

    public int selectNumbe = 5;

    public void GachaSwitch()
    {
        switch(selectNumbe) //
        {
            case 0:
                // 은색 머리 캐릭터가 나온다
                Debug.Log("'은색 머리'을 뽑았다!");
                break;

            case 1:
                // 파란 머리 캐릭터가 나온다
                Debug.Log("'파란 머리'을 뽑았다!");
                break;

            case 2:
                // 분홍 머리 캐릭터가 나온다
                Debug.Log("'분홍 머리'을 뽑았다!");
                break;

            default:
                // 파란 머리 꼬마 캐릭터가 나온다.
                Debug.Log("'파란 머리 꼬마'을 뽑았다!");
                break;
        }
    }

}

