using UnityEngine;
using UnityEngine.Pool;
using System.Collections.Generic;

public class ObjectPool : MonoBehaviour
{
    //private List<GameObject> pool;
    private ObjectPool<GameObject> pool;
    private const int minSize = 50;
    private const int maxSize = 300;

    private void Awake()
    {
        pool = new ObjectPool<GameObject>(
            CreateObject,
            OnGetObject,
            OnReleaseObject,
            OnDestroyObject,
            true,
            50,
            300
            );
    }

    private GameObject CreateObject()
    {
        GameObject obj = new GameObject();
        return obj;
    }

    private void OnGetObject(GameObject obj)
    {
        obj.SetActive(true);
    }

    private void OnReleaseObject(GameObject obj)
    {
        obj.SetActive(false);
    }

    private void OnDestroyObject(GameObject obj)
    {
        Destroy(obj);
    }


    //void Awake()
    //{
    //    pool = new List<GameObject>();
    //    for (int i = 0; i < minSize; i++)
    //    {

    //        pool.Add(CreateObject());
    //    }
    //}

    //private GameObject CreateObject()
    //{
    //    // [�䱸���� 1] Create Object
    //    GameObject obj = new GameObject();
    //    return obj;
    //}

    //public GameObject GetObject()
    //{
    //    // [�䱸���� 2] Get Object
    //    if (pool.Count > 0)
    //    {
    //        foreach (GameObject gameObject in pool)
    //        {

    //            return gameObject;
    //        }
    //    }

    //    return null;
    //}

    //public void ReleaseObject(GameObject obj)
    //{
    //    // [�䱸���� 3] Release Object
    //    if (pool.Contains(obj))
    //    {
    //        pool.Remove(obj);
    //    }
    //}

}
