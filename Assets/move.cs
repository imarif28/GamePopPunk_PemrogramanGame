using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class move : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void StartButton(string scenename)
    {
        SceneManager.LoadScene(scenename);
    }

    public void MemberButton(string scenename)
    {
        SceneManager.LoadScene(scenename);
    }

    public void BackButton(string scenename)
    {
        SceneManager.LoadScene(scenename);
    }

    public void ExitButton(string scenename)
    {
        SceneManager.LoadScene(scenename);
    }
}
