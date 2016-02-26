using UnityEngine;
using System.Collections;
using UnityEditor;

public class TestEditor : Editor {

	[MenuItem("Wolf/WolfData")]//在菜单中出现选项栏，点一下，执行对应功能。注：对应的功能必须是static，同时，使用的时候需要加上using UnityEditor，这个类也要找个Editor文件夹放（一般放“Assets\Editor”），要不……就等着纠结吧~~
    static void CaoNiMa()
    {
        Debug.Log("WQNMLGB");
    }

}
