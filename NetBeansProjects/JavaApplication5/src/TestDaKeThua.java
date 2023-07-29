
public class TestDaKeThua implements printable,showable {
    public void print() {
        System.out.println("Xin chào");
    }
    public void showable() {
        System.out.println("Chào mừng");
    }
    public static void main(String[] args) {
        TestDaKeThua obj = new TestDaKeThua();
        obj.print();
        obj.show();
    }


