using System.ComponentModel.DataAnnotations;
using TaskPlanner.Models;

namespace TaskPlanner.UnitTests
{
    [TestFixture]
    public class TastItemTests
    {
        [Test]
        public void UnitCode_ValidCode_Accepted()
        {
            // Arrange
            var taskItem = new TaskItem();

            // Act
            taskItem.UnitCode = "ABC123";

            // Assert
            Assert.That(taskItem.UnitCode, Is.EqualTo("ABC123"));
        }

        [Test]
        public void UnitCode_SetNull_ThrowsValidationException()
        {
            // Arrange
            var taskItem = new TaskItem();

            // Act and Assert
            Assert.Throws<NullReferenceException>(() => taskItem.UnitCode = null);
        }

        [Test]
        public void TaskName_ValidName_Accepted()
        {
            // Arrange
            var taskItem = new TaskItem();

            // Act
            taskItem.Name = "Task 1";

            // Assert
            Assert.That(taskItem.Name, Is.EqualTo("Task 1"));
        }

        [Test]
        public void TaskComment_SetNull_Accepted()
        {
            // Arrange
            var taskItem = new TaskItem();

            // Act
            taskItem.Comments = null;

            // Assert
            Assert.That(taskItem.Comments, Is.EqualTo(null));
        }

        [Test]
        public void TaskComment_ValidComment_Accepted()
        {
            // Arrange
            var taskItem = new TaskItem();

            // Act
            taskItem.Comments = "task comment";

            // Assert
            Assert.That(taskItem.Comments, Is.EqualTo("task comment"));
        }

        [Test]
        public void TaskDueDate_ValidDate_Accepted()
        {
            // Arrange
            var taskItem = new TaskItem();
            DateTime expectedDueDate = new DateTime(1986, 05, 20);

            // Act
            taskItem.DueDate = new DateTime(1986, 05, 20);

            // Assert
            Assert.That(taskItem.DueDate, Is.EqualTo(expectedDueDate));
        }

        [Test]
        public void TaskCompletedDate_Accepted()
        {
            // Arrange
            var taskItem = new TaskItem();
            DateTime expectedDueDate = new DateTime(1986, 05, 20);

            // Act
            taskItem.CompletedDate = new DateTime(1986, 05, 20);

            // Assert
            Assert.That(taskItem.CompletedDate, Is.EqualTo(expectedDueDate));
        }

        [Test]
        public void TaskCompletedDate_SetNull_Accepted()
        {
            // Arrange
            var taskItem = new TaskItem();

            // Act
            taskItem.CompletedDate = null;

            // Assert
            Assert.That(taskItem.CompletedDate, Is.EqualTo(null));
        }

        [Test]
        public void TaskIsCompleteFlag_IsFalse()
        {
            // Arrange
            var taskItem = new TaskItem();

            // Act
            taskItem.IsComplete = false;

            // Assert
            Assert.That(taskItem.IsComplete, Is.EqualTo(false));
        }

        [Test]
        public void TaskIsCompleteFlag_IsTrue()
        {
            // Arrange
            var taskItem = new TaskItem();

            // Act
            taskItem.IsComplete = true;

            // Assert
            Assert.That(taskItem.IsComplete, Is.EqualTo(true));
        }
    }
}