using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class EndController : MonoBehaviour
{
     public static int a = OdaiController.scoreRecordNumber;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void GameOverManager()
   {
       if(a >= 25000)
       {

           SceneManager.LoadScene("GameGreatScene");
           Debug.Log(25000);


       }
       else if(a >= 22000)
       {
           SceneManager.LoadScene("GameGoodScene");
           Debug.Log(22000);
       }
       else if(a >= 17000)
       {
           SceneManager.LoadScene("");
           Debug.Log(17000);
       }
       else if(a >= 10000)
       {
           SceneManager.LoadScene("GameBadScene");
           Debug.Log(10000);
       }
       else
       {

           SceneManager.LoadScene("GameMissScene");
           Debug.Log(00000);



       }
   }
}

