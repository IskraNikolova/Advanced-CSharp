namespace Problem1_ClassStudent
{
    public static class ExtensionMethod
    {
        public static bool IsHasTwoMarks(this Student student)
        {
            if (student.Marks.Count == 2)
            {
                return true;
            }
            return false;
        }
    }
}
