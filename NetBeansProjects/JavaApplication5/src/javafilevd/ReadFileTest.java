package javafilevd;

//import.java.io.*;
import java.io.BufferedInputStream;
import java.io.File;
import java.io.FileInputStream;
import java.io.FileNotFoundException;
import java.io.IOException;


public class ReadFileTest {
    public static void main(String[] args) {
        File file = new File("D://test123a.text");
        BufferedInputStream bis = null;
        FileInputStream fis = null;
        try {
            fis = new FileInputStream(file);
            bis = new BufferedInputStream(fis);
            while (bis.available() > 0) {
                System.out.println((char)bis.read());
            }
        }
        catch (FileNotFoundException fn) {
            System.out.println(" Không tìm thấy file" + fn); 
        }
        catch (IOException ioe) {
            System.out.println(" Lỗi I/O Exception" + ioe);
        }
        finally{
            try {
                if(bis != null && fis != null) {
                    fis.close();
                    bis.close();
                }
            }catch (IOException ioe) {
                System.out.println("Lỗi trong quá trình đóng stream" + ioe);
            }
        }
    }
}
