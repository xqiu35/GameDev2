using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GameManager : MonoBehaviour {

    private static GameManager gameManager;

    void Awake()
    {
        if(gameManager==null)
        {
            gameManager = this;
            DontDestroyOnLoad(this.gameObject);
        }
        else if(gameManager!=this)
        {
            Destroy(this.gameObject);
        }
    }

    void Start()
    {
        initPrivates();
    }

    void initPrivates()
    {
    }

    public static string getSceneName()
    {
        Logger.log("getSenceName");
        Scene scene = SceneManager.GetActiveScene();
        return scene.name;
    }

    public static void loadScene(string senceName)
    {
        Logger.log("loadSence: " + senceName);
        SceneManager.LoadScene(senceName);
    }
}
