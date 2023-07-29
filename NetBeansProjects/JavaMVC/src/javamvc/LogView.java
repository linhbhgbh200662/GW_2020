
package javamvc;

import java.util.Scanner;

public class LogView {
    public static Scanner sc = new Scanner(System.in);
    
    public void showMessage(String ms) {
        System.out.println(ms);
        
    }
    
    public LogModel getUserInfo() {
        LogModel user = new LogModel();
        System.out.println("User name");
        user.setUserName(sc.next());
        System.out.println("Password");
        user.setUserName(sc.next());
        
        return user;
    }
}
