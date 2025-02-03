using BookManager.Core.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BookManager.UnitTests.Core
{
    public class UserTests
    {
        [Fact]
        public void UserIsCreated_Success()
        {
            // Arrange
            var user = new User("João da silva", "joao@gmail.com", DateTime.Now);
        }
    }
}
