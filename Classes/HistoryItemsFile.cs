using System;
using System.IO;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Activity_Roulette.Classes
{
    class HistoryItemsFile
    {
        // Общий размер файла истории
        private static int historyLogSize;
        public static void WriteHistoryLogLine()
        {

        }
        public static void SetHistoryLogSize()
        {
            historyLogSize = File.ReadLines(Roulette.historyLogPath).Count();
        }
        public static int GetHistoryLogSize()
        {
            return historyLogSize;
        }
    }
}
