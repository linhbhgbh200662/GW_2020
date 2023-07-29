
package javamvc;

public class LogController {
    private LogView view;
    public LogController(LogView view) {
        this.view = view;
        
    }
    
    public void login() {
        while(true) {
            LogModel user = view.getUserInfo();
            if (checkLogin(user)) {
                view.showMessage("Hiển thị okiii");
            }
            else {
                view.showMessage("Sai user name or password");
            }
            
        }
    }
    
    private boolean checkLogin(LogModel user) {
        if ((user.getUserName() .equals("admin")) && (user.getPassword() .equals("admin"))) { 
            return true;
        }
    return false;
    }
    
}
