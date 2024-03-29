#include <iostream>
#include <pqxx/pqxx> 
 
using namespace std;
using namespace pqxx;
 
int main() 
{
   try {
      connection C("dbname = freyja_db user = freyja_admin password = brisingamen_22 localhost");
      if (C.is_open()) 
      {
         cout << "Opened database successfully: " << C.dbname() << endl;
      } else 
      {
         cout << "Can't open database" << endl;
         return 1;
      }
      C.disconnect ();
   } catch (const std::exception &e) 
   {
      cerr << e.what() << std::endl;
      return 1;
   }
}