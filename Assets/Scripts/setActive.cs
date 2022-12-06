using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class setActive : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
     
    }

    void View()
    {
        gameObject.SetActive(true);
    }

    void UnView()
    {
        gameObject.SetActive(false);
    }
    public void ToMenu()
    {
        SceneManager.LoadScene(0);
        gameObject.SetActive(false);
    }
}
