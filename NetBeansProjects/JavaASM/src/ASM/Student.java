
package ASM;

import java.util.Objects;


public class Student {
    private String name;
    private String id;
    private String phone;
    private String address;
    private Integer gender;
    private Float math;
    private Float physics;
    private  Float chemistry;

    public Student() {
    }

    public Student(String name, String id, String phone, String address, Integer gender, Float math, Float physics, Float chemistry) {
        this.name = name;
        this.id = id;
        this.phone = phone;
        this.address = address;
        this.gender = gender;
        this.math = math;
        this.physics = physics;
        this.chemistry = chemistry;
    }

    public String getName() {
        return name;
    }

    public void setName(String name) {
        this.name = name;
    }

    public String getId() {
        return id;
    }

    public void setId(String id) {
        this.id = id;
    }

    public String getPhone() {
        return phone;
    }

    public void setPhone(String phone) {
        this.phone = phone;
    }

    public String getAddress() {
        return address;
    }

    public void setAddress(String address) {
        this.address = address;
    }

    public Integer getGender() {
        return gender;
    }

    public void setGender(Integer gender) {
        this.gender = gender;
    }

    public Float getMath() {
        return math;
    }

    public void setMath(Float math) {
        this.math = math;
    }

    public Float getPhysics() {
        return physics;
    }

    public void setPhysics(Float physics) {
        this.physics = physics;
    }

    public Float getChemistry() {
        return chemistry;
    }

    public void setChemistry(Float chemistry) {
        this.chemistry = chemistry;
    }

    @Override
    public int hashCode() {
        int hash = 3;
        hash = 67 * hash + Objects.hashCode(this.name);
        hash = 67 * hash + Objects.hashCode(this.id);
        hash = 67 * hash + Objects.hashCode(this.phone);
        hash = 67 * hash + Objects.hashCode(this.address);
        hash = 67 * hash + Objects.hashCode(this.gender);
        hash = 67 * hash + Objects.hashCode(this.math);
        hash = 67 * hash + Objects.hashCode(this.physics);
        hash = 67 * hash + Objects.hashCode(this.chemistry);
        return hash;
    }

    @Override
    public boolean equals(Object obj) {
        if (this == obj) {
            return true;
        }
        if (obj == null) {
            return false;
        }
        if (getClass() != obj.getClass()) {
            return false;
        }
        final Student other = (Student) obj;
        if (!Objects.equals(this.name, other.name)) {
            return false;
        }
        if (!Objects.equals(this.id, other.id)) {
            return false;
        }
        if (!Objects.equals(this.phone, other.phone)) {
            return false;
        }
        if (!Objects.equals(this.address, other.address)) {
            return false;
        }
        if (!Objects.equals(this.gender, other.gender)) {
            return false;
        }
        if (!Objects.equals(this.math, other.math)) {
            return false;
        }
        if (!Objects.equals(this.physics, other.physics)) {
            return false;
        }
        return Objects.equals(this.chemistry, other.chemistry);
    }

    void set(int editedIndex, Student students) {
        throw new UnsupportedOperationException("Not supported yet."); // Generated from nbfs://nbhost/SystemFileSystem/Templates/Classes/Code/GeneratedMethodBody
    }

    

   

  
    
    
}
