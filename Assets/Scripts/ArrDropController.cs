using System;
using System.Collections.Generic;
using UnityEngine;
using System.Collections;
using TMPro;
using UnityEngine.UI;

public class ArrDropController : MonoBehaviour
{
    static public float Speed = 2.0f;
    private List<Tuple<GameObject, int>> createdObjects = new List<Tuple<GameObject, int>>();
    public GameObject[] objects; // Mассив объектов, которые будут падать
    public float dropInterval = 2.0f; // Интервал времени между падениями
                                      //objects = [down , left, right, up]

    static public int score = 0;
    void Start()
    { 
        StartCoroutine(DropObjects());
    }

    IEnumerator DropObjects()
    {
        int randCompare = -1;
        while (true)
        {
            yield return new WaitForSeconds(dropInterval);
            int randomIndex;
            do
            {
                randomIndex = UnityEngine.Random.Range(0, objects.Length);
            }
            while (randomIndex == randCompare);
            randCompare = randomIndex;
            GameObject selectedObject = objects[randomIndex];
            Tuple<GameObject, int> tmp = new Tuple<GameObject, int>(Instantiate(selectedObject, new Vector3(3.5f - 8.0f + 3 * randomIndex, 5, 0),
            Quaternion.identity), randomIndex);
            createdObjects.Add(tmp);
        }
    }

    void Update()
    {
        //if (createdObjects.Count != 0 && createdObjects[0] != null)
        //{
        //    for (int i = 0; i < objects.Length; i++)
        //    {
        //        if (Input.GetKeyDown(objectKeys[createdObjects[0].Item2]))
        //        {
        //            Destroy(createdObjects[0].Item1);
        //            createdObjects.RemoveAt(0);
        //        }
        //    }
        //}
    }

    public void OnDownButton()
    {
        if (createdObjects.Count != 0 && createdObjects[0] != null)
        {

             if (createdObjects[0].Item2 == 0 && createdObjects[0].Item1.transform.position.y < -3.0f)
             {
                
                Destroy(createdObjects[0].Item1);
                score++;
                createdObjects.RemoveAt(0);
             }
      
        }
    }

    public void OnLeftButton()
    {
        if (createdObjects.Count != 0 && createdObjects[0] != null)
        {

            if (createdObjects[0].Item2 == 1 && createdObjects[0].Item1.transform.position.y < -3.0f)
            {
                
                Destroy(createdObjects[0].Item1);
                score++;
                createdObjects.RemoveAt(0);
            }

        }
    }

    public void OnRightButton()
    {
        if (createdObjects.Count != 0 && createdObjects[0] != null)
        {

            if (createdObjects[0].Item2 == 2 && createdObjects[0].Item1.transform.position.y < -3.0f)
            {
                
                Destroy(createdObjects[0].Item1);
                score++;
                createdObjects.RemoveAt(0);
            }

        }
    }

    public void OnUpButton()
    {
        if (createdObjects.Count != 0 && createdObjects[0] != null)
        {

            if (createdObjects[0].Item2 == 3 && createdObjects[0].Item1.transform.position.y < -3.0f)
            {
                
                Destroy(createdObjects[0].Item1);
                score++;
                createdObjects.RemoveAt(0);
            }

        }
    }

}