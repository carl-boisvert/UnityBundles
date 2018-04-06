using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(fileName = "Data", menuName = "Server/Config", order = 1)]
public class ServerConfig : ScriptableObject
{
    public string serverUrl = "http://localhost/";
}
