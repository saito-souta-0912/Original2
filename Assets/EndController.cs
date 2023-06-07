using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class EndController : MonoBehaviour
{
     
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
       if(OdaiController.scoreRecordNumber >= 300000)
       {

           SceneManager.LoadScene("GameGreatScene");
 


       }
       else if(OdaiController.scoreRecordNumber >= 150000)
       {
           SceneManager.LoadScene("GameGoodScene");
    
       }
       else if(OdaiController.scoreRecordNumber >= 50000)
       {
           SceneManager.LoadScene("GameBadScene");
      
       }
       else
       {

           SceneManager.LoadScene("GameMissScene");
         



       }
   }
}

