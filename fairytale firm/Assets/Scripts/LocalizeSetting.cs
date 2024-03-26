using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using static LocalizeManager;

public class LocalizeSetting : MonoBehaviour
{
    public string textKey;      //0번째 열(영어 데이터)을 기준으로 key를 담을 문자열 선언 
    public string[] dropdownKey;    //만약 text가 아닌 드랍다운일 경우

    private void Start()
    {
        LocalizeChanged();
        LocalizeManager.Instance.LocalizeChanged += LocalizeChanged;
    }

    private void OnDestroy()
    {
        LocalizeManager.Instance.LocalizeChanged -= LocalizeChanged;
    }

    string Localize(string key) //어떤 문자열이 필요하진 key를 매개변수로 받는다 
    {
        int keyIndex = LocalizeManager.Instance.Langs[0].value.FindIndex(x => x.ToLower() == key.ToLower()); //기준이 되는 0번 기준으로 value 탐색 후 keyIndex에 문자열 선언
        return LocalizeManager.Instance.Langs[LocalizeManager.Instance.curLangIndex].value[keyIndex];      //현재 언어 인덱스, value의 key를 기준으로 문자열을 반환한다. 
    }

    void LocalizeChanged()
    {
        if (GetComponent<Text>() != null)
        {
            GetComponent<Text>().text = Localize(textKey);  // Localize의 반환 값으로 텍스트를 바꿔준다.
        }

        else if (GetComponent<Dropdown>() != null)
        {
            Dropdown dropdown = GetComponent<Dropdown>();
            dropdown.captionText.text = Localize(dropdownKey[dropdown.value]);

            for (int i = 0; i < dropdown.options.Count; i++)
            {
                dropdown.options[i].text = Localize(dropdownKey[i]);
            }
        }
    }
}