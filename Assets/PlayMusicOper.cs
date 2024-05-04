using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayMusicOper : MonoBehaviour
{
    [System.Serializable]
    public struct BgmType
    {
        public string name;
        public AudioClip audio;
    }
    int i;

    // Inspector 에표시할 배경음악 목록
    public BgmType[] BGMList;

    private AudioSource BGM;
    private string NowBGMname = "";

    void Start()
    {
        BGM = gameObject.AddComponent<AudioSource>();
        BGM.loop = true;
        if (BGMList.Length > 0) PlayBGM(BGMList[0].name);
    }

    void Update()
    {
        i++;
        if(i>=100)
        {
            if (MeditationButton.touch == 1)
            {
                PlayBGM(BGMList[1].name);
            }
            else
            {
                PlayBGM(BGMList[0].name);
            }
        }
    }

    public void PlayBGM(string name)
    {
        if (NowBGMname.Equals(name)) return;

        for (int i = 0; i < BGMList.Length; ++i)
            if (BGMList[i].name.Equals(name))
            {
                BGM.clip = BGMList[i].audio;
                BGM.Play();
                NowBGMname = name;
            }
    }
}