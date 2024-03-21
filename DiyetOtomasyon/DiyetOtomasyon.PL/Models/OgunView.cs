using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DiyetOtomasyon.PL.Models
{
    public class OgunView
    {
           public string YemekAdi { get; set;}
           public int PorsiyonMiktari{ get; set;}
           public int HesaplanmışKalori { get; set;}
           public string OgunAdi { get; set;}
           public DateTime Tarih { get; set;}
           public string PersonMealCreatedId { get; set;}
    }
}
