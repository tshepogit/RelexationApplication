using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;

namespace RelexationApplication
{
    public class Repository
    {
        public List<Category> GetCategories()
        {
            return new List<Category>()
            {
                new Category(){ CategoryId = 1, CategoryName ="Funny Stories", ClassId = 1},
                new Category(){ CategoryId = 2, CategoryName ="Poems", ClassId = 1},
                new Category(){ CategoryId = 3, CategoryName ="Quotes", ClassId = 2}
            };
        }

        public List<Story> GetCategoryDetails(int categoryId)
        {
            var stories = new List<Story>();
            stories = Stories.Where(s => s.CategoryId == categoryId).ToList();
            return stories;
        }

        private readonly List<Story> Stories = new List<Story>()
        {
            new Story()
            {
                 Author ="James",
                 CategoryId = 1,
                 Title ="The fake report card",
                 Detail ="I failed the first quarter of a class in middle school, so I made a fake report card." +
                " I did this every quarter that year. I forgot that they mail home the end-of-year cards, and my mom got it before " +
                "I could intercept with my fake. She was PISSED—at the school for their error. The teacher also retired that year " +
                "and had already thrown out his records, so they had to take my mother’s proof (the fake ones I made throughout" +
                " the year) and correct the “mistake.” I’ve never told her the truth"
            },
            new Story()
            {
                Author="John",
                CategoryId = 1,
                Title ="Common Sense",
                Detail="During the heat of the space race in the 1960's, NASA quickly discovered that ballpoint pens would not work in the " +
                "zero gravity confines of its space capsules. After considerable research and development, the Astronaut Pen was developed " +
                "at a cost of $1 million. The pen worked in zero gravity, upside down, underwater, on almost any surface including glass and" +
                " also enjoyed some modest success as a novelty item back here on earth.The Soviet Union, when faced with the same " +
                "problem, used a pencil"
            },
            new Story()
            {
                Author="Lucas",
                CategoryId = 1,
                Title ="Smart Thinking",
                Detail="A dog thinks: Hey, these people I live with feed me, love me, provide me with a nice warm, dry house, pet me and take good" +
                " care of me...THEY MUST BE GODS!!!!! A cat thinks: Hey, these people I live with feed me, love me, provide me with a nice warm," +
                " dry house, pet me and take good care of me....I MUST BE A GOD"
            },
            new Story()
            {
                Author="Sarah",
                CategoryId = 2,
                Title ="Someday",
                Detail="Someday you will cry for me" +
                "Like I cried for you." +
                "Someday you'll miss me" +
                "Like I missed you." +
                "Someday you'll need me" +
                "Like I needed you." +
                "Someday you'll love me," +
                "But I won't love you."
            },
            new Story()
            {
                Author="Jessica",
                CategoryId = 2,
                Title ="Tiny little secrets" +
                 "Get buried in the dirt," +
                 "And if they were dug up," +
                 "Someone would probably get hurt," +
                 "So leave them safely there," +
                 "To rot amongst the leaves," +
                 "Admiring instead," +
                 "The truth in summer's green trees."
            },
            new Story()
            {
                Author="Jessica",
                CategoryId = 3,
                Title="",
                Detail="I am on a seafood diet. I see food, and I eat it."
            },
            new Story()
            {
                Author="Jimmy",
                CategoryId = 3,
                Title="",
                Detail="Alcohol! Because no great story started with someone eating a salad"
            },
            new Story()
            {
                Author="Jimmy",
                CategoryId = 3,
                Title="",
                Detail="I don't need a hair stylist, my pillow gives me a new hairstyle every morning."
            }
        };
    }
}
