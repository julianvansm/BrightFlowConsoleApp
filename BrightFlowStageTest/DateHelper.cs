class DateHelper
{
    public string GetCurrentDate()
    {
        string currentDate = DateTime.Now.ToString("dd-MM-yyyy");
        return currentDate;
    }
}