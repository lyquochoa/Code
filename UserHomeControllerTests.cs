using System;
using JustBook;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using JustBook.Controllers;
using JustBook.Models;
using System.Web.Mvc;
using Moq;


namespace JustBook_Tests.TestScripts.UserHomeControllerTests
{
    [TestClass]
    public class UserHomeControllerTest
    {
        [TestMethod]
        public void UserEditInformation_WithCorrectInputValue_SuccessfulFix()
        {
            // Arange
            UserHomeController userHomeController = new UserHomeController();
            DateTime dt2 = new DateTime(2001, 05, 29);

            TaiKhoanKH model = new TaiKhoanKH()
            {
                MaKH = 21,
                Email = "hoa123@gmail.com",
                MatKhau = "123456",
                TenKH = "Lý Quốc Hòa",
                DiaChi = "Long An",
                Phone = 53535353,
                GioiTinh = "Nam",
                NgaySinh = dt2
            };
            var mock = new Mock<ControllerContext>();
            var mockSession = new Mock<System.Web.HttpSessionStateBase>();
            mock.Setup(p => p.HttpContext.Session).Returns(mockSession.Object);
            userHomeController.ControllerContext = mock.Object;

            // Action
            var result = userHomeController.UserEditInformation(model) as RedirectToRouteResult;
            // Assert
            Assert.AreEqual(result.RouteValues["action"], "Index");
        }

        [TestMethod]
        public void UserEditInformation_EnterEmail_SuccessfulFix()
        {
            // Arange
            UserHomeController userHomeController = new UserHomeController();

            TaiKhoanKH model = new TaiKhoanKH()
            {
                Email = "hoa123@gmail.com"
            };
            var mock = new Mock<ControllerContext>();
            var mockSession = new Mock<System.Web.HttpSessionStateBase>();
            mock.Setup(p => p.HttpContext.Session).Returns(mockSession.Object);
            userHomeController.ControllerContext = mock.Object;

            // Action
            var result = userHomeController.UserEditInformation(model) as RedirectToRouteResult;
            // Assert
            Assert.AreEqual(result.RouteValues["action"], "Index");
        }

        [TestMethod]
        public void UserEditInformation_EnterName_SuccessfulFix()
        {
            // Arange
            UserHomeController userHomeController = new UserHomeController();

            TaiKhoanKH model = new TaiKhoanKH()
            {
                TenKH = "Lý Quốc Hòa"
            };
            var mock = new Mock<ControllerContext>();
            var mockSession = new Mock<System.Web.HttpSessionStateBase>();
            mock.Setup(p => p.HttpContext.Session).Returns(mockSession.Object);
            userHomeController.ControllerContext = mock.Object;

            // Action
            var result = userHomeController.UserEditInformation(model) as RedirectToRouteResult;
            // Assert
            Assert.AreEqual(result.RouteValues["action"], "Index");
        }

        [TestMethod]
        public void UserEditInformation_EnterAddress_SuccessfulFix()
        {
            // Arange
            UserHomeController userHomeController = new UserHomeController();

            TaiKhoanKH model = new TaiKhoanKH()
            {
                DiaChi = "Long An"
            };
            var mock = new Mock<ControllerContext>();
            var mockSession = new Mock<System.Web.HttpSessionStateBase>();
            mock.Setup(p => p.HttpContext.Session).Returns(mockSession.Object);
            userHomeController.ControllerContext = mock.Object;

            // Action
            var result = userHomeController.UserEditInformation(model) as RedirectToRouteResult;
            // Assert
            Assert.AreEqual(result.RouteValues["action"], "Index");
        }

        [TestMethod]
        public void UserEditInformation_EnterPhone_SuccessfulFix()
        {
            // Arange
            UserHomeController userHomeController = new UserHomeController();

            TaiKhoanKH model = new TaiKhoanKH()
            {
                Phone = 53535353
            };
            var mock = new Mock<ControllerContext>();
            var mockSession = new Mock<System.Web.HttpSessionStateBase>();
            mock.Setup(p => p.HttpContext.Session).Returns(mockSession.Object);
            userHomeController.ControllerContext = mock.Object;

            // Action
            var result = userHomeController.UserEditInformation(model) as RedirectToRouteResult;
            // Assert
            Assert.AreEqual(result.RouteValues["action"], "Index");
        }

        [TestMethod]
        public void UserEditInformation_ChooseGender_SuccessfulFix()
        {
            // Arange
            UserHomeController userHomeController = new UserHomeController();

            TaiKhoanKH model = new TaiKhoanKH()
            {
                GioiTinh = "Nam"
            };
            var mock = new Mock<ControllerContext>();
            var mockSession = new Mock<System.Web.HttpSessionStateBase>();
            mock.Setup(p => p.HttpContext.Session).Returns(mockSession.Object);
            userHomeController.ControllerContext = mock.Object;

            // Action
            var result = userHomeController.UserEditInformation(model) as RedirectToRouteResult;
            // Assert
            Assert.AreEqual(result.RouteValues["action"], "Index");
        }

        [TestMethod]
        public void UserEditInformation_ChooseDateofbirth_SuccessfulFix()
        {
            // Arange
            UserHomeController userHomeController = new UserHomeController();
            DateTime dt2 = new DateTime(2001, 05, 29);

            TaiKhoanKH model = new TaiKhoanKH()
            {
                NgaySinh = dt2
            };
            var mock = new Mock<ControllerContext>();
            var mockSession = new Mock<System.Web.HttpSessionStateBase>();
            mock.Setup(p => p.HttpContext.Session).Returns(mockSession.Object);
            userHomeController.ControllerContext = mock.Object;

            // Action
            var result = userHomeController.UserEditInformation(model) as RedirectToRouteResult;
            // Assert
            Assert.AreEqual(result.RouteValues["action"], "Index");
        }

        [TestMethod]
        public void OrderHistory_OrderSuccess_OrderCreationSuccessful()
        {
            // Arange
            UserHomeController userHomeController = new UserHomeController();

            ChiTietDonHang model = new ChiTietDonHang()
            {
                MaDonHang = 45,

            };
            var mock = new Mock<ControllerContext>();
            var mockSession = new Mock<System.Web.HttpSessionStateBase>();
            mock.Setup(p => p.HttpContext.Session).Returns(mockSession.Object);
            userHomeController.ControllerContext = mock.Object;

            // Action
            var result = userHomeController.OrderUserDetail(model) as RedirectToRouteResult;
            // Assert
            Assert.AreEqual(result.RouteValues["action"], "Index");
        }
    }
}
