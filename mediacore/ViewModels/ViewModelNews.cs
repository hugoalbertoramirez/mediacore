using Microsoft.AspNetCore.Mvc.Rendering;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace mediacore.ViewModels
{
    public class ViewModelNews
    {
        public int idPublisher { get; set; }
        public int idTopic { get; set; }
        public int idState { get; set; }
        public string areImportants { get; set; }
        public int newsByPage { get; set; }

        public DateTime? startDate { get; set; }
        public DateTime? endDate { get; set; }
        public IEnumerable<Models.News> news { get; set; }

        public int PageIndex { get; set; }
        public int TotalPages { get; set; }
        public bool HasPreviousPage
        {
            get
            {
                return (PageIndex > 1);
            }
        }
        public bool HasNextPage
        {
            get
            {
                return (PageIndex < TotalPages);
            }
        }
    }
}
