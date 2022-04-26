/****************************************************
    文件：LoginSys.cs
	作者：lenovo
    邮箱: 
    日期：2022/4/23 17:27:45
	功能：注册系统
*****************************************************/

using UnityEngine;

public class LoginSys : MonoBehaviour 
{
    public void InitSys()
    {
        Debug.Log("Init Login");
    }

    /// <summary>
    /// 进入登录场景
    /// </summary>
    public void EnterLogin()
    {
        GameRoot.Instance.loadingWnd.gameObject.SetActive(true);
        GameRoot.Instance.loadingWnd.InitWnd();
        ResSvc.Instance.AsyncLoadScene(Constants.sceneLogin);
    }
}