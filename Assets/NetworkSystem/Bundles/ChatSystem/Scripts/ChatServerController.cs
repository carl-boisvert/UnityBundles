using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Networking;
using Snappydue.UnityBundle;

namespace Snappydue.UnityBundle
{
    public class ChatServerController : MonoBehaviour
    {

        public ServerConfig config = null;
        [SerializeField, Tooltip("Time in second to wait before checking for new messages")]
        private int fetchFrequency = 5;

        private Coroutine listenCoroutine = null;

        private void Start()
        {
            listenCoroutine = StartCoroutine(ListenMessage());
        }

        private void OnEnable()
        {
            EventDelegate.ChatMessageSent += SendMessage;
        }

        private void OnDisable()
        {
            EventDelegate.ChatMessageSent -= SendMessage;

            StopCoroutine(listenCoroutine);
        }

        private void SendMessage(Player player, string message)
        {
            StartCoroutine(SendMessageRoutine(player, message));
        }

        private IEnumerator SendMessageRoutine(Player player, string message)
        {
            List<IMultipartFormSection> formData = new List<IMultipartFormSection>();
            formData.Add(new MultipartFormDataSection("player=" + player.Username + "&message=" + message));

            UnityWebRequest req = UnityWebRequest.Post(config.serverUrl + "/chat", formData);
            yield return req.SendWebRequest();


            if (req.isNetworkError || req.isHttpError)
            {
                Debug.Log(req.error);
            }
            else
            {
                Debug.Log("Form upload complete!");
            }
        }

        private IEnumerator ListenMessage()
        {
            yield return new WaitForSeconds(fetchFrequency);

            UnityWebRequest req = UnityWebRequest.Get(config.serverUrl + "/chat?player=Snappydue");
            yield return req.SendWebRequest();

            if (req.isNetworkError || req.isHttpError)
            {
                Debug.Log(req.error);
            }
            else
            {
                string json = req.downloadHandler.text;
                Debug.Log(json);
            }

            yield return null;
        }
    }
}