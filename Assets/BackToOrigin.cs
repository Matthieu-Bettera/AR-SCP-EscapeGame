using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class BackToOrigin : MonoBehaviour
{
    public string scene;
    public float timer;

    public bool IsStart;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        timer += Time.deltaTime;

        if (timer >= 8 && IsStart == false)
        {
            SceneManager.LoadScene(scene);
        }
        if (timer >= 4 && IsStart == true)
        {
            Destroy(gameObject);
        }
    }
}
