using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using winformProject.DTO;
using winformProject.Utis;

namespace winformProject.DAO
{
    class CarDAO
    {
        public static CarIF GetCarfullInfor(string carID)
        {
            CarIF result = new CarIF();
            DataClasses1DataContext db = new DataClasses1DataContext();
            tblCar car = db.tblCars.Where(s => s.carID == int.Parse(carID)).Single();
            result.CarId = car.carID;
            result.CarName = car.carName;
            result.licensePlate = car.licensePlate;
            result.Status = car.status;
            result.SetImage(car.nearestPhoto.ToArray());
            db.Dispose();
            return result;
        }
        public bool checkCar( string carName)
        {
            try
            {
                DataClasses1DataContext db = new DataClasses1DataContext();
                var car = (from s in db.tblCars where s.carName == carName select s).ToList();
                if (car.Count <1)
                {
                    return true;
                }
                else
                {
                    return false;
                }

            }
            catch (Exception)
            {
                return false;
            }
        }
        public static CarIF GetCarfullInforByName(string carName)
        {
            CarIF result = new CarIF();
            DataClasses1DataContext db = new DataClasses1DataContext();
            tblCar car = db.tblCars.Where(s => s.carName == carName).Single();
            result.CarId = car.carID;
            result.CarName = car.carName;
            result.licensePlate = car.licensePlate;
            result.Status = car.status;
            result.SetImage(car.nearestPhoto.ToArray());
            result.UserId = car.userID;
            db.Dispose();
            return result;
        }
        public static Task<CarIF[]> GetAllCarInfoAsync()
        {
            DataClasses1DataContext db = new DataClasses1DataContext();

            return Task.Run<CarIF[]>(() =>
            {
                CarIF[] results = null;
                while (results == null)
                {
                    try
                    {
                        var cars = (from table in db.tblCars select table).ToList();
                        results = new CarIF[cars.Count];
                        int i = 0;
                        foreach (var car in cars)
                        {
                            CarIF result = new CarIF();
                            result.CarId = car.carID;
                            result.CarName = car.carName;
                            result.licensePlate = car.licensePlate;
                            result.Status = car.status;
                            result.UserId = car.userID;
                            result.SetImage(car.nearestPhoto != null ? car.nearestPhoto.ToArray() : null);
                            results[i] = result;
                            ++i;
                        };
                    }
                    catch (Exception)
                    {
                        MessageBox.Show("Datas are loading....");
                    }
                }

                return results;
            });
        }

        public static CarIF[] GetAllCarInfo()
        {
            DataClasses1DataContext db = new DataClasses1DataContext();
            CarIF[] results = null;
            while(results == null)
            {
                try
                {
                    var cars = (from table in db.tblCars select table).ToList();
                    results = new CarIF[cars.Count];
                    int i = 0;
                    foreach (var car in cars)
                    {
                        CarIF result = new CarIF();
                        result.CarId = car.carID;
                        result.CarName = car.carName;
                        result.licensePlate = car.licensePlate;
                        result.Status = car.status;
                        result.UserId = car.userID;
                        result.SetImage(car.nearestPhoto != null ? car.nearestPhoto.ToArray() : null);
                        results[i]=result;
                        ++i;
                    };
                }
                catch (Exception)
                {
                    MessageBox.Show("Datas are loading....");
                }
            }
            
            return results;
        }
        public static List<CarIF> GetCarByLikeName(String name, object data)
        {
            var cars = (CarIF[]) data;
            List<CarIF> results = new List<CarIF>();
            foreach (var car in cars)
            {
                if (car.CarName.Contains(name)) results.Add(car);   
            };

            return results;
        } 

        internal static string[] GetAllUser()
        {
            DataClasses1DataContext db = new DataClasses1DataContext();
            var Users = (from table in db.tblUsers select table.userID ).ToList();
            string[] results = new string[Users.Count()];
            int i = 0;
            foreach (var item in Users)
            {
                results[i] = item;
                i++;
            }
            db.Dispose();
            return results;
        }

        public void AddNewCar(tblCar car)
        {
            DataClasses1DataContext db = new DataClasses1DataContext();
            db.tblCars.InsertOnSubmit(car);
            db.SubmitChanges();
            db.Dispose();
        }

        public void UpdateCar(tblCar carUpdate)
        {
            DataClasses1DataContext db = new DataClasses1DataContext();
            tblCar oldCar = (from table in db.tblCars where table.carID == carUpdate.carID select table).Single();
            oldCar.carName = carUpdate.carName;
            oldCar.licensePlate = carUpdate.licensePlate;
            oldCar.status = carUpdate.status;
            oldCar.nearestPhoto = carUpdate.nearestPhoto;
            db.SubmitChanges();
            db.Dispose();
        }
        public void DeleteCar(string id)
        {
            DataClasses1DataContext db = new DataClasses1DataContext();
            tblCar oldcar = (from table in db.tblCars where table.carID == int.Parse(id) select table).Single();
            oldcar.status = "disable";
            db.SubmitChanges();
            db.Dispose();
        }
        public void UnDeleteCar(string id)
        {
            DataClasses1DataContext db = new DataClasses1DataContext();
            tblCar oldcar = (from table in db.tblCars where table.carID == int.Parse(id) select table).Single();
            oldcar.status = "available";
            db.SubmitChanges();
            db.Dispose();
        }
        internal static List<string> GetAllUserId()
        {
            DataClasses1DataContext db = new DataClasses1DataContext();
            var userIds = (from table in db.tblUsers select table.userID).ToList();
            List<string> results = new List<string>();
            int i = 0;
            foreach (var userId in userIds)
            {
                if (!results.Contains(userId)) results.Add(userId);
                i++;
            }
            return results;
        }
    }
}
