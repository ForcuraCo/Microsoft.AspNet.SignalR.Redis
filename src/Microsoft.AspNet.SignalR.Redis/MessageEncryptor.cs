namespace Microsoft.AspNet.SignalR.Redis
{
    public class MessageEncryptor : IMessageEncryptor
    {
        public byte[] Encrypt(byte[] input)
        {
            return input;
        }

        public byte[] Decrypt(byte[] input)
        {
            return input;
        }        
    }
}
