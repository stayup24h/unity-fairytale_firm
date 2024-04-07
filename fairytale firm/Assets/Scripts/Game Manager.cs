using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class GameManager : Singleton<GameManager>
{
    private string hasSavefile = null; // 데이터 파일 존재 여부
    private int isClearedNE, isClearedTE, isClearedBE, isClearedHE; // 엔딩 클리어 여부
    public GoodsVariable goodsVariable; // 재화 변수
    public NumberVariable numberVariable; // 횟수 변수
    public int productOfGetWood = 3, needOfGetWood = 100;

    public void Save() // 데이터 저장
    {
        hasSavefile = PlayerPrefs.GetString("hasSavefile");
        if (hasSavefile != null) // 데이터 파일이 있으면 변경된 값만 저장
        {
            PlayerPrefs.Save();
        }
        else // 데이터 파일이 없으면 생성
        {
            // 데이터 파일 존재여부 업데이트
            PlayerPrefs.SetString("hasSavefile", "true");
            // 재화 변수 데이터 파일
            PlayerPrefs.SetInt("amountOfMoney", goodsVariable.amountOfMoney);
            PlayerPrefs.SetInt("amountOfWood", goodsVariable.amountOfWood);
            PlayerPrefs.SetInt("amountOfBook", goodsVariable.amountOfBook);
            PlayerPrefs.SetInt("amountOfCow", goodsVariable.amountOfCow);
            // 횟수 변수 데이터 파일
            PlayerPrefs.SetInt("numberOfGetWood", numberVariable.numberOfGetWood);
        }
    }

    public void Load() // 데이터 불러오기
    {
        // 재화 변수 불러오기
        goodsVariable.amountOfMoney = PlayerPrefs.GetInt("amountOfMoney");
        goodsVariable.amountOfWood = PlayerPrefs.GetInt("amountOfWood");
        goodsVariable.amountOfCow = PlayerPrefs.GetInt("amountOfBook");
        goodsVariable.amountOfCow = PlayerPrefs.GetInt("amountOfCow");
        // 횟수 변수 불러오기
        numberVariable.numberOfGetWood = PlayerPrefs.GetInt("numberOfGetWood");
    }

    public void NextTurn() //다음턴 함수
    {
    }

    public void GetWood()
    {
        
    }
}