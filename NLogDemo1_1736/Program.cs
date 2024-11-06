using NLog;


namespace NLogDemo1_1736
{
    internal class Program
    {
        //Logger 是Nlog提供日誌紀錄類型Logger 類提供了多種方法來記錄不同級別的日誌（如 Info, Error, Warn, Debug 等）
        //GetCurrentClassLogger()為創建一個日誌紀錄器
        private static readonly Logger logger = LogManager.GetCurrentClassLogger();
        static void Main(string[] args)
        {

            // 記錄日誌
            logger.Info("這是一條 Info 級別的日誌訊息");
            logger.Error("這是一條 Error 級別的日誌訊息");

            Console.WriteLine("日誌已經記錄完成！");
        }
    }
}
