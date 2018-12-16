using Microsoft.Win32;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using winformProject.DTO;
using winformProject.Utis;

namespace winformProject.DAO
{
    class UserDAO
    {
        
        public bool CheckLogin(string username, string password)
        {
            bool results = false;
            try
            {
                DataClasses1DataContext db = new DataClasses1DataContext();
                var account = from table in db.tblAccounts where table.userID == username && table.password == password && table.status == "activated" select table.roleName;
                foreach (var item in account)
                {
                    if (item == "Administrator") results = true;
                }
                db.Dispose();
            }
            catch(Exception e)
            {

            }

            return results;
        }
        
        public void SaveLoginState(string userid, string password)
        {
            RegistryKey key = Microsoft.Win32.Registry.CurrentUser.CreateSubKey("smartparking");
            key.SetValue("UserId", userid);
            key.SetValue("Password", password);
        }

        public static UserIF GetUserfullInfor(string userid)
        {
            try
            {
                UserIF result = new UserIF();
                DataClasses1DataContext db = new DataClasses1DataContext();
                tblUser user = db.tblUsers.Where(s => s.userID == userid).Single();
                result.userId = user.userID;
                result.firstName = user.firstName;
                result.lastName = user.lastName;
                result.phoneNum = user.phoneNumber;
                result.mail = user.mail;
                result.SetImage(user.image.ToArray());
                tblAccount com = db.tblAccounts.Where(s => s.userID == userid).Single();
                result.role = com.roleName;
                db.Dispose();
                return result;
            }
            catch(Exception e) {
                return null;
            }
        }
        public static Task<UserIF[]> UserDataAsync()
        {
            DataClasses1DataContext db = new DataClasses1DataContext();

            return Task.Run<UserIF[]>(() =>
            {
                bool Flag = false;
                while (Flag == false)
                {
                    try
                    {
                        var users = (from table in db.tblUsers select table).ToList();
                        int i = 0;
                        UserIF[] results = new UserIF[users.Count];
                        foreach (var user in users)
                        {
                            UserIF result = new UserIF();
                            result.userId = user.userID;
                            result.firstName = user.firstName;
                            result.lastName = user.lastName;
                            result.phoneNum = user.phoneNumber;
                            result.mail = user.mail;
                            byte[] a = (user.image != null ? user.image.ToArray() : null);
                            result.SetImage(a);
                            tblAccount com = db.tblAccounts.Where(s => s.userID == user.userID).Single();
                            result.role = com.roleName;
                            result.status = (from table in db.tblAccounts where table.userID == user.userID select table.status).Single();
                            results[i] = result;
                            i++;
                        };
                        Flag = true;
                        return results;

                    }
                    catch (Exception e)
                    {
                        System.Windows.Forms.MessageBox.Show("wait a minute");

                    }
                }
                return null;
            });
        }

        public static UserIF[] GetAllUserfullInfor()
        {
            bool Flag = false;
            while (Flag == false)
            {
                try
                {
                    DataClasses1DataContext db = new DataClasses1DataContext();
                    var users =  (from table in db.tblUsers select table).ToList();
                    int i = 0;
                    UserIF[] results = new UserIF[users.Count];
                    foreach (var user in users)
                    {
                        UserIF result = new UserIF();
                        result.userId = user.userID;
                        result.firstName = user.firstName;
                        result.lastName = user.lastName;
                        result.phoneNum = user.phoneNumber;
                        result.mail = user.mail;
                        byte[] a = (user.image != null ? user.image.ToArray() : null);
                        result.SetImage(a);
                        tblAccount com = db.tblAccounts.Where(s => s.userID == user.userID).Single();
                        result.role = com.roleName;
                        result.status = (from table in db.tblAccounts where table.userID == user.userID select table.status).Single();
                        results[i] = result;
                        i++;
                    };
                    Flag = true;
                    return results;
                    
                }
                catch (Exception e)
                {
                    System.Windows.Forms.MessageBox.Show("wait a minute");

                }
            }
            return null;
        }

        

        public tblCar[] GetCarInforByUser(string userId)
        {
            tblCar[] result = null;
            DataClasses1DataContext db = new DataClasses1DataContext();
            var list = from s in db.tblCars where s.userID == userId select s;
            result = list.ToArray();
            db.Dispose();
            return result;
            
        }

        public void AddNewEmployee(tblUser user, tblAccount account)
        {
            DataClasses1DataContext db = new DataClasses1DataContext();
            db.tblUsers.InsertOnSubmit(user);
            db.tblAccounts.InsertOnSubmit(account);
            db.SubmitChanges();
            db.Dispose();
        }

        public void UpdateImployee(tblUser userUpDate)
        {
            DataClasses1DataContext db = new DataClasses1DataContext();
            tblUser oldUser = (from table in db.tblUsers where table.userID == userUpDate.userID select table).Single();
            oldUser.userID = userUpDate.userID;
            oldUser.firstName = userUpDate.firstName;
            oldUser.lastName = userUpDate.lastName;
            oldUser.mail = userUpDate.mail;
            oldUser.image = userUpDate.image;
            oldUser.phoneNumber = oldUser.phoneNumber;
            db.SubmitChanges();
            db.Dispose();
        }
        public void DeleteEmployee(string id)
        {
            DataClasses1DataContext db = new DataClasses1DataContext();
            tblAccount oldAccount = (from table in db.tblAccounts where table.userID == id select table).Single();
            oldAccount.status = "disable";
            db.SubmitChanges();
            db.Dispose();
        }
        public void UnDeleteEmployee(string id)
        {
            DataClasses1DataContext db = new DataClasses1DataContext();
            tblAccount oldAccount = (from table in db.tblAccounts where table.userID == id select table).Single();
            oldAccount.status = "activated";
            db.SubmitChanges();
            db.Dispose();
        }
        public static string[] GetAllRole()
        {
            DataClasses1DataContext db = new DataClasses1DataContext();
            var roles = (from table in db.tblAccounts select table.roleName);
            string[] results = new string[roles.Count()];
            int i = 0;
            foreach (var item in roles)
            {
                results[i] = item;
                i++;
            }
            db.Dispose();
            return results;
        }

        internal static List<UserIF> GetUserfullInforByNameLike(string name, Object data)
        {
            bool Flag = false;
            while (Flag == false)
            {
                try
                {
                    List<UserIF> results = new List<UserIF>();
                    foreach (var user in (UserIF[]) data)
                    {
                        if (user.lastName.Contains(name) || user.firstName.Contains(name))
                        {
                            results.Add(user);
                        }
                    };
                    Flag = true;
                    return results;

                }
                catch (Exception e)
                {
                    System.Windows.Forms.MessageBox.Show("wait a minute");

                }
            }
            return null;
        }

        //============================================================================

    }
}
