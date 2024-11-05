using UnityEngine;
using UnityEngine.SceneManagement;

public class ArrowController : MonoBehaviour
{
   

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        Vector2 position = transform.position;
        position.y = position.y - ArrDropController.Speed*Time.deltaTime;
        transform.position = position;
        Debug.Log(transform.position);
        if (transform.position.y < -5.0f)
            SceneManager.LoadScene(2);
    }
}
