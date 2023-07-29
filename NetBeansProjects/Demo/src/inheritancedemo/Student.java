
package inheritancedemo;
// tínhd đóng gói (encapsulation)

class Student {
    private String name;
    
    public String getName(){ //get là lấy gias trị
        return name;
    }
    
    public void setName(String name){
        this.name = name;
    }
}
