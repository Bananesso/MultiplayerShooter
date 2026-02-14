using UnityEngine;
using PrimeTween;

public class FuckaMothaFuckaMan : MonoBehaviour
{
    [SerializeField] private Transform Bablastas;
	[SerializeField] private Vector3 _baba;
	[SerializeField] private float _durationpos;
	[SerializeField] private float _durationscsc;
	[SerializeField] private float scsc;

	private void Start()
    {
        Vector3 papa = transform.position;
        Tween.Position(Bablastas, _baba, _durationpos, ease:Ease.Default, cycles:-1, cycleMode:CycleMode.Yoyo);
		Tween.Scale(Bablastas, scsc, _durationscsc, ease: Ease.Default, cycles: -1, cycleMode: CycleMode.Yoyo);
	}
}