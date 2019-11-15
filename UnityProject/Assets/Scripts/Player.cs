using UnityEngine;

public class Player : MonoBehaviour
{
    #region 欄位區域
    [Header("速度")] [Range(0f, 100f)]
    public float speed = 3.5f;
    [Header("跳躍")] [Range(500, 2500)]
    public int jump = 700;
    [Header("是否在地上"),Tooltip("用來判斷角色是否在地上。")]
    public bool isGround = false;
    [Header("角色名稱")]
    public string Name = "zero";
    [Header("2D 元件")]
    public Rigidbody2D r2d;
    public Animator ani;
    #endregion

    private void Move()
    {
        float h = Input.GetAxisRaw("Horizontal");
        r2d.AddForce(new Vector2(speed * h*4,0));
        ani.SetBool("跑步開關", h != 0);
    }
    private void Jump()
    {
        if (Input.GetKeyDown(KeyCode.Space) && isGround == true)
        {
            isGround = false;
            r2d.AddForce(new Vector2(0, jump));
        }
    }
    private void Dead()
    {

    }
    private void Update()
    {
        Move();
        Jump();
    }
    private void OnCollisionEnter2D(Collision2D collision)
    {
       //如果 碰撞.物件.名稱 等於 "地板"
       if(collision.gameObject.name == "地板")
        {
            isGround = true;
        } 
    }
}

