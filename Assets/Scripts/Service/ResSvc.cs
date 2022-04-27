/****************************************************
    文件：ResSvc.cs
	作者：lenovo
    邮箱: 
    日期：2022/4/23 17:27:0
	功能：资源服务
*****************************************************/

using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class ResSvc : MonoBehaviour 
{
    public static ResSvc Instance;
    /// <summary>不停查询进度</summary>
    Action prgCB;

    Dictionary<string, AudioClip> adDict = new Dictionary<string, AudioClip>();

    void Update()
    {
        if (prgCB != null)
        {

            prgCB();
        }

    }


    /// <summary>
    /// 初始化服务
    /// </summary>
    public void InitSvc()
    {
        Instance = this;
        Debug.Log("Init Res");
    }


    /// <summary>
    /// 加载场景
    /// </summary>
    /// <param name="sceneName"></param>
    public void AsyncLoadScene(string sceneName,Action loaded)
    {
        GameRoot.Instance.loadingWnd.SetWndState();

        AsyncOperation sceneAsync = SceneManager.LoadSceneAsync(sceneName);

        prgCB = () =>
        {
            float val = sceneAsync.progress;
            LoadingWnd loadingWnd = GameRoot.Instance.loadingWnd;
            loadingWnd.SetProgress(val);

            if (val == 1)
            {
                if (loaded != null)
                { 
                    loaded();
                }

                sceneAsync = null;
                prgCB = null;
                loadingWnd.gameObject.SetActive(false);
            }

        };        
    }

    /// <summary>
    /// 加载声音
    /// </summary>
    /// <param name="path"></param>
    /// <param name="cache">缓存不？</param>
    /// <returns></returns>

    public AudioClip LoadAudio(string path, bool cache = false)
    {
        AudioClip au = null;
        if (adDict.TryGetValue(path, out au) == false)
        {
            au = Resources.Load<AudioClip>(path);
            if (cache)
            {
                adDict.Add(path,au);
            }
        }

  
      
        return au;
    }


}