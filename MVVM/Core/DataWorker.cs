using Microsoft.EntityFrameworkCore.Storage.ValueConversion.Internal;
using Proect_8.MVVM.Model;
using Proect_8.MVVM.Model.Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Media.Animation;

namespace Proect_8.MVVM.Core
{
    public static class DataWorker
    {
        #region Получить все отделы
        public static List<Department> GetAllDepartments()
        {
            using (ApplicationContext db = new ApplicationContext())
            {
                return db.Departments.ToList();
            }
        }
        #endregion

        #region Получить все должности
        public static List<Position> GetAllPositions()
        {
            using (ApplicationContext db = new ApplicationContext())
            {
                return db.Positions.ToList();
            }
        }
        #endregion

        #region Получить всех работников
        public static List<Employee> GetAllEmployees()
        {
            using (ApplicationContext db = new ApplicationContext())
            {
                return db.Employees.ToList();
            }
        }
        #endregion

        #region Создать отдел
        public static string CreateDepartment(string departmensName)
        {
            string resuls = "Такой отдел уже есть";
            using (ApplicationContext db = new ApplicationContext())
            {
                bool checkIsExist = db.Departments.Any(a=>a.DepartmentName == departmensName);
                if (!checkIsExist)
                {
                    db.Departments.Add(new Department
                    {
                        DepartmentName = departmensName
                    }); 
                    db.SaveChanges();
                    resuls = "Отдел успешно создан";
                }
                return resuls;
            }
        }
        #endregion

        #region Создать должность
        public static string CreatePosition(string positionName, decimal salary, int maxCountOfEmployees, Department department)
        {
            string resuls = " Такая должность уже есть";
            using (ApplicationContext db = new ApplicationContext())
            {
                bool checkIsExist = db.Positions.Any(a=>a.PositionName == positionName &&
                a.Salary == salary && a.MaxCountOfEmployees == maxCountOfEmployees );

                if (!checkIsExist)
                {
                    db.Positions.Add(new Position
                    {
                        PositionName = positionName,
                        Salary = salary,
                        MaxCountOfEmployees = maxCountOfEmployees,
                        DepartmentID = department.ID 
                    });
                    db.SaveChanges();
                    resuls = "Должность успешно создана";
                }
                return resuls;
            }
        }
        #endregion

        #region Добавить сотрудника
        public static string CreateEmployee(string name, string surname, string phone, Position position)
        {
            string result = "Такой сотрудник уже есть";
            using (ApplicationContext db = new ApplicationContext())
            {
                bool checkIsExist = db.Employees.Any(a => a.Name == name && a.Surname == surname && a.Phone == phone);
                if (!checkIsExist)
                {
                    db.Employees.Add(new Employee
                    {
                        Name = name,
                        Surname = surname,
                        Phone = phone,
                        PositionID = position.ID
                    });
                }
                return result;
            }
        }
        #endregion

        #region удалить отдел
        public static string DeleteDepartment(Department department)
        {
            string result = "Такого отдела нет";
            using (ApplicationContext db = new ApplicationContext())
            {
                db.Departments.Remove(department); 
                db.SaveChanges();
                result = $"Отдел {department.DepartmentName} удалён";
            }
            return result;
        }
        #endregion

        #region удалить должности
        public static string DeletePosition(Position position)
        {
            string result = "Такой должности нет";
            using (ApplicationContext db = new ApplicationContext())
            {
                db.Positions.Remove(position);
                db.SaveChanges();
                result = $"должность  {position.PositionName} удалена";
            }
            return result;
        }
        #endregion

        #region удалить cотрудника
        public static string DeleteEmployee(Employee employee)
        {
            string result = "Такого работника не существует";
            using (ApplicationContext db = new ApplicationContext())
            {
                db.Employees.Remove(employee);
                db.SaveChanges();
                result = $"Работник {employee.Surname} удалён";
            }
            return result;
        }
        #endregion

        #region Редактирование отдела
        public static string EditDepartment(Department departmentName, string newDepartmetnName)
        {
            string result = "Такого отдела нет";
            using (ApplicationContext db = new ApplicationContext())
            {
                Department department = db.Departments.FirstOrDefault(z => z.ID == departmentName.ID);
                if (department != null)
                {
                    department.DepartmentName = newDepartmetnName;
                    db.SaveChanges();
                    result = $"Отдел изменён";
                }
            }
            return result;
        }
        #endregion

        #region Редактирование должности
        public static string EditPosition(Position positionName, string newPositionName, decimal newSalary,int newMaxCountOfEmployees, Department newDepartment)
        {
            string result = "Такой должности нет";
            using (ApplicationContext db = new ApplicationContext())
            {
                Position position = db.Positions.FirstOrDefault(f => f.ID == positionName.ID);
                if (position != null)
                {
                    position.PositionName = newPositionName;
                    position.Salary = newSalary;
                    position.MaxCountOfEmployees = newMaxCountOfEmployees;
                    position.Department = newDepartment;
                    db.SaveChanges();
                    result = $"Должность изменена";
                }
            }
            return result;
        }
        #endregion

        #region Редактирование должности
        public static string EditEmployee(Employee employeeName, string newName, string newSurname, string newPhone, Position newPosition)
        {
            string result = "Такой работника не существует";
            using (ApplicationContext db = new ApplicationContext())
            {
                Employee employee = db.Employees.FirstOrDefault(e=> e.ID == employeeName.ID);
                if (employee != null)
                {
                    employee.Name = newName;
                    employee.Surname = newSurname;
                    employee.Phone = newPhone;
                    employee.PositionID = newPosition.ID;
                    db.SaveChanges();
                    result = $"Информация о работнике изменина";
                }
            }
            return result;
        }
        #endregion

        #region Получение Информации По ID

        public static Position GetPositionByID(int id)
        {
            using (ApplicationContext db = new ApplicationContext())
            {
                return db.Positions.FirstOrDefault(p => p.ID == id);
            }
        }

        public static Department GetDepartmentByID(int id)
        {
            using (ApplicationContext db = new ApplicationContext())
            {
                return db.Departments.FirstOrDefault(p => p.ID == id);
            }
        }

        public static List<Employee> GetAllEmployeesByPossitionsID(int id)
        {
            using (ApplicationContext db = new ApplicationContext())
            {
                List<Employee> employees = (from employee in GetAllEmployees()
                                            where employee.PositionID == id
                                            select employee).ToList();
                return employees;
            }
        }

        public static List<Position> GetAllPositionsByDepartmentID(int id)
        {
            using (ApplicationContext db = new ApplicationContext())
            {
                List<Position> positions = (from position in GetAllPositions()
                                            where position.DepartmentID == id
                                            select position).ToList();
                return positions;
            }
        }
        #endregion
    }
}
