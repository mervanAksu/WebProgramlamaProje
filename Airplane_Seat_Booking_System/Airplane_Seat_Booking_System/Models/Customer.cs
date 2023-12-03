using System.ComponentModel.DataAnnotations;

namespace Airplane_Seat_Booking_System.Models
{
	public class Customer
	{
		/* Müşteri Bilgileri */

		[Required(ErrorMessage = "Ad Alanı Boş Bırakılamaz")]
		[StringLength(20, ErrorMessage = "En Fazla 20 Karakter İçermelidir!")]
		public string? FirstName { get; set; } = String.Empty;
		[Required(ErrorMessage = "Lütfen Soyadınızı Giriniz!")]

		public string? LastName { get; set; } = String.Empty;
		public string? FullName => $"{FirstName?.ToUpperInvariant()} {LastName?.ToUpper()}";
		public int? Age { get; set; }

		/* İletişim Bilgileri */

		[Required(ErrorMessage = "Email Alanı Boş Bırakılamaz!")]
		[EmailAddress(ErrorMessage = "Lütfen Email'i Doğru Formda Giriniz!")]
		public string? Email { get; set; } = String.Empty;
		[Required(ErrorMessage = "Lütfen Telefon Numaranızı Giriniz!")]

		public string? PhoneNumber { get; set; } = String.Empty;
		
		/* Rezervasyon Bilgileri */
		public DateTime DepartureDate { get; set; }		// Kalkış Tarihi
		public DateTime ReturnDate { get; set; }		// Dönüş Tarihi
		public string? DepartureAirport { get; set; }	// Kalkış Havalimanı
		public string? ArrivalAirport { get; set; }		// Varış Havalimanı
		public string? FlightNumber { get; set; }		// Uçuş Numarası

        /* Ödeme Bilgileri */

        public string? CreditCardNumber { get; set; }	// Kredi Kartı Numarası
        public DateTime ExpiryDate { get; set; }		// SKT
        public int SecurityCode { get; set; }			// Güvenlik Numarası
        public decimal PaymentAmount { get; set; }		// Ödeme Tutarı

		
	}
}
