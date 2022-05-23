using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Video;

public class Video_Controler : MonoBehaviour
{
    public string url;
    public VideoPlayer vidplayer;
    GameObject instructions;

    // Start is called before the first frame update
    void Start()
    {
    vidplayer = GetComponent<VideoPlayer>();
    vidplayer.url = url;
        instructions.SetActive(true);
    }

    // Update is called once per frame
    void Update()
   {
       if (Input.anyKey)
       {
           Play();
       }
       
   }

   void Play()
   {
       vidplayer.Play();
       vidplayer.isLooping = true;
        instructions.SetActive(false);
   }
}

