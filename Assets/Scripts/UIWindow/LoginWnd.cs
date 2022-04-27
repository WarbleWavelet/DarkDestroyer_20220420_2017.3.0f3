/****************************************************
    文件：LoginWnd.cs
	作者：lenovo
    邮箱: 
    日期：2022/4/26 20:13:17
	功能：
*****************************************************/

using UnityEngine;
using UnityEngine.UI;

public class LoginWnd : WindowRoot
{
    public InputField iptAcct;
    public InputField iptPass;
    /// <summary>公告</summary>
    public Button btnNotice;
    public Button btnEnter;


     void Start()
    {
        btnNotice=transform.Find("btnNotice").GetComponent<Button>();
        iptAcct = transform.Find("rightPin/iptbg1/iptAcct").GetComponent<InputField>();
        iptPass = transform.Find("rightPin/iptbg2/iptPass").GetComponent<InputField>();
        btnEnter = transform.Find("rightPin/btnEnter").GetComponent<Button>();

    }
    protected override void InitWnd()
    {
        base.InitWnd();
        if (PlayerPrefs.HasKey("Acct") && PlayerPrefs.HasKey("Pass"))
        {
            iptAcct.text=PlayerPrefs.GetString("Acct");
            iptPass.text = PlayerPrefs.GetString("Pass");
        }
        else
        {
            iptAcct.text = "";
            iptPass.text = "";
        }
    }

}