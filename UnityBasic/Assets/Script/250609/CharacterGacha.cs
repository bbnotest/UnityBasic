using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CharacterGacha : MonoBehaviour
{
    string[] array = { "°¡", "³ª", "´Ù", };
    List<string> list = new List<string>();

    void Start()
    {
        //list.Add(array[0]);   
        //list.Add(array[1]);
        //list.Add(array[2]);

        for (int i = 0; i < array.Length; i++)
        {
            list.Add(array[i]); // 0 , 1 , 2
        }
    }

    public void SetList()
    {

    }
}
