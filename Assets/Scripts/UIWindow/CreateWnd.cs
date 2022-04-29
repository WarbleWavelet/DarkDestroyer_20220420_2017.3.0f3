/****************************************************
    文件：CreateWnd.cs
	作者：lenovo
    邮箱: 
    日期：2022/4/28 19:2:45
	功能：
*****************************************************/

using System;
using UnityEngine;

public class CreateWnd : WindowRoot
{
    protected override void InitWnd()
    {
        base.InitWnd();
        GameRoot.AddTips("进入CreateWnd");
        RandPlayerName();
    }

    private void RandPlayerName()
    {

    }
}