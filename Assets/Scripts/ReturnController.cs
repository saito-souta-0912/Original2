using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;


public class ReturnController : MonoBehaviour
{

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void ReturnScene()
    {
        OdaiController.scoreRecordNumber = 0;
        SceneManager.LoadScene("StartScene");
        
    }

    
}
