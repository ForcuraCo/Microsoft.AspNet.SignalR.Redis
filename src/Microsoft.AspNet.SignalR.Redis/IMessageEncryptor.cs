namespace Microsoft.AspNet.SignalR.Redis
{
    public interface IMessageEncryptor
    {
        byte[] Encrypt(byte[] input);
        byte[] Decrypt(byte[] input);
    }
}
