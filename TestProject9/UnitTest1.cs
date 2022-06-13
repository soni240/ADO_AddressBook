using AddressBook;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace TestProject9
{
    [TestClass]
    public class UnitTest1
    {
        AddressBookRespitory addressBookRepository;
        [TestInitialize]
        public void SetUp()
        {
            addressBookRepository = new AddressBookRespitory();
        }

        //Usecase 2:Ability to insert new Contacts to Address Book
        [TestMethod]
        public void TestMethodInsertIntoTable()
        {
            int expected = 1;
            ContactDataManager addressBook = new ContactDataManager();
            addressBook.FirstName = "Rani";
            addressBook.LastName = "Malvi";
            addressBook.Address = "Baker's Street";
            addressBook.City = "Chennai";
            addressBook.State = "TamilNadu";
            addressBook.zip = 243022;
            addressBook.PhoneNumber = 9842905050;
            addressBook.Email = "rani@gmail.com";
            addressBook.AddressBookName = "FriendName";
            addressBook.Type = "Friends";
            int actual = addressBookRepository.InsertIntoTable(addressBook);
            Assert.AreEqual(expected, actual);
        }
        //UseCase 3: Modify Existing Contact using their name
        [TestMethod]
        public void GivenUpdateQuery_ReturnOne()
        {
            int expected = 1;
            int actual = addressBookRepository.UpdateQueryBasedonName();
            Assert.AreEqual(expected, actual);
        }
        //UseCase 4: Delete person based on Name
        [TestMethod]
        public void GivenDeleteQuery_ReturnOne()
        {
            int expected = 1;
            int actual = addressBookRepository.DeletePersonBasedonName();
            Assert.AreEqual(expected, actual);
        }
        //UseCase 5: Ability to Retrieve Person belonging to a City or State from the Address Book
        [TestMethod]
        public void GivenRetrieveQuery_ReturnString()
        {
            string expected = "Harsha Pramela meena ";
            string actual = addressBookRepository.PrintDataBasedOnCity("Bangalore", "Karnataka");
            Assert.AreEqual(expected, actual);
        }
        //UC 6: Ability to Retrieve Count of Person belonging to a City or State
        [TestMethod]
        public void GivenCountQuery_ReturnString()
        {
            string expected = "2 1 3 1 ";
            string actual = addressBookRepository.PrintCountDataBasedOnCityorState();
            Assert.AreEqual(expected, actual);
        }
        //UC 7: Ability to retrieve entries sorted alphabetically
        [TestMethod]
        public void GivenSortQuery_ReturnString()
        {
            string expected = "Harsha Pramela ";
            string actual = addressBookRepository.PrintSortDataBasedOnCity("Bangalore");
            Assert.AreEqual(expected, actual);
        }
        //UC 8: Ability to get number of contact persons by Type
        [TestMethod]
        public void GivenCountTypeQuery_ReturnString()
        {
            string expected = "1 5 1 ";
            string actual = addressBookRepository.ContactDataBasedOnType();
            Assert.AreEqual(expected, actual);
        }
    }


}

    


