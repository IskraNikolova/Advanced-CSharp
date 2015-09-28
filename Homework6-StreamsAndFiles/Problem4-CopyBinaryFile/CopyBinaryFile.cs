
using System.IO;

public class CopyBinaryFile
{
    private const string PicturePath = "Picture.jpg";
    private const string CopyPath = "Copy-picture.jpg";
    /// <summary>
    /// A program that copies the contents of a binary file (e.g. image, video, etc.) to another using FileStream. 
    /// You are not allowed to use the File class or similar helper classes.
    /// </summary>
    public static void Main()
    {
        FileStream inputStream = new FileStream(PicturePath, FileMode.Open);
        FileStream outputStream = new FileStream(CopyPath, FileMode.Create);

        using (inputStream)
        {
            using (outputStream)
            {
                byte[] buffer = new byte[4096];

                while (true)
                {
                    int readBytes = inputStream.Read(buffer, 0, buffer.Length);
                    if (readBytes == 0)
                    {
                        break;
                    }
                    outputStream.Write(buffer, 0, readBytes);
                }
            }
        }
        System.Diagnostics.Process.Start("Copy-picture.jpg");
    }
}
  

