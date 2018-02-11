using System;
using System.Collections.Generic;
using NUnit.Framework;
using SuperSaaS.CSharp.SDK;

namespace SuperSaaS.CSharp.Tests
{
    [TestFixture()]
    public class AppointmentsTest
    {
        public Client Client;

        [SetUp]
        public void Init()
        {
            Configuration config = new Configuration();
            config.AccountName = "accnt";
            config.Password = "pwd";
            config.Test = true;

            this.Client = new Client(config);
        }

        [Test()]
        public void GetTest()
        {
            Assert.DoesNotThrow(() => { this.Client.Appointments.Get(123, 456); });
        }

        [Test()]
        public void ListTest()
        {
            Assert.DoesNotThrow(() => { this.Client.Appointments.List(123, true, DateTime.Now, 10); });
        }

        [Test()]
        public void CreateTest()
        {
            Assert.DoesNotThrow(() => { this.Client.Appointments.Create(123, 789, this.AppointmentArgs()); });
        }

        private Dictionary<string, string> AppointmentArgs()
        {
            return new Dictionary<string, string> {
                {"description", "Testing"},
                {"name", "Test"},
                {"email", "test@example.com"},
                {"full_name", "Tester Test"},
                {"address", "123 St, City"},
                {"mobile", "555-5555"},
                {"phone", "555-5555"},
                {"country", "FR"},
                {"field_1", "f 1"},
                {"field_2", "f 2"},
                {"field_1_r", "f 1 r"},
                {"field_2_r", "f 2 r"},
                {"super_field", "sf"}
            };
        }
    }
}
