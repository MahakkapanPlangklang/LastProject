# LastProject
 a.โปรแกรมจองโต๊ะ เป็นโปรแกรมที่ถูกออกแบบมาเพื่อให้ลูกค้าสามารถทำการจองโต๊ะในร้านอาหารได้อย่างสะดวกและรวดเร็ว
 b.โปรแกรมนี้จัดทำเพื่อเพิ่มความสะดวกในการจองโต๊ะและจัดการข้อมูล
 c.classDiagram
    class Customer {
        << (S,#FFA07A) >>
        -Name: string
        -Phone: string
        -chairs: List<int>
        +Price: double
        +PhoneN: string
        +NameC: string
        +ToString(): string
    }
  
  classDiagram
    class Customer {
        <<constructor>>
        + Customer()
        # List<int> chairs
        + double Price
        + string PhoneN
        + string NameC
        + string Name
        + string Phone
        + string ToString()
    }
    User --|> Customer
    
    class Login{
    - userList: List<User>
    + Login()
    + button1_Click(sender: object, e: EventArgs): void
    + GetCurrentUser(): User
    + Login_FormClosing(sender: object, e: FormClosingEventArgs): void
}

class User{
    + Username: string
    + Password: string
}

class Mainform{
    - currentUser: User
    + Mainform()
    + SetCurrentUser(user: User): void
}

Login --|> form
User --|> user
Mainform --|> mainForm
  
  
  
  
  
 d.นายมหัคฆพันธ์ ปลั่งกลาง รหัสประจำตัว653450296-6
