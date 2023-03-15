using Microsoft.VisualStudio.TestTools.UnitTesting;
using AddressBookServices;

namespace AddressBookServices
{
    [TestClass]
    public class UnitTestClass
    {
        // Common arrange for the entire MS Test Cases
        public static AddressBookRepository bookRepository = new AddressBookRepository();
        // Instance of the address book model so as to create a entity for addition
        public static AddressBookModel addressBookModel = new AddressBookModel();
        // TC 1 -- Check For Update of the Record and integrity of update method
        [TestMethod]
        public void EditUsingNameAndCheckForUpdate()
        {
            // Act
            bool expected = true;
            // Invoking the edit contact using name method so as to update the contact type
            // Meghana -First name for the data row
            // Family - New contact type
            // 1 - update for contact type, 2- update the address book name
            bool actual = bookRepository.EditContactUsingName("Meghana", "Family", 1);
            /// Assert
            Assert.AreEqual(expected, actual);
        }
        // TC 2 -- Check For Delete of the Record and integrity of delete method
        [TestMethod]
        public void DeleteUsingNameAndCheckForDelete()
        {
            // Act
            bool expected = true;
            // Invoking the delete contact using  first name method so as to delete the contact type
            // Meghana -First name for the data row
            bool actual = bookRepository.DeleteContactUsingName("Meghana");
            // Assert
            Assert.AreEqual(expected, actual);
        }
        // TC 3 -- Check For Addition of the Record and integrity of add to record method
        [TestMethod]
        public void AddUsingInstanceOfAddressBookModelAndCheckForAdd()
        {
            // Act
            bool expected = true;
            // Initialising the instances with the values of the data attributes
            addressBookModel = new AddressBookModel
            {
                firstName = "Sanjana",
                secondName = "Macha",
                address = "Sec-5",
                city = "Hyderabad",
                state = "TS",
                zip = 482005,
                phoneNumber = 98784565,
                emailId = "sanjana@gmail.com",
                contactType = "Profession",
                addressBookName = "MyRecord"
            };
            // Invoking the add contact using the instance of the address bookmodel class so as to add the record
            bool actual = bookRepository.AddDataToTable(addressBookModel);
            // Assert
            Assert.AreEqual(expected, actual);
        }
        // TC 4 -- Check For Update of the Record and integrity of update method after the update
        [TestMethod]
        public void CheckUsingNameAndForUpdateAfterTheUpdate()
        {
            // Act
            int expected = 1;
            // Invoking the edit contact using name method so as to update the contact type
            // Shruthi -First name for the data row
            // Family - New contact type
            // 1 - update for contact type, 2- update the address book name
            bool actualAfterUpdate = bookRepository.EditContactUsingName("Shruthi", "Friends", 1);
            int actual = bookRepository.GetTheUpdatedData("Shruthi", "Friends", 1);
            // Assert
            Assert.AreEqual(expected, actual);
        }
    }
}