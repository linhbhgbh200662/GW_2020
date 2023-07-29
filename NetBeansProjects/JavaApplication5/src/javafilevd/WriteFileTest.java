

import java.io.File;
import java.io.FileOutputStream;
import java.io.IOException;

public class WriteFileTest {
    public static void main(String[] argsO) throws IOException {
        FileOutputStream fos = null;
        File file;
        String content = " Xin chào" + " Mùa hè";
        try {
            file = new File("D://test123a.txt");
            fos = new FileOutputStream(file);
            byte[] bArr = content.getBytes();
            fos.write(bArr);
            fos.flush();
            System.out.println("FIle ghi thành công");
        }
        catch (IOException ioe) {
            ioe.printStackTrace();
        }
        finally{
            try {
                if(fos != null) {
                    fos.close();
                }
            }catch (IOException ioe) {
                System.out.println("Lỗi trong quá trình đóng stream");
            }
        }
        
    }
}
