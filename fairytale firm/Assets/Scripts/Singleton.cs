using UnityEngine;

public class Singleton<T> : MonoBehaviour where T : MonoBehaviour
{
    private static T _instance;

    public static T Instance
    {
        get
        {
            if (_instance == null)
            {
                _instance = (T)FindAnyObjectByType(typeof(T)); // 2

                if(_instance == null)
                {
                    GameObject obj = new GameObject();
                    _instance = obj.AddComponent<T>();
                    obj.name = typeof(T).Name;
                }
            }
            return _instance;
        }
    }

    public virtual void Awake()
    {
        if (_instance == null)
        {
            _instance = this as T;
            DontDestroyOnLoad(this.gameObject);
        }
        else
        {
           Destroy(this.gameObject);
        }
        
    }
}