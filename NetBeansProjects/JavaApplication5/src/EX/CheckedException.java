
package EX;

public class CheckedException {
    public static void main(String[] args) {
        //Checked Exception (liên quan đến lỗi cú pháp)
        //System.out.println(ABC);
        //Unchecked Exception. ( liên quan đến lỗi logic)
        //int a = 5, b = 0;
        //System.out.println(a/b);
        
        //try-catch để xử lý các ngoại lệ
        try{
            System.out.print("Câu lệnh đầu tiên của try block");
            int num = 45/0;
            System.out.print(num);
            
        }
        catch(ArithmeticException e) {
            System.out.println(" ArithmeticException");
            
        }
        finally {
            System.out.println("Finally block");
        }
    }
}
