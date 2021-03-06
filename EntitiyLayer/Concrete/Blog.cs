using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntitiyLayer.Concrete
{
    public class Blog
    {
        [Key]
        public int BlogID { get; set; }
        public string BlogTitle { get; set; }
        public string BlogContent { get; set; }
        public string BlogThumbnailImage { get; set; }//Kucuk Resım Demek
        public string BlogImage { get; set; }
        public DateTime BlogCreateDate { get; set; }
        public bool  BlogStatus { get; set; }
        public int  CategoryID { get; set; }
        public Category Categorys { get; set; }
        public IQueryable<Comment> Comments { get; set; }
    }
}
