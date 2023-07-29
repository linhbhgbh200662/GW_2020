package javafilevd;

import java.io.File;

public class DeleteFileTest {
    public static void main(String[] args) {
        try {
            File file = new File("D://test123a.txt");
            if(file.delete()) {
                System.out.println(file.getName() + " đã bị xóa");
            } 
            else {
                System.out.println("File không bị xóa");
            }
        }
        catch (Exception e) {
            System.out.println("Lỗi exception");
            e.printStackTrace();
        }
    }
}
