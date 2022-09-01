using System;
using UnityEngine;
using UnityEngine.UI;

public class ContactsUI : MonoBehaviour
{
    [SerializeField]
    private Image AvatarImage, Highlight;
    [SerializeField]
    private Text Name;
    [SerializeField]
    private Sprite UnknownSprite;

    private Button button;
    private BasicInfo contactInfo;

    private event Action<ContactsUI> SetSelectedContact;

    private bool is_unlocked = false;

    void Awake()
    {
        button = gameObject.GetComponent<Button>();
        button.onClick.AddListener(OnButtonClicked);
    }

    public void OnButtonClicked()
    {
        SetSelectedContact?.Invoke(this);
        EnableHighlight();
    }

    public void Initialise(Sprite avatarSprite, BasicInfo contact, Action<ContactsUI> action)
    {
        if (avatarSprite != null)
            AvatarImage.sprite = avatarSprite;
        Name.text = contact.Name;
        contactInfo = contact;
        SetSelectedContact = action;

        is_unlocked = true;
    }

    public void InitUnknown(BasicInfo contact, Action<ContactsUI> action)
    {
        AvatarImage.sprite = UnknownSprite;
        SetSelectedContact = action;
        contactInfo = contact;
        Name.text = "";

        is_unlocked = false;
    }

    public void DisableHighlight()
    {
        Highlight.color = new Color32(255, 255, 255, 50);
    }

    public void EnableHighlight()
    {

        Highlight.color = new Color32(255, 255, 255, 150);

    }

    public BasicInfo GetContactInfo()
    {
        return contactInfo;
    }

    public bool GetUnlockStatus()
    {
        return is_unlocked;
    }


}
