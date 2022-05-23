using System.ComponentModel.DataAnnotations;

namespace MVCPrimerEjemplo.Models
{
    public class Cinema_Room
    {
        public int Id { get; set; }
        public int NumberOfSeating { get; set; }
        public string RoomType { get; set; }
        public string ActualFilm { get; set; }
    }
}