using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class ConfirmationDialogController : MonoBehaviour
{
    [SerializeField] private GameObject dialogPanel;
    [SerializeField] private TextMeshProUGUI messageText;
    [SerializeField] private Button confirmButton;
    [SerializeField] private Button cancelButton;

    private System.Action _onConfirm;
    private System.Action _onCancel;

    private void Awake()
    {
        // Hide dialog on start
        dialogPanel.SetActive(false);

        // Add button listeners
        confirmButton.onClick.AddListener(OnConfirmClicked);
        cancelButton.onClick.AddListener(OnCancelClicked);
    }

    public void Show(string message, System.Action onConfirmAction = null, System.Action onCancelAction = null)
    {
        messageText.text = message;
        _onConfirm = onConfirmAction;
        _onCancel = onCancelAction;
        dialogPanel.SetActive(true);
    }

    private void OnConfirmClicked()
    {
        dialogPanel.SetActive(false);
        _onConfirm?.Invoke();
    }

    private void OnCancelClicked()
    {
        dialogPanel.SetActive(false);
        _onCancel?.Invoke();
    }

    private void OnDestroy()
    {
        // Clean up listeners
        confirmButton.onClick.RemoveListener(OnConfirmClicked);
        cancelButton.onClick.RemoveListener(OnCancelClicked);
    }
}
