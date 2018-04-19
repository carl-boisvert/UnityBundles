using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using Snappydue.UnityBundle;

namespace Snappydue.UnityBundle
{
    public partial class EventDelegate
    {
        public delegate void ChatMessageSentHandler(Player player, string message);
        public static event ChatMessageSentHandler ChatMessageSent;
        public static void OnChatMessageSent(Player player, string message)
        {
            if (ChatMessageSent != null)
            {
                ChatMessageSent(player, message);
            }
        }

        public delegate void ToggleChatHandler();
        public static event ToggleChatHandler ToggleChat;
        public static void OnToggleChat()
        {
            if (ToggleChat != null)
            {
                ToggleChat();
            }
        }

    }
    public class ChatController : MonoBehaviour
    {

        [SerializeField, Tooltip("Field where the player enter text for chat")]
        private GameObject open;

        [SerializeField, Tooltip("Field where the player enter text for chat")]
        private GameObject close;

        [SerializeField, Tooltip("Field where the player enter text for chat")]
        private InputField input;

        [SerializeField, Tooltip("Field where the player enter text for chat")]
        private GameObject content;

        [SerializeField, Tooltip("Field where the player enter text for chat")]
        private GameObject message;

        [SerializeField, Tooltip("Field where the player enter text for chat")]
        private Player player;

        private bool isOpen = false;


        private void OnEnable()
        {
            EventDelegate.ToggleChat += ToggleChat;
        }

        private void OnDisable()
        {
            EventDelegate.ToggleChat -= ToggleChat;
        }


        private void Update()
        {
            if (Input.GetKeyDown(KeyCode.Tab))
            {
                EventDelegate.OnToggleChat();
            }
        }

        // Update is called once per frame
        public void ShowPlayerMessage()
        {
            GameObject gb = Instantiate(message, content.transform.position, content.transform.rotation);
            Text messageText = gb.GetComponent<Text>();
            messageText.text = player.Username + ": " + input.text;
            messageText.alignment = TextAnchor.UpperLeft;
            messageText.fontSize = 8;
            gb.transform.SetParent(content.transform);
            gb.transform.localScale = new Vector3(1, 1, 1);
            input.text = "";
            input.ActivateInputField();
            EventDelegate.OnChatMessageSent(player, messageText.text);
        }

        private void ToggleChat()
        {
            open.SetActive(!open.activeInHierarchy);
            close.SetActive(!close.activeInHierarchy);
        }
    }
}