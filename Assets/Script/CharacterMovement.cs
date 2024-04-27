using System.Collections;
using System.Collections.Generic;
using UnityEngine;


namespace Character
{
    public class CharacterMovement : Char
    {
        [Header("Movement Only")]
        [SerializeField] private Rigidbody2D rb;
        public Transform groundCheck; // Điểm kiểm tra nếu nhân vật đang đứng trên mặt đất
        public LayerMask groundLayer; // Layer của mặt đất

        // Start is called before the first frame update
        void Start()
        {

        }

        // Update is called once per frame
        void Update()
        {
            Movement();
        }
        private void Movement()
        {
            // Xử lý di chuyển
            float moveInput = Input.GetAxis("Horizontal");
            rb.velocity = new Vector2(moveInput * moveSpeed, rb.velocity.y);
        }
    }
}