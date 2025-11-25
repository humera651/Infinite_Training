using Moq;

namespace Day6Assignment1
{
    public class Tests
    {
        //Quesiton-1
        [Test]
        public void Add_ShouldReturn5_AndVerifyCalledOnce()
        {
            var mockCalc = new Mock<ICalculator>();
            mockCalc.Setup(x => x.Add(2, 3)).Returns(5);
            int result = mockCalc.Object.Add(2, 3);
            Assert.That(result, Is.EqualTo(5));

            mockCalc.Verify(x => x.Add(2, 3), Times.Once);
        }

        //Quesiton-2
        [Test]
        public void GetCustomerName_ShouldReturnJohn_WhenIdIs1()
        {
            var mockRepo = new Mock<ICustomerRepository>();
            mockRepo.Setup(r => r.GetCustomerById(1))
                    .Returns(new Customer { Name = "John" });
            var service = new CustomerService(mockRepo.Object);
            var result = service.GetCustomerName(1);

            Assert.That(result, Is.EqualTo("John"));
        }
    }
}
