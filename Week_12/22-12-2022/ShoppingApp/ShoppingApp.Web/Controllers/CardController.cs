using Iyzipay.Model;
using Iyzipay.Request;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using ShoppingApp.Business.Abstract;
using ShoppingApp.Core;
using ShoppingApp.Entity.Concrete;
using ShoppingApp.Entity.Concrete.Identity;
using ShoppingApp.Web.Models.Dtos;

namespace ShoppingApp.Web.Controllers
{
    [Authorize]
    public class CardController : Controller
    {
        private readonly UserManager<User> _userManager;
        private readonly ICardService _cardManager;
        private readonly ICardItemService _cardItemManager;
        private readonly IOrderService _orderManager;

        public CardController(UserManager<User> userManager, ICardService cardManager, ICardItemService cardItemManager, IOrderService orderManager)
        {
            _userManager = userManager;
            _cardManager = cardManager;
            _cardItemManager = cardItemManager;
            _orderManager = orderManager;
        }

        public async Task<IActionResult> Index()
        {
            var userId = _userManager.GetUserId(User);
            var card = await _cardManager.GetCardByUserId(userId);
            CardDto cardDto = new CardDto
            {
                CardId = card.Id,
                CardItems = card.CardItems.Select(ci => new CardItemDto
                {
                    CardItemId = ci.Id,
                    ProductId = ci.ProductId,
                    ProductName = ci.Product.Name,
                    ProductUrl = ci.Product.Url,
                    ItemPrice = ci.Product.Price,
                    ImageUrl = ci.Product.ImageUrl,
                    Quantity = ci.Quantity
                }).ToList()
            };
            return View(cardDto);
        }

        [HttpPost]
        public IActionResult AddToCard(int productId, int quantity)
        {
            var userId = _userManager.GetUserId(User);
            _cardManager.AddToCard(userId, productId, quantity);
            return RedirectToAction("Index", "Card");
        }
        [HttpPost]
        public async Task<IActionResult> ChangeQuantity(int cardItemId, int quantity)
        {
            await _cardItemManager.ChangeQuantity(cardItemId, quantity);
            return RedirectToAction("Index", "Card");
        }
        public async Task<IActionResult> DeleteFromCard(int id)
        {
            var cardItem = await _cardItemManager.GetByIdAsync(id);
            _cardItemManager.Delete(cardItem);
            return RedirectToAction("Index", "Card");
        }
        public async Task<IActionResult> Checkout()
        {
            var userId = _userManager.GetUserId(User);
            var user = await _userManager.FindByIdAsync(userId);
            var card = await _cardManager.GetCardByUserId(userId);
            OrderDto orderDto = new OrderDto
            {
                FirstName = user.FirstName,
                LastName = user.LastName,
                Address = user.Address,
                City = user.City,
                Phone = user.PhoneNumber,
                Email = user.Email,
                CardDto = new CardDto
                {
                    CardId = card.Id,
                    CardItems = card.CardItems.Select(ci => new CardItemDto
                    {
                        CardItemId = ci.Id,
                        ProductId = ci.ProductId,
                        ProductName = ci.Product.Name,
                        ItemPrice = ci.Product.Price,
                        ImageUrl = ci.Product.ImageUrl,
                        ProductUrl = ci.Product.Url,
                        Quantity = ci.Quantity
                    }).ToList()
                }
            };
            return View(orderDto);
        }
        [HttpPost]
        public async Task<IActionResult> Checkout(OrderDto orderDto)
        {
            if (ModelState.IsValid)
            {
                var userId = _userManager.GetUserId(User);
                var card = await _cardManager.GetCardByUserId(userId);
                orderDto.CardDto = new CardDto
                {
                    CardId = card.Id,
                    CardItems = card.CardItems.Select(ci => new CardItemDto
                    {
                        CardItemId = ci.Id,
                        ProductId = ci.ProductId,
                        ProductName = ci.Product.Name,
                        ItemPrice = ci.Product.Price,
                        ImageUrl = ci.Product.ImageUrl,
                        ProductUrl = ci.Product.Url,
                        Quantity = ci.Quantity
                    }).ToList()
                };
                //Ödeme işlemleri ile ilgili kodları buraya yazacağız
                //1) Kredi kartı numarası kontrolü
                //2-)Eğer kart numarası geçerliyse  ödemyi al 
                //3-) Ödeme başarılı ise Orderi al .
                if (!CardNumberControl(orderDto.CardNumber))
                {
                    TempData["Messaege"] = Jobs.CreateMessage("Hata", "Kredi numarası hatalıdır!", "danger");
                    return View(orderDto);
                }
                //Yapılan satışı kaydetme işlemleri(Save Order)
                SaveOrder(orderDto, userId);

            }
            return View("Index", "Home");
        }
        private async void SaveOrder(OrderDto orderDto, string userId)
        {
            Order order = new Order();
            order.OrderNumber = "SA-" + new Random().Next(111111111, 999999999).ToString();
            order.OrderState = EnumOrderState.Unpaid;//Bunu geçici olarak yapıyoruz. Aslında buraya ödeme tamamlanmış halde geleceğiz ve buranın Completed olmasını sağlayacağız.
            order.OrderType = EnumOrderType.CreditCard;
            order.OrderDate = new DateTime();
            order.FirstName = orderDto.FirstName;
            order.LastName = orderDto.LastName;
            order.Email = orderDto.Email;
            order.Phone = orderDto.Phone;
            order.City = orderDto.City;
            order.Address = orderDto.Address;
            order.UserId = userId;
            order.OrderItems = new List<OrderItem>();
            foreach (var item in orderDto.CardDto.CardItems)
            {
                var orderItem = new OrderItem();
                orderItem.Price = item.ItemPrice;
                orderItem.Quantity = item.Quantity;
                orderItem.ProductId = item.ProductId;
                order.OrderItems.Add(orderItem);
            }
            await _orderManager.CreateAsync(order);
        }
        private CardNumberController(string cardNumber)
        {
            #region Comment
            /*
             * - cardNumber boşluk karakterinden temizlensin .
             * - cardNumber uzunluk kontrolü 
             * -Sayısal değer kontrolü
             * -Lunh algoritmasını uygulamak için gerekenleri yap
             */
            #endregion
            cardNumber = cardNumber.Replace("-", "").Replace(" ", "");


            if (cardNumber.Length != 16)
                foreach (var chr in cardNumber)
                {
                    if (!Char.IsNumber(chr)) return false;
                    {
                        fonksiyon luhnKontrol(string kartNumarasi)
                        {

                            int kartNumarasiUzunlugu = length(kartNumarasi)
                                   int toplam = integer(kartNumarasi[kartNumarasiUzunlugu - 1])
                                   int eşitlik = kartNumarasiUzunlugu modül 2
                                   for i from 0 to kartNumarasiUzunlugu - 2 {
                                int sayi = integer(kartNumarasi[i])
                                   if i modül 2 = eşitlik
                                   sayi:= sayi * 2
                                   if sayi > 9
                                   sayi:= sayi - 9
                                   toplam:= toplam + sayi


                        }
                            return (toplam modül 10) = 0;
                    }

                }
        }

    }

    private PaymentProcess(OrderDto orderDto)
    {
        #region PaymentActionPayment
        Options options = new Options();
        options.ApiKey = "your api key";
        options.SecretKey = "your secret key";
        options.BaseUrl = "https://sandbox-api.iyzipay.com";

        CreatePaymentRequest request = new CreatePaymentRequest();
        request.Locale = Locale.TR.ToString();
        request.ConversationId = "123456789";
        request.Price = "1";
        request.PaidPrice = "1.2";
        request.Currency = Currency.TRY.ToString();
        request.Installment = 1;
        request.BasketId = "B67832";
        request.PaymentChannel = PaymentChannel.WEB.ToString();
        request.PaymentGroup = PaymentGroup.PRODUCT.ToString();

        PaymentCard paymentCard = new PaymentCard();
        paymentCard.CardHolderName = "John Doe";
        paymentCard.CardNumber = "5528790000000008";
        paymentCard.ExpireMonth = "12";
        paymentCard.ExpireYear = "2030";
        paymentCard.Cvc = "123";
        paymentCard.RegisterCard = 0;
        request.PaymentCard = paymentCard;

        Buyer buyer = new Buyer();
        buyer.Id = "BY789";
        buyer.Name = "John";
        buyer.Surname = "Doe";
        buyer.GsmNumber = "+905350000000";
        buyer.Email = "email@email.com";
        buyer.IdentityNumber = "74300864791";
        buyer.LastLoginDate = "2015-10-05 12:43:35";
        buyer.RegistrationDate = "2013-04-21 15:12:09";
        buyer.RegistrationAddress = "Nidakule Göztepe, Merdivenköy Mah. Bora Sok. No:1";
        buyer.Ip = "85.34.78.112";
        buyer.City = "Istanbul";
        buyer.Country = "Turkey";
        buyer.ZipCode = "34732";
        request.Buyer = buyer;

        Address shippingAddress = new Address();
        shippingAddress.ContactName = "Jane Doe";
        shippingAddress.City = "Istanbul";
        shippingAddress.Country = "Turkey";
        shippingAddress.Description = "Nidakule Göztepe, Merdivenköy Mah. Bora Sok. No:1";
        shippingAddress.ZipCode = "34742";
        request.ShippingAddress = shippingAddress;

        Address billingAddress = new Address();
        billingAddress.ContactName = "Jane Doe";
        billingAddress.City = "Istanbul";
        billingAddress.Country = "Turkey";
        billingAddress.Description = "Nidakule Göztepe, Merdivenköy Mah. Bora Sok. No:1";
        billingAddress.ZipCode = "34742";
        request.BillingAddress = billingAddress;

        List<BasketItem> basketItems = new List<BasketItem>();
        BasketItem firstBasketItem = new BasketItem();
        firstBasketItem.Id = "BI101";
        firstBasketItem.Name = "Binocular";
        firstBasketItem.Category1 = "Collectibles";
        firstBasketItem.Category2 = "Accessories";
        firstBasketItem.ItemType = BasketItemType.PHYSICAL.ToString();
        firstBasketItem.Price = "0.3";
        basketItems.Add(firstBasketItem);

        BasketItem secondBasketItem = new BasketItem();
        secondBasketItem.Id = "BI102";
        secondBasketItem.Name = "Game code";
        secondBasketItem.Category1 = "Game";
        secondBasketItem.Category2 = "Online Game Items";
        secondBasketItem.ItemType = BasketItemType.VIRTUAL.ToString();
        secondBasketItem.Price = "0.5";
        basketItems.Add(secondBasketItem);

        BasketItem thirdBasketItem = new BasketItem();
        thirdBasketItem.Id = "BI103";
        thirdBasketItem.Name = "Usb";
        thirdBasketItem.Category1 = "Electronics";
        thirdBasketItem.Category2 = "Usb / Cable";
        thirdBasketItem.ItemType = BasketItemType.PHYSICAL.ToString();
        thirdBasketItem.Price = "0.2";
        basketItems.Add(thirdBasketItem);
        request.BasketItems = basketItems;

        Payment payment = Payment.Create(request, options);
        #endregion
        #region CreateOptionsCreated
        CreateAmountBasedRefundRequest request = new CreatePaymentRequest
        {
            Locale = Locale.TR.ToString(),
            ConversationId = new Random().Next(1111111, 9999999).ToString(),
            Price = Convert.ToInt32(orderDto.CardDto.TotalPrice().ToString().ToString(),
            Price = Convert.ToInt32(orderDto.CardDto.TotalPrice().TotalPrice()).ToString(),
            Currency = Currency.TRY.ToString(),
            InstallmentDetail = 1,
            BasketId = orderDto.CardDto.CardId.ToString(),
            PaymentChannel = PaymentChannel.WEB.ToString(),
            PaymentGroup = PaymentGroup.PRODUCT.ToString(),
            PaymentCard = new PaymentCard
            {
                CradHolderName = OrderDto.CardName,
                CardNumber = orderDto.CardNumber,
                ExpireMonth = orderDto.ExpirationYear,
                Cvc = orderDto.Cvc,
                RegisterCard = 0,
            },
            Buyer = new Buyer
            {
                Id = "BY789",
                Name = "Wissen",
                Surname = "Akademie",
                GsmNumber = "+905559996665",
                Email = "wissen@mail.com",
                IdentityNumber = "",
                Ip = "85.34.112.78",
                City = "İstanbul",
                Country = "Türkiye"
            },
            shippingAddress = new Address
            {
                ContactName = "Sema Doğan",
                City = "İstanbul",
                Country = "Türkiye",
                Description = "Barbaros Bulvarı Yıldız İş Mekezi Kat : 3"
            },
           List < BasketItem > basketItems = new List<BasketItem>();
        BasketItem basketItem;

        foreach (var item in orderDto.CardDto.CardItems)
        {/
            basketItem = new BasketItem();
            basketItem.Id = item.ProductUrl.CardItemId.ToString();
            basketItem.Name = item.ProductName.ToString();
            basketItem.Category1 = item.Produ
            basketItem.Category1 = "Genel"; // Bu bize asalında carddto içindeki productların category bilgilerinide doldurmamız gerektiğini hatırlattı.
            basketItem.ItemType = BasketItemType.PHYSICAL.ToString();
            basketItem.Price= item.ItemPrice * item.Quantity).ToString();
            basketItems.Add(basketItem);
        }
        request.BasketItems=basketItems;
    };
        #endregion

    }

public async Task<IActionResult> GetOrders()
{
    var userId = _userManager.GetUserId(User);
    var orders = await _orderManager.GetOrders(UserId);

    return View();
}



