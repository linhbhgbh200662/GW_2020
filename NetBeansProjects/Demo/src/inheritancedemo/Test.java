
package inheritancedemo;

class DongVat{
    void an() {
        System.out.println("an...");
    }
}

class Bo extends DongVat {
    void anCo() {
        System.out.println("an co...");
    }
}

class Be extends Bo {
    void anSua() {
        System.out.println("an sua...");
    }
}
// kế thừa nhiều cấp

public class Test {
    public static void main(String[]args) {
//        Be be = new Be();
//        be.anSua();
//        be.anCo();
//        be.an();
    Student s = new Student();
    s.setName("Nguyễn Trân");
    System.out.println(s.getName());
    }
}
