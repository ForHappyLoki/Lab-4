﻿using CourceWork.Models;

namespace CourceWork.ViewModels
{
    public class TvshowModel
    {
        public Tvshow tvshow { get; set; }
        public Genre genre { get; set; }
        public int GenreId { get; set; } // Идентификатор жанра для привязки
        public List<TvshowEmployee> tvshowEmployee { get; set; } = new List<TvshowEmployee>();
        public List<Employee> employee { get; set; } = new List<Employee>();
        public List<TvshowEmployee> tvshowEmployeeNew { get; set; } = new List<TvshowEmployee>();
        public List<TvshowGuest> tvshowGuestsNew { get; set; } = new List<TvshowGuest>();
        public List<TvshowGuest> tvshowGuest { get; set; } = new List<TvshowGuest>();
        public List<Guest> guest { get; set; } = new List<Guest>();
        public int? SelectedEmployeeId { get; set; }
        public int? SelectedGuestId { get; set; }
        public List<Schedule> schedules { get; set; } = new List<Schedule>();

        public static AllEmployeesModel allEmployeesModel;
        public static AllGenresModel allGenresModel;
        public static AllGuestsModel allGuestsModel;
        public List<int> GetUniqueDate()
        {
            var uniqueYears = schedules
                .Select(s => s.Date.Value.Year) // Извлекаем год из каждой даты
                .Distinct() // Получаем уникальные года
                .OrderBy(year => year) // Сортируем по возрастанию
                .ToList(); // Преобразуем в список
            return uniqueYears;
        }
    }
}
