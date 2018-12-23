using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
//add to the references under UnitTest section
using ProjectDB;
using System.Transactions;
using System.Data.SqlClient;
using ProjectDB.Models;

namespace ProjectDB.DAL.Tests
    {
        [TestClass()]
        public class EmployeeTest
        {
        const string ConnectionString = @"Data Source=.\sqlexpress;Initial Catalog=Projects;Integrated Security=True";
        private TransactionScope tran;      //<-- used to begin a transaction during initialize and rollback during cleanup

        // used to hold the id of the row created for our test
        private int testEmployeeId = 0;
        private int testEmployeeIdAssignedToProject = 0;
        private int testDepartmentId = 0;
        private int testProjectId = 0;


        [TestInitialize]
        public void Initialize()
        {
            // Initialize a new transaction scope. This automatically begins the transaction.
            tran = new TransactionScope();

            // Open a SqlConnection object using the active transaction
            using (SqlConnection conn = new SqlConnection(ConnectionString))
            {
                SqlCommand cmd;

                conn.Open();

                //Insert a Dummy Record for Employee               
                cmd = new SqlCommand("INSERT INTO department VALUES ('Test Department'); SELECT CAST(SCOPE_IDENTITY() as int);", conn);
                testDepartmentId = (int)cmd.ExecuteScalar();

                cmd = new SqlCommand($"INSERT INTO employee VALUES ({testDepartmentId}, 'First Name', 'Last Name', 'Chief Tester', '02/02/2016', 'M', '02/03/2016'); SELECT CAST(SCOPE_IDENTITY() as int);", conn);
                testEmployeeId = (int)cmd.ExecuteScalar();

                cmd = new SqlCommand($"INSERT INTO employee VALUES ({testDepartmentId}, 'Hard Working', 'John', 'Hard Worker', '02/02/2016', 'M', '02/03/2016'); SELECT CAST(SCOPE_IDENTITY() as int);", conn);
                testEmployeeIdAssignedToProject = (int)cmd.ExecuteScalar();

                cmd = new SqlCommand("INSERT INTO project VALUES ('Project Name', '01/01/2016', '12/31/2016'); SELECT CAST(SCOPE_IDENTITY() as int);", conn);
                testProjectId = (int)cmd.ExecuteScalar();

                cmd = new SqlCommand($"INSERT INTO project_employee VALUES ({testProjectId}, {testEmployeeIdAssignedToProject});", conn);
                cmd.ExecuteNonQuery();
            }
        }

        // Cleanup runs after every single test
        [TestCleanup]
        public void Cleanup()
        {
            tran.Dispose(); // disposing the transaction without committing it means it will get rolled back
        }

        public void GetAllEmployeesTest()
        {
            //Arrange
            EmployeeSqlDAL dal = new EmployeeSqlDAL(ConnectionString);

            //Act
            List<Employee> employees = dal.GetAllEmployees();

            //Assert
            Assert.IsNotNull(employees);
            Assert.IsTrue(employees.Count > 0);
            Employee testEmployee = employees.Where(e => e.EmployeeId == testEmployeeId).FirstOrDefault();
            Assert.IsNotNull(testEmployee);
            Assert.AreEqual("First Name", testEmployee.FirstName);
            Assert.AreEqual("Last Name", testEmployee.LastName);
            Assert.AreEqual(testDepartmentId, testEmployee.DepartmentId);
        }

        [TestMethod()]
        public void SearchTest()
        {
            //Arrange
            EmployeeSqlDAL dal = new EmployeeSqlDAL(ConnectionString);

            //Act
            List<Employee> employees = dal.Search("First Name", "Last Name");

            //Assert
            Assert.IsNotNull(employees);
            Assert.IsTrue(employees.Count > 0);
            Employee testEmployee = employees.Where(e => e.EmployeeId == testEmployeeId).FirstOrDefault();
            Assert.IsNotNull(testEmployee);
            Assert.AreEqual("First Name", testEmployee.FirstName);
            Assert.AreEqual("Last Name", testEmployee.LastName);
        }

        [TestMethod()]
        public void GetEmployeesWithoutProjectsTest()
        {
            //Arrange
            EmployeeSqlDAL dal = new EmployeeSqlDAL(ConnectionString);

            //Act
            List<Employee> employees = dal.GetEmployeesWithoutProjects();

            //Assert
            Assert.IsNotNull(employees);
            Assert.IsTrue(employees.Count > 0);
            Assert.IsNotNull(employees.Find(e => e.EmployeeId == testEmployeeId));
            Assert.IsNull(employees.Find(e => e.EmployeeId == testEmployeeIdAssignedToProject));
        }


    }
}

