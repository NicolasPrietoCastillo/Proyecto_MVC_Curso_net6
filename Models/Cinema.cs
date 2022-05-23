using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace MVCPrimerEjemplo.Models
{
    public class Cinema
    {
        public int Id { get; set; }
        public string? Name { get; set; }
        public int? NumberOfRooms { get; set; }

        //public List<Cinema_Room> RoomsList = new List<Cinema_Room>();

        public decimal? Price { get; set; }
    }
}