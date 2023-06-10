using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class StartVideoScript : MonoBehaviour
{
    public UnityEngine.Video.VideoPlayer video;
    // Start is called before the first frame update
    void Start()
    {
        video.url = "https://originalgame-videos-simantyu.s3.ap-northeast-1.amazonaws.com/24282023_MotionElements_gradation-background-blue-hd.mov";
        video.prepareCompleted += PrepareCompleted;
        video.errorReceived += ErrorReceived;
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void ErrorReceived(UnityEngine.Video.VideoPlayer vp, string message)
    {
        Debug.LogWarning($"����̓ǂݍ��݂Ɏ��s���܂���. message:{message}");
        vp.errorReceived -= ErrorReceived;
        vp.prepareCompleted -= PrepareCompleted;
        // �G���[������
    }

    //�@����̓ǂݍ��݂�����������Ă΂��
    void PrepareCompleted(UnityEngine.Video.VideoPlayer vp)
    {
        Debug.Log("���惍�[�h����");
        vp.prepareCompleted -= PrepareCompleted;
        vp.Play();
    }
}
