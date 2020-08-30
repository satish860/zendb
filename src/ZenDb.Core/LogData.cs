using System;
using System.IO;

namespace ZenDb.Core
{
    public class LogData : IDisposable
    {
        private readonly StreamWriter streamWriter;

        public LogData(StreamWriter streamWriter)
        {
            this.streamWriter = streamWriter;
        }

        public bool AddData(string key,string data)
        {
            this.streamWriter.Write(key + data);
            return false;
        }

        /// <summary>
        /// Read about Proper Disposable Pattern and dispose the stream. 
        /// Not sure if I can hold onto file stream
        /// </summary>
        public void Dispose()
        {
            this.streamWriter.Close();
            GC.SuppressFinalize(this);
        }
    }
}
