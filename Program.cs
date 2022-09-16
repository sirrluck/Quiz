public class KFC {
    public string capital;
    public string branchName;
    public string address;
    
    public KFC(string capital, string branchName, string address) {
        this.capital = capital;
        this.branchName = branchName;
        this.address = address;
    }
    
     public string PrintInformation() {
        return "information is : " 
        + this.capital + " " +
         this.branchName + " " +
         this.address + " " +;
    }
}

public class User {
    public string name;
    public string surname;
    public string citizenID;
    
   public User(string name, string surname, string studentID, int score) {
        this.name = name;
        this.surname = surname;
        this.citizenID = citizenID;
   }
    
     public string PrintUserInformation() {
        return "User information is : " 
        + this.name + " " + this.surname + " " +
         this.citizenID;
    }
}

