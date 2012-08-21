using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data.Entity;
using AspForum.Models;

namespace AspForum.DAL
{
    public class ForumInitializer : DropCreateDatabaseIfModelChanges<ForumContext>
    {
        protected override void Seed(ForumContext context)
        {
            var categories = new List<Category>
            {
                new Category { CategoryID = 1, Description = "Les catégories accessibles de tous", Parent = 0, Title = "Public" },
                new Category { CategoryID = 2, Description = "Les catégories accessibles des membres", Parent = 0, Title = "Privé" },
                new Category { CategoryID = 3, Description = "Racontez votre vie", Parent = 1, Title = "Bla bla" },
                new Category { CategoryID = 4, Description = "De tout et de rien", Parent = 1, Title = "Tout et rien" },
                new Category { CategoryID = 5, Description = "Présentation des membres", Parent = 2, Title = "Présentations" },
                new Category { CategoryID = 6, Description = "Présentez-nous vos jeux préférés", Parent = 2, Title = "Jeux" },
                new Category { CategoryID = 3, Description = "Racontez votre vie", Parent = 2, Title = "Bla bla des membres" }
            };
            categories.ForEach(s => context.Categories.Add(s));
            context.SaveChanges();

            var topics = new List<Topic>
            {
                new Topic { CategoryID = 6, TopicID = 1, Description = "Découvrez Mass Effect", Title = "Mass Effect"},
                new Topic { CategoryID = 6, TopicID = 2, Description = "Découvrez Minecraft", Title = "Minecraft"},
                new Topic { CategoryID = 6, TopicID = 3, Description = "Découvrez Battlefield 3", Title = "Battlefield 3"},
                new Topic { CategoryID = 6, TopicID = 4, Description = "Découvrez The Secret World", Title = "The Secret World"},
                new Topic { CategoryID = 5, TopicID = 5, Description = "La vie de Robert", Title = "Robert"},
                new Topic { CategoryID = 5, TopicID = 6, Description = "La vie de Freddy", Title = "Freddy"}
            };
            topics.ForEach(s => context.Topics.Add(s));
            context.SaveChanges();

            var posts = new List<Post>
            {
                new Post { PostID = 1, TopicID = 1, Message = "C'est un jeu trop pourri bla bla bla...", PostingDate = DateTime.Parse("2012-07-01") },
                new Post { PostID = 2, TopicID = 1, Message = "Même pas vrai sale troll !.", PostingDate = DateTime.Parse("2012-07-01") },
                new Post { PostID = 3, TopicID = 2, Message = "C'est un jeu avec des cubes", PostingDate = DateTime.Parse("2012-07-08") },
                new Post { PostID = 4, TopicID = 3, Message = "C'est un jeu trop pourri bla bla bla...", PostingDate = DateTime.Parse("2012-07-01") },
                new Post { PostID = 5, TopicID = 4, Message = "C'est un MEUPORG !!!", PostingDate = DateTime.Parse("2012-08-21") },
                new Post { PostID = 5, TopicID = 5, Message = "Je m'appelle Robert pis voilà quoi !", PostingDate = DateTime.Parse("2012-07-14") },
                new Post { PostID = 5, TopicID = 6, Message = "Lol ! Alors moi... Ben en fait... Lol quoi ! Ptdr", PostingDate = DateTime.Parse("2012-07-29") }
            };
            posts.ForEach(s => context.Posts.Add(s));
            context.SaveChanges();
        }
    }
}