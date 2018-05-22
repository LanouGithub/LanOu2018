using System.Collections;
using System.Collections.Generic;
using UnityEngine;

/// <summary>
/// 游戏播放器管理类
/// </summary>
public class AudioManager : GameManager<AudioManager>
{
    //保存所有播放器
    Dictionary<string,AudioSource> audioAll;

    //初始化播放器管理类
    protected override void Awake()
    {
        base.Awake();
    }

    /// <summary>
    /// 返回指定的播放器
    /// </summary>
    /// <param 播放器所在游戏物体名="audioNumber"></param>
    /// <returns></returns>
    public AudioSource GameAudio(string audioName)
    {
        foreach (string key in audioAll.Keys)
        {
            if (key == audioName)
            {
                return audioAll[name];
            }
        }
        return null;
    }

    //静音开关
    public void Mute(bool isMute)
    {
        foreach (string key in audioAll.Keys)
        {
            audioAll[key].mute = true;
        }
    }
}
