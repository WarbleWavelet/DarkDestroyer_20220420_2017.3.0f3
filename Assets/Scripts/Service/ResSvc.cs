/****************************************************
    文件：ResSvc.cs
	作者：lenovo
    邮箱: 
    日期：2022/4/23 17:27:0
	功能：资源服务
*****************************************************/

using System.Collections;
using UnityEngine;
using UnityEngine.SceneManagement;

public class ResSvc : MonoBehaviour 
{



    public static ResSvc Instance;


    /// <summary>
    /// 初始化服务
    /// </summary>
    public void InitSvc()
    {
        Instance = this;
        Debug.Log("Init Res");
    }

    public void AsyncLoadScene(string sceneName)
    {
        SceneManager.LoadSceneAsync(sceneName);
    }

}