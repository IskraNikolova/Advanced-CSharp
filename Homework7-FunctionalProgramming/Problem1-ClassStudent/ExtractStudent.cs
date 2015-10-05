namespace Problem1_ClassStudent
{
    public static class ExtractStudent
    {
        public static bool IsEnrolled(this Student student)
        {
            string year = "14";
            if (student.FacultyNumber.Substring(4, 2) == year)
            {
                return true;
            }
            return false;
        }
    }
}
