// a paginated list class to handle pagination in the product
// The idea is I get a specific subset of the data records from products.
//
// We have a fixed page limit of 8 products per page.
//
// Suppose the dataset has n elements, and we have page index i, then:
//
//   page 0 has elements 
//   1 + 8*0, 2 + 8*0, 3, 4, 5, 6, 7, 8,
//
//   page 1 has elements
//   1 + 8*1, 2 + 8*1, 3 + 8*1, ..., 8 + 8*1
//   9, 10, 11, 12, 13, 14, 15, 16
//   n/i
//
//   page 2 has elements
//   1 + 8*2
//
//   i.e, skip the first 8*i elements, then return 8 elements
using System.Collections.Generic;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;

namespace VroomVroom.DataStructures
{
    public class PaginatedList<T> : List<T>
    {
        public int PageIndex { get; private set; }
        public int TotalPages { get; private set; }

        public PaginatedList(List<T> items, int count, int pageIndex, int pageSize)
        {
            PageIndex = pageIndex;
            // suppose 20 elements, and you want to determine how many pages for 3 elements per page:
            //  20/3  === 6.67 
            //  Now we round up to get 7 pages, where the 7th is not filled
            //  the casts is neccessary so we don't do integral division
            TotalPages = (int)Math.Ceiling(count / (double)pageSize);
            // calls List<T>'s AddRange - this paginated list inherits an T[] due to List<T>
            this.AddRange(items);
        }

        public bool HasPreviousPage => PageIndex > 1;

        public bool HasNextPage => PageIndex < TotalPages;
  
        // it has to be asynchronous as WE DO NOT WANT TO BLOCK ON IO
        public static async Task<PaginatedList<T>> CreateAsync(IQueryable<T> source, int pageIndex, int pageSize)
        {
            var count = await source.CountAsync();
            // we need pageIndex - 1, as we map the zero paginated list to page 1
            var skipAmount = (pageIndex - 1) * pageSize;
            if(skipAmount < 0){
              throw new Exception("ayo wattafack you crashed the server");
            }
            var items = await source.Skip((pageIndex - 1) * pageSize).Take(pageSize).ToListAsync();
            return new PaginatedList<T>(items, count, pageIndex, pageSize);
        }
    }


}
