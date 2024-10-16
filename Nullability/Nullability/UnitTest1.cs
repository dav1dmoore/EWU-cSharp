namespace Nullability
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void FirstName_SetProperty_Success()
        {

            Person person = new("Inigo", "Montoya");
            person.FirstName = "Inigo";

            Assert.AreEqual("Inigo", person.FirstName);

        }

        [TestMethod]
        public void FirstName_NotNull_DefaultValue()
        {

            Person person = new("Inigo", "Montoya");

            Assert.IsNotNull(person.FirstName);
        }

        [TestMethod]
        [ExpectedException(typeof(ArgumentNullException))]
        public void FirstName_Null_ArgumentNullException()
        {

            Assert.ThrowsException<ArgumentException>(
                () => new Person(null!, null!));
        }

        [TestMethod]
        [ExpectedException(typeof(ArgumentNullException))]
        public void FirstName_SetNull_ArgumentNullException()
        {

            Person person = new("Inigo", "Montoya");
            person.FirstName = null!;

            Assert.ThrowsException<ArgumentException>(
                () => new Person(null!, null!));
        }

        [TestMethod]
        public void Names_NotNull_DefaultValue()
        {

            Person person = new("Inigo", "Montoyo");

            Assert.IsNotNull(person.FirstName);
            Assert.IsNotNull(person.LastName);
        }

        [TestMethod]
        public void Ctor_InigoMontoya_Success()
        {

            Person person = new("Inigo", "Montoya");

            (string firstName, string lastName) = person;
            Assert.AreEqual(("Inigo", "Montoya"), firstName, person.FirstName);
        }
    }
}