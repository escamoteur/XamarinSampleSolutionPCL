namespace XamarinSampleSolutionPCL
{
    public interface IFileStorage
    {       
        string ReadAsString(string filename);
        byte[] ReadAsBytes(string filename);
    }
}