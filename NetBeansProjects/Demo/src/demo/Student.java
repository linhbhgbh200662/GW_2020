
package demo;

public class Student {
    int id;
    String name;
    int age;
    
    public Student(int id, String name) {
        this.id = id;
        this.name = name;
        }
    public Student(int id, String name, int age) {
        this.id = id;
        this.name = name;
        this.age = age;
    }
    void insert(int id, String name){
        this.id = id;
        this.name = name;
    }

    void display(){
        System.out.println(id + " " + name + " " + age);
    }
    
    public static void main(String[]args) {
//        Student std1 = new Student();
//        Student std2 = new Student();
//        //System.out.println(std1.id);
//        //System.out.println(std1.name);
//        std1.insert(1, "Nguyễn Văn A");
//        std2.insert(2, "Trần Văn B");
//        std1.display();
//        std2.display();

        Student s1 = new Student(1, "Nguyễn Văn A");
        Student s2 = new Student(2, "Trần Văn B", 21);
        s1.display();
        s2.display();
    }
}
