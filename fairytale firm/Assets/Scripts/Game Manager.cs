using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : Singleton<GameManager>
{
    public int numberOfMoney, numberOfWood, NumberOfBook; //재화 변수 선언
    public int countOfTurn; 

    public int productOfGetWood = 3, needOfGetWood = 100;

    public void NextTurn() //다음턴 함수
    {
        numberOfTurn += 1;
    }

    public void GetWood()
    {
        numberOfMoney -= needOfGetWood;
        numberOfWood += productOfGetWood;
    }
}