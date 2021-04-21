namespace week2.day12
{
    class Program
    {
        public static void Main()
        {

            BlogPost post1 = new BlogPost(
                "John Doe",
                "Lorem Ipsum",
                "Lorem ipsum dolor sit amet",
                DateTime.Parse("2000.05.04").ToString("yyyy/MM/dd"));

            BlogPost post2 = new BlogPost(
                "Tim Urban",
                "Wait but why",
                "A popular long-form, stick-figure-illustrated blog about almost everything",
                DateTime.Parse("2010.10.10").ToString("yyyy/MM/dd"));

            BlogPost post3 = new BlogPost("William Turton",
                "One Engineer Is Trying to Get IBM to Reckon With Trump",
                "Daniel Hanley, a cybersecurity engineer at IBM, doesn’t want to be the center of attention. When I asked to take his picture outside one of IBM’s New York City offices, he told me that he wasn’t really into the whole organizer profile thing",
                DateTime.Parse("2017.03.28").ToString("yyyy/MM/dd"));


            Console.WriteLine(post1.PrintBlogPost());
            Console.WriteLine(post2.PrintBlogPost());
            Console.WriteLine(post3.PrintBlogPost());

        }
    }
}