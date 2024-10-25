using UnityEngine;

public class Singleton<T> : MonoBehaviour where T : MonoBehaviour
{
    private static T instance;

    public static T Instance
    {
        get
        {
            // get instance of singleton
            if(instance == null)
            {
                instance = (T)FindObjectOfType(typeof(T));
            }

            if(instance == null)
            {
                string tName = typeof(T).ToString();
                var singletonObj = GameObject.Find(tName);
                instance = singletonObj.GetComponent<T>();
                DontDestroyOnLoad(instance);
            }
            else
            {
                Destroy(instance);
            }

            return instance;
        }
    }

    public virtual void Awake()
    {
        // make it as dontdestroyobject
        DontDestroyOnLoad(instance);
    }

}
