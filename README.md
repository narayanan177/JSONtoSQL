# JSONtoSQL
Design SQL DB for Unstructured Data(JSON)


Softwares:

        Visual studio
        
        Tool to convert JSON to C# object - refer to any online tool like jsontochsarp.
        
        Nuget Packages
        
          Entityframework
          
          Newtonsoft JSON.NET
          
          
 Approach:
 
          Using Entity Framework Code-First approach.
 
 Steps:
 
 Create new console App C# project
 
 Install EntityFramework and Newtonsoft JSON.NET package
 
 Create new Class - i.e generated using JSON to C# object.
 
 Place JSON file in path
 
 Read the JSON file like
 
 
             var fileData = File.ReadAllText("path of JSON file");
             
 Deserialize Object using JSON.NET like
 
             var jsonData = JsonConvert.DeserializeObject<Rootobject>(fileData);
 
 
  Now it is simple of C# object, we can acess property and save data into DB.
  
    As a next step we need to design SQL Database
    
          Before getting into DB, we need to make sure name of class generated are proper, so that Table design will adhere to standards.
               
          Review each class, add new int property as "ID" wherever we don't have ID,
          
          Make sure we set proper name, before we proceed further - this will help for referring table.
  
  
  Create new class derived from DBContext like follows: (just example)
  
  
           public class PolicyContext : DbContext
           {
                public PolicyContext() : base("MydbConn")  
                {

                }
              public DbSet<Policy> PolicyInfo { get; set; }
              public DbSet<Client> ClientInfo { get; set; }
              public DbSet<Agency> AgencyDetails { get; set; }
              public DbSet<Binder> BinderInfo { get; set; }
              public DbSet<AnnualPremium> AnnualPremiumDetails { get; set; }
              public DbSet<TransactionPremium> TransactionPremiumDetails { get; set; }
              public Page[] PageInfo { get; set; }
              public Section[] SectionInfo { get; set; }
              public Endorsement[] Recommendations {get; set; }
           }
           
  
  Then in main program, make sure we set ID value set properly.
  
   using (var ctx = new PolicyContext())
            {
                  Step 1:
                  
                    // Access fileData object, set ID property value as per your requirements, so that we join and query the DB
                    
                  Step 2:
                  
                       ctx.Policy.Add(policy);
                       
                       ctx.SaveChanges();
                       
            }
            

  In App.config, make sure - to give proper connectionstring
  
    <connectionStrings>
    <add name="MydbConn"
    connectionString="Data Source=(LocalDb)\MSSQLLocalDB;Initial Catalog=PoliciesDataDB;Integrated Security=true"
    providerName="System.Data.SqlClient"/>
  </connectionStrings>
  
  
  Then access the DB and verify all data is in.
  
  Delete [dbo].[__MigrationHistory] table, this is not required.
  
  
  Generate SQL script, Now Data Model is ready!!!!
  
  
  We can use this model to load unstructure data into SQL DB either using simple App or SSIS packages or any standard ETL process.
  
  
  Note:
  Just in case, if we get new attribute comes in JSON input, we need to make changes in class to save that field in DB. 


