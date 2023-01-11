using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using YemekTarifiApp.Entity.Concrate;

namespace YemekTarifiApp.Data.Config
{
    public class FoodComentConfig : IEntityTypeConfiguration<FoodComment>
    {
        public void Configure(EntityTypeBuilder<FoodComment> builder)
        {
            builder.HasKey(fco => new { fco.FoodId, fco.CommentId });

            builder.ToTable("FoodComments");

            builder.HasData(

                //Burada her yemeğe bir yorum yapılacak ve her yemeğe birden fazla yorum yapılabilir şeklinde bir tasarım yapmak istedim.

                new FoodComment { FoodId = 1, CommentId = 10 },
                new FoodComment { FoodId = 2, CommentId = 9 },
                new FoodComment { FoodId = 3, CommentId = 8 },
                new FoodComment { FoodId = 4, CommentId = 7 },
                new FoodComment { FoodId = 5, CommentId = 6 },
                new FoodComment { FoodId = 6, CommentId = 5 },
                new FoodComment { FoodId = 7, CommentId = 4 },
                new FoodComment { FoodId = 8, CommentId = 3 },
                new FoodComment { FoodId = 9, CommentId = 2 },
                new FoodComment { FoodId = 10, CommentId = 1 },
                new FoodComment { FoodId = 11, CommentId = 2 },
                new FoodComment { FoodId = 12, CommentId = 3 },
                new FoodComment { FoodId = 13, CommentId = 4 },
                new FoodComment { FoodId = 14, CommentId = 5 },
                new FoodComment { FoodId = 15, CommentId = 6 },
                new FoodComment { FoodId = 16, CommentId = 7 },
                new FoodComment { FoodId = 17, CommentId = 8 },
                new FoodComment { FoodId = 18, CommentId = 9 },
                new FoodComment { FoodId = 19, CommentId = 10 },
                new FoodComment { FoodId = 20, CommentId = 9 },
                new FoodComment { FoodId = 21, CommentId = 8 },
                new FoodComment { FoodId = 22, CommentId = 7 },
                new FoodComment { FoodId = 23, CommentId = 6 },
                new FoodComment { FoodId = 24, CommentId = 5 },
                new FoodComment { FoodId = 25, CommentId = 4 },
                new FoodComment { FoodId = 26, CommentId = 3 },
                new FoodComment { FoodId = 27, CommentId = 2 },
                new FoodComment { FoodId = 28, CommentId = 1 },
                new FoodComment { FoodId = 29, CommentId = 2 },
                new FoodComment { FoodId = 30, CommentId = 3 },
                new FoodComment { FoodId = 31, CommentId = 4 },
                new FoodComment { FoodId = 32, CommentId = 5 },
                new FoodComment { FoodId = 33, CommentId = 6 },
                new FoodComment { FoodId = 34, CommentId = 7 },
                new FoodComment { FoodId = 35, CommentId = 8 },
                new FoodComment { FoodId = 36, CommentId = 9 },
                new FoodComment { FoodId = 37, CommentId = 10 },
                new FoodComment { FoodId = 38, CommentId = 9 },
                new FoodComment { FoodId = 39, CommentId = 8 },
                new FoodComment { FoodId = 40, CommentId = 7 }
                );


        }
    }
}
