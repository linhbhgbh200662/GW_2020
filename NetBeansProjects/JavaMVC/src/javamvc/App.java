
package javamvc;

public class App {
    public static void main (String[] args) {
        LogView view = new LogView();
        LogController ct = new LogController(view);
        ct.login();
    }
    
    
}
