using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using GoogleMobileAds.Api;

using UnityEngine.SceneManagement;
public class Admob : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        

        MobileAds.Initialize((initStatus) =>
        {
            // SDK initialization is complete
        });
    }


    
    public void LoadScene()
    {
        SceneManager.LoadScene(1);
    }





    
    public void QuitGame()
    {
        Application.Quit();
    }
}
