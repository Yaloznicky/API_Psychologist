using DesktopPsychologist_WF.Models;

namespace DesktopPsychologist_WF.Services
{
    //public interface IDbService
    //{
    //    User GetUser(string login);
    //    List<Theme> GetThemes();
    //    List<Review> GetReviews();
    //    Review GetReview(int id);
    //    Theme GetTheme(int id);

    //    void SetUser(User user);
    //    void SetTheme(Theme theme);
    //    void SetReview(Review review);

    //    void EditReviews(int id, string text);
    //    void DeleteReviews(int id);
    //    void EditThemes(int id, string themeName, string text);
    //    void DeleteThemes(int id);
    //}

    //internal class DbService : IDbService
    //{
    //    private readonly AppContext context;

    //    public DbService(AppContext context)
    //    {
    //        this.context = context;
    //    }
    //    public List<Theme> GetThemes()
    //    {
    //        return context.Themes.ToList();
    //    }
    //    public List<Review> GetReviews()
    //    {
    //        return context.Reviews.ToList();
    //    }

    //    public User GetUser(string login)
    //    {
    //        return context.Users.FirstOrDefault(user => user.Login == login);
    //    }

    //    public void SetUser(User user)
    //    {
    //        context.Users.Add(user);
    //        context.SaveChanges();
    //    }

    //    public void SetTheme(Theme theme)
    //    {
    //        context.Themes.Add(theme);
    //        context.SaveChanges();
    //    }

    //    public void SetReview(Review review)
    //    {
    //        context.Reviews.Add(review);
    //        context.SaveChanges();
    //    }

    //    public void DeleteThemes(int id)
    //    {
    //        context.Themes.Remove(context.Themes.FirstOrDefault(theme => theme.id == id));
    //        context.SaveChanges();
    //    }

    //    public Theme GetTheme(int id)
    //    {
    //        return context.Themes.FirstOrDefault(theme => theme.id == id);
    //    }

    //    public void EditThemes(int id, string themeName, string text)
    //    {
    //        Theme theme = context.Themes.FirstOrDefault(t => t.id == id);
    //        if (theme != null)
    //        {
    //            theme.themeName = themeName;
    //            theme.text = text;
    //            context.SaveChanges();
    //        }
    //    }

    //    public Review GetReview(int id)
    //    {
    //        return context.Reviews.FirstOrDefault(review => review.Id == id);
    //    }

    //    public void EditReviews(int id, string text)
    //    {
    //        Review review = context.Reviews.FirstOrDefault(r => r.Id == id);
    //        if (review != null)
    //        {
    //            review.Text = text;
    //            context.SaveChanges();
    //        }
    //    }

    //    public void DeleteReviews(int id)
    //    {
    //        context.Reviews.Remove(context.Reviews.FirstOrDefault(review => review.Id == id));
    //        context.SaveChanges();
    //    }
    //}
}
