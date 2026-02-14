using UnityEngine;
using UnityEngine.InputSystem;

public class MotherFucker : MonoBehaviour
{
	[Tooltip("Ссылка на объект со скриптом PhotonImageHandler")]
	public Fuck imageHandler;

	private InputAction _hKeyAction;

	private void Awake()
	{
		// Настраиваем клавишу H
		_hKeyAction = new InputAction(binding: "<Keyboard>/h");
		_hKeyAction.performed += _ => CallShare();

	}

	private void OnEnable() => _hKeyAction.Enable();
	private void OnDisable() => _hKeyAction.Disable();

	private void CallShare()
	{
		if (imageHandler != null)
		{
			imageHandler.RequestImageShare();
		}
		else
		{
			Debug.LogWarning("Не назначена ссылка на imageHandler!");
		}
	}
}
