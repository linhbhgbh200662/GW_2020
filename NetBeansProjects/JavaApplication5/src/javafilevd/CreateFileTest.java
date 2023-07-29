
package javafilevd;
import java.io.File;
import java.io.IOException;
public class CreateFileTest {
    public static void main(String[] args) {
        try {
           File file = new File("D:\\testJava123,txt");
           boolean f = file.createNewFile();
           if (f) {
               System.out.println("File đã được tạo okii");
           } else {
               System.out.println("File đã bị trùng");
           }
        }
        catch(IOException e) {
            System.out.println("Lỗi exception trong quá trình tạo file");
            e.printStackTrace();
        }
    }
}
