using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using System;
using System.Net;
using System.IO;
using System.Drawing;


public class goodsounder : MonoBehaviour
{

    public AudioSource introAnmica;

    byte[] anmicaImageByte;

    // Start is called before the first frame update
    void Start()
    {
        anmicaImageByte = ReadFile("Assets/StreamingAssets/goodanmicaa.gif");
        StartCoroutine(GifController());

    }

    // Update is called once per frame
    void Update()
    {

    }

    IEnumerator GifController()
    {
        // Get GIF textures
        yield return StartCoroutine(UniGif.GetTextureListCoroutine(anmicaImageByte, (gifTexList, loopCount, width, height) => { /* Do something */ }));
        introAnmica.Play();
    }

    byte[] ReadFile(string path)
    {
        FileStream fileStream = new FileStream(path, FileMode.Open, FileAccess.Read);
        BinaryReader bin = new BinaryReader(fileStream);
        byte[] values = bin.ReadBytes((int)bin.BaseStream.Length);

        bin.Close();

        return values;
    }

}