using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using NCMB;

public class Test : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
         NCMBObject testClass = new NCMBObject("TestClass");

        // �I�u�W�F�N�g�ɒl��ݒ�

        testClass["message"] = "Hello, NCMB!";
        // �f�[�^�X�g�A�ւ̓o�^
        testClass.SaveAsync();
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
