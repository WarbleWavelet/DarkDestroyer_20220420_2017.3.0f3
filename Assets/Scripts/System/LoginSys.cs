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

    public LoginWnd loginWnd;

    public static LoginSys Instance;




    void Start()
    {
        loginWnd = transform.Find("Canvas/LoginWnd").GetComponent<LoginWnd>();
    }
    public void InitSys()
    {
        Instance = this;
        Debug.Log("Init Login");
    }

    /// <summary>
    /// 进入登录场景
    /// </summary>
    public void EnterLogin()
    {

        ResSvc.Instance.AsyncLoadScene(Constants.sceneLogin, () =>{ OpenLoginWnd(); });
    }
    /// <summary>
    /// 打开登录窗口
    /// </summary>
    public void OpenLoginWnd()
    {
        loginWnd.SetWndState();
        AudioSvc.Instance.PlayBg (Constants.BGLogin);
    }
}