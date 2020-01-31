using CandyShop.Domain.Models;
using Microsoft.EntityFrameworkCore;
using System;

namespace CandyShop.Persistence
{
    public static class AppDatabaseSeeder
    {
        public static void SeedCategoryData(this ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Category>(entity => 
            entity.HasData(new Category { 
                CategoryId = 1,
                CategoryName = "Chocolate Candy"
            },
            new Category { 
                CategoryId = 2,
                CategoryName = "Fruit Candy"
            },
            new Category { 
                CategoryId = 3,
                CategoryName = "Gummy Candy"
            },
            new Category { 
                CategoryId = 4,
                CategoryName = "Halloween Candy"
            },
            new Category { 
                CategoryId = 5,
                 CategoryName = "Hard Candy"
            }));
        }

        public static void SeedCandyData(this ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Candy>(entity => entity.HasData(
                new Candy { 
                    CandyId = 1,
                    Name = "Assorted Chocolate Candy",
                    Price = 4.95m,
                    Description = "Lorem ipsum dolor sit amet, consectetur adipiscing elit. Nulla sit amet nibh eget erat scelerisque rhoncus sed quis nisi.",
                    CategoryId = 1,
                    ImageUrl = "\\images\\chocolateCandy.jpg",
                    ImageThumbnailUrl = "\\images\\thumbnails\\chocolateCandy-small.jpg",
                    IsInStock = true,
                    IsOnSale = false
                },
                new Candy
                {
                    CandyId = 2,
                    Name = "Another Assorted Chocolate Candy",
                    Price = 3.95m,
                    Description = "Sed rutrum libero velit, a imperdiet purus posuere ultricies. Quisque ultrices nulla nec tortor luctus blandit.",
                    CategoryId = 1,
                    ImageUrl = "\\images\\chocolateCandy2.jpg",
                    ImageThumbnailUrl = "\\images\\thumbnails\\chocolateCandy2-small.jpg",
                    IsInStock = true,
                    IsOnSale = true
                },
                new Candy
                {
                    CandyId = 3,
                    Name = "Assorted Chocolate Candy",
                    Price = 5.75m,
                    Description = "Phasellus dolor augue, blandit a tincidunt eget, egestas sed lacus. Etiam varius leo nec tortor faucibus luctus.",
                    CategoryId = 1,
                    ImageUrl = "\\images\\chocolateCandy3.jpg",
                    ImageThumbnailUrl = "\\images\\thumbnails\\chocolateCandy3-small.jpg",
                    IsInStock = true,
                    IsOnSale = false
                },
                new Candy
                {
                    CandyId = 4,
                    Name = "Assorted Fruit Candy",
                    Price = 3.95m,
                    Description = "Donec tempus, diam quis dictum tincidunt, ex neque rutrum ligula, eget congue nunc lorem eu magna.",
                    CategoryId = 2,
                    ImageUrl = "\\images\\fruitCandy.jpg",
                    ImageThumbnailUrl = "\\images\\thumbnails\\fruitCandy-small.jpg",
                    IsInStock = true,
                    IsOnSale = false
                },
                new Candy
                {
                    CandyId = 5,
                    Name = "Fruit Candy",
                    Price = 7.00m,
                    Description = "Sed at ex placerat, ultrices urna elementum, laoreet ligula. Nullam vitae odio sit amet magna faucibus euismod varius vel tortor.",
                    CategoryId = 2,
                    ImageUrl = "\\images\\fruiteCandy2.jpg",
                    ImageThumbnailUrl = "\\images\\thumbnails\\fruitCandy2-small.jpg",
                    IsInStock = true,
                    IsOnSale = true
                }, new Candy
                {
                    CandyId = 6,
                    Name = "Assorted Assorted Fruit Candy",
                    Price = 11.25m,
                    Description = "Nulla placerat ante ut eros eleifend sagittis. Nulla facilisi. Praesent maximus libero nec justo lobortis tempus.",
                    CategoryId = 2,
                    ImageUrl = "\\images\\fruitCandy3.jpg",
                    ImageThumbnailUrl = "\\images\\thumbnails\\fruitCandy3-small.jpg",
                    IsInStock = true,
                    IsOnSale = true
                },
                new Candy
                {
                    CandyId = 7,
                    Name = "Assorted Gummy Candy",
                    Price = 3.95m,
                    Description = "Cras in magna eget velit mollis fringilla sed sed est. In felis massa, volutpat sed iaculis sit amet, eleifend aliquam nisi.",
                    CategoryId = 3,
                    ImageUrl = "\\images\\gummyCandy.jpg",
                    ImageThumbnailUrl = "\\images\\thumbnails\\gummyCandy-small.jpg",
                    IsInStock = true,
                    IsOnSale = true
                },
                new Candy
                {
                    CandyId = 8,
                    Name = "Assorted Assorted Gummy Candy",
                    Price = 1.95m,
                    Description = "In fermentum ex vitae semper facilisis. Aenean fringilla sagittis arcu, vel posuere justo bibendum eu.",
                    CategoryId = 3,
                    ImageUrl = "\\images\\gummyCandy2.jpg",
                    ImageThumbnailUrl = "\\images\\thumbnails\\gummyCandy2-small.jpg",
                    IsInStock = true,
                    IsOnSale = false
                },
                new Candy
                {
                    CandyId = 9,
                    Name = "Gummy Candy",
                    Price = 13.95m,
                    Description = "Vestibulum venenatis porttitor ipsum. Vestibulum ac tincidunt ex. Sed convallis turpis quis enim varius, id dignissim dui eleifend.",
                    CategoryId = 3,
                    ImageUrl = "\\images\\gummyCandy3.jpg",
                    ImageThumbnailUrl = "\\images\\thumbnails\\gummyCandy3-small.jpg",
                    IsInStock = true,
                    IsOnSale = false
                },
                new Candy
                {
                    CandyId = 10,
                    Name = "Halloween Candy",
                    Price = 1.95m,
                    Description = "Morbi eu justo sed nulla suscipit consectetur ut a ligula. Fusce eu lorem quis lorem vulputate porta.",
                    CategoryId = 4,
                    ImageUrl = "\\images\\halloweenCandy.jpg",
                    ImageThumbnailUrl = "\\images\\thumbnails\\halloweenCandy-small.jpg",
                    IsInStock = true,
                    IsOnSale = true
                },
                new Candy
                {
                    CandyId = 11,
                    Name = "Assorted Halloween Candy",
                    Price = 12.95m,
                    Description = "Aenean eu enim tincidunt, porttitor magna quis, lacinia neque. Vestibulum erat enim, porttitor eget arcu et, fringilla lacinia lectus.",
                    CategoryId = 4,
                    ImageUrl = "\\images\\halloweenCandy2.jpg",
                    ImageThumbnailUrl = "\\images\\thumbnails\\halloweenCandy2-small.jpg",
                    IsInStock = true,
                    IsOnSale = true
                },
                new Candy
                {
                    CandyId = 12,
                    Name = "Another Halloween Candy",
                    Price = 21.95m,
                    Description = "Phasellus quis quam lorem. Nulla et eros malesuada, blandit lorem ac, pellentesque magna.",
                    CategoryId = 4,
                    ImageUrl = "\\images\\halloweenCandy3.jpg",
                    ImageThumbnailUrl = "\\images\\thumbnails\\halloweenCandy3-small.jpg",
                    IsInStock = true,
                    IsOnSale = true
                },
                new Candy
                {
                    CandyId = 13,
                    Name = "Hard Candy",
                    Price = 6.95m,
                    Description = "Sed metus libero, maximus placerat maximus in, elementum non velit. In vel nibh massa. Ut ultricies ut mauris eget venenatis.",
                    CategoryId = 5,
                    ImageUrl = "\\images\\hardCandy.jpg",
                    ImageThumbnailUrl = "\\images\\thumbnails\\hardCandy-small.jpg",
                    IsInStock = true,
                    IsOnSale = false
                },
                new Candy
                {
                    CandyId = 14,
                    Name = "Another Hard Candy",
                    Price = 2.95m,
                    Description = "Proin consequat dapibus nunc non tempus. Cras maximus, mauris ac ullamcorper dignissim, est tellus accumsan mauris, id semper augue erat eu ex.",
                    CategoryId = 5,
                    ImageUrl = "\\images\\hardCandy2.jpg",
                    ImageThumbnailUrl = "\\images\\thumbnails\\hardCandy2-small.jpg",
                    IsInStock = true,
                    IsOnSale = true
                },
                new Candy
                {
                    CandyId = 15,
                    Name = "Best Hard Candy",
                    Price = 16.95m,
                    Description = "Nulla luctus euismod nunc eget pretium. Suspendisse mollis ultrices erat, imperdiet accumsan mi blandit et. Integer laoreet eget sem a suscipit.",
                    CategoryId = 5,
                    ImageUrl = "\\images\\hardeCandy3.jpg",
                    ImageThumbnailUrl = "\\images\\thumbnails\\hardCandy3-small.jpg",
                    IsInStock = true,
                    IsOnSale = false
                }));
        }
    }
}
