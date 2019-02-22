using MessageMicroservice.DataAccess;
using MessageMicroservice.Models;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.Web.Http;
using System.Web.Http.Results;

namespace MessageMicroservice.Tests
{
    [TestClass]
    public class MessageTest
    {
        [TestMethod]
        public void GetMessageByIdTest()
        {
            Controllers.MessageController messageController = new Controllers.MessageController();

            IHttpActionResult result = messageController.GetMessage(1);

            Assert.IsInstanceOfType(result, typeof(OkNegotiatedContentResult<Message>));
        }

        [TestMethod]
        public void GetAllMessagesTest()
        {
            Controllers.MessageController messageController = new Controllers.MessageController();

            IEnumerable<Message> result = messageController.GetAllMessages();

            Assert.IsNotInstanceOfType(result, typeof(OkNegotiatedContentResult<IEnumerable<Message>>));
        }

        [TestMethod]
        public void AddMessageSuccessfulTest()
        {
            Message testMessage = new Message()
            {
                vreme = DateTime.Now,
                tekst = DateTime.Now.ToLongDateString() + " test message",
                id_kanala = 1,
                id_ucesnik = 1
            };

            Controllers.MessageController messageController = new Controllers.MessageController();
            IHttpActionResult result = messageController.CreateMessageAsync(testMessage);
            Assert.IsInstanceOfType(result, typeof(OkNegotiatedContentResult<Message>));
        }

        [TestMethod]
        public void AddMessageFailedTest()
        {
            Message testMessage = new Message()
            {
                vreme = DateTime.Now,
                tekst = DateTime.Now.ToLongDateString() + " test message",
                id_kanala = -10,
                id_ucesnik = 1
            };

            Controllers.MessageController messageController = new Controllers.MessageController();
            IHttpActionResult result = messageController.CreateMessageAsync(testMessage);

            Assert.IsInstanceOfType(result, typeof(BadRequestResult));
        }

        [TestMethod]
        public void AddMessageNullTest()
        {
            Controllers.MessageController messageController = new Controllers.MessageController();
            IHttpActionResult result = messageController.CreateMessageAsync(null);

            Assert.IsInstanceOfType(result, typeof(BadRequestResult));
        }

        //[TestMethod]
        //public void RemoveMessageSuccessfulTest()
        //{
        //    Message testMessage = new Message()
        //    {
        //        vreme = DateTime.Now,
        //        tekst = DateTime.Now.ToLongDateString() + " test message",
        //        id_kanala = 1,
        //        id_ucesnik = 1
        //    };

        //    Controllers.MessageController messageController = new Controllers.MessageController();
        //    messageController.CreateMessageAsync(testMessage);
        //    IHttpActionResult result = messageController.DeleteMessage(testMessage.id_poruke);

        //    Assert.IsInstanceOfType(result, typeof(OkResult));
        //}

        [TestMethod]
        public void RemoveMessageFailTest()
        {
            Message testMessage = new Message()
            {
                vreme = DateTime.Now,
                tekst = DateTime.Now.ToString() + " test message",
                id_kanala = 1,
                id_ucesnik = 1
            };

            Controllers.MessageController messageController = new Controllers.MessageController();
            messageController.CreateMessageAsync(testMessage);
            IHttpActionResult result = messageController.DeleteMessage(-testMessage.id_poruke);

            Assert.IsInstanceOfType(result, typeof(BadRequestResult));
        }
    }
}
