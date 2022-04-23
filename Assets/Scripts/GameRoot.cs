/****************************************************
    文件：GameRoot.cs
	作者：lenovo
    邮箱: 
    日期：2022/4/23 17:24:44
	功能：游戏启动入口
*****************************************************/

using UnityEngine;

public class GameRoot : MonoBehaviour 
{
    void Start()
    {
        Debug.Log("GameStart");

        Init();
    }

    /// <summary>
    /// 控制初始化模块的顺序
    /// </summary>
    void Init()
    {
        ResSvc res = GetComponent<ResSvc>();
        res.InitSvc();

        LoginSys login=GetComponent<LoginSys>();
        login.InitSys();
        login.EnterLogin();

    }
}