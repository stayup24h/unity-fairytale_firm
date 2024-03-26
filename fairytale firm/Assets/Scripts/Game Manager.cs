using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class GameManager : Singleton<GameManager>
{
    public static int turn_Count, numberOfMoney, numberOfWood, NumberOfBook; //재화 변수 선언

    public void NextTurn() //다음턴 함수
    {
        turn_Count += 1;
    }
}