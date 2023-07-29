
package interfaceExtend;

public class TestInterfaceExtend implements showable {
    public void show() {
        System.out.println("Chào mừng");
    }
    public void print() {
        System.out.println("Xin chào");
    }
    public static void main(String[] args) {
        TestInterfaceExtend obj = new TestInterfaceExtend();
        obj.print();
        obj.show();
    }
}
