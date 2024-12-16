using System.Text.Json.Serialization;

namespace Excercise6
{
    internal static class Program
    {
        /// <summary>
        ///  The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            // To customize application configuration such as set high DPI settings or default font,
            // see https://aka.ms/applicationconfiguration.
            ApplicationConfiguration.Initialize();
            Application.Run(new LogIn());
        }
    }
    public class MonAn
    {
        [JsonPropertyName("id")]
        public int Id { get; set; }
        [JsonPropertyName("ten_mon_an")]
        public string TenMonAn { get; set; }
        [JsonPropertyName("gia")]
        public double Gia { get; set; }
        [JsonPropertyName("dia_chi")]
        public string DiaChi { get; set; }
        [JsonPropertyName("hinh_anh")]
        public string HinhAnh { get; set; }
        [JsonPropertyName("mo_ta")]
        public string MoTa { get; set; }
        [JsonPropertyName("nguoi_dong_gop")]
        public string NguoiDongGop { get; set; }
    }
    public class User
    {
        private static User _instance;
        public string TokenType;
        public string AccessToken;
        private User() { }
        public static User Instance
        {
            get
            {
                if (_instance == null)
                    _instance = new User();
                return _instance;
            }
        }
    }

}