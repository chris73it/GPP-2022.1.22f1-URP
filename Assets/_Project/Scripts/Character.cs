using UnityEngine;
using MenteBacata.ScivoloCharacterController;

namespace HeroicArcade.CC.Core
{
    public class Character : MonoBehaviour
    {
        [HideInInspector] public float CurrentMaxMoveSpeed;
        [HideInInspector] public Vector3 velocity = Vector3.zero;
        [HideInInspector] public float velocityXZ = 0f;

        [SerializeField] InputController inputController;
        public InputController InputController { get => inputController; }

        [SerializeField] Animator animator;
        public Animator Animator { get => animator; }

        [Header("Character Parameters")]
        [SerializeField] float maxWalkSpeed; //6
        public float CurrentMaxWalkSpeed { get => maxWalkSpeed; set => maxWalkSpeed = value; }
        [SerializeField] float gravity; //-20
        public float Gravity { get => gravity; }
        [SerializeField] float turnSpeed;
        public float TurnSpeed { get => turnSpeed; }
        [SerializeField] float moveAcceleration;
        public float MoveAcceleration { get => moveAcceleration; set => moveAcceleration = value; }
        [SerializeField] CharacterMover mover;
        public CharacterMover Mover { get => mover; }
        [SerializeField] GroundDetector groundDetector;
        public GroundDetector GroundDetector { get => groundDetector; }
    }
}