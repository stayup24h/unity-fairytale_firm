using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : Singleton<GameManager>
{
    public int numberOfTurn, numberOfMoney, numberOfWood, NumberOfBook; //재화 변수 선언

    public void NextTurn() //다음턴 함수
    {
        numberOfTurn += 1;
    }
}