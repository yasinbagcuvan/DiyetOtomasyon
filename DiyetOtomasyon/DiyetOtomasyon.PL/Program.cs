using DiyetOtomasyon.BL.Models;
using System.Security.Cryptography;
using System.Text;

namespace DiyetOtomasyon.PL
{
    internal static class Program
    {
        public static int LoginUserId { get; set; }
        public static PersonModel Person { get; set; }
        public static Form MainForm { get; set; }
        public static Form ActiveForm { get; set; }
        public static string sha256_hash(string sifre)
        {
            using (SHA256 hash = SHA256Managed.Create())
            {
                return string.Concat(hash.ComputeHash(Encoding.UTF8.GetBytes(sifre)).Select(l => l.ToString("X2")));
            }
        }
        /// <summary>
        ///  The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            // To customize application configuration such as set high DPI settings or default font,
            // see https://aka.ms/applicationconfiguration.
            ApplicationConfiguration.Initialize();
            Application.Run(new Form1());
        }
    }
}