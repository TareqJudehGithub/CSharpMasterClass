namespace FirstClass
{
    internal class HotelBooking
    {
        #region Fields
        public string GustName;
        public DateTime StartDate;
        public DateTime EndDate;
        #endregion

        #region Contstructors
        HotelBooking(string guestName, DateTime startDate, int lengthOfStayInDays)
        {
            GustName = guestName;
            StartDate = startDate;
            EndDate = StartDate.AddDays(lengthOfStayInDays);
        }
        #endregion
    }
}
