using LeakyAbstraction;
using UnityEngine;
using UnityEngine.UI;

[RequireComponent(typeof(Button))]
public class SoundButton : MonoBehaviour
{
    [SerializeField] private GameSound Sound = default;

    private void Awake() => GetComponent<Button>().onClick.AddListener(() => SoundManager.Instance.PlaySound(Sound));
}
