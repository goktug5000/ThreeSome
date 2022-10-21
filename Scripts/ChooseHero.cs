using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class ChooseHero : MonoBehaviour
{
    private string heroName;
    private int inLvl;

    private void Awake()
    {
        /*
        int xxx = 0;
        foreach (var gameObj in FindObjectsOfType(typeof(GameObject)) as GameObject[])
        {
            if (gameObj.name == this.gameObject.name.ToString())
            {
                xxx++;
            }
        }

        if (xxx != 1)
        {
            Destroy(this.gameObject);
        }
        else
        {
            DontDestroyOnLoad(gameObject);
        }
        */
    }


    void Start()
    {
        
    }
    public void Hero1()
    {
        heroName = "Savaşçı";
    }
    public void loadNewScreen()
    {

        if (heroName != null)
        {
            inLvl = 0;
            StartCoroutine(waitForSceneLoad("scene_" + inLvl.ToString()));
        }
        

    }
    public void goBackToChoose()
    {
        StartCoroutine(waitForSceneLoad("Choose"));


    }
    IEnumerator waitForSceneLoad(string sceneName)
    {
        SceneManager.LoadScene(sceneName);
        while (SceneManager.GetActiveScene().name != sceneName)
        {
            yield return null;
        }

        Debug.Log("doru yere geçtin");

    }


    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Q))
        {
            goBackToChoose();
        }
    }
}
