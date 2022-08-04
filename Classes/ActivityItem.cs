using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Activity_Roulette.Classes
{
    class ActivityItem
    {
        //контейнер для всех объектов из списка. А нужен ли он?
        public ActivityItem[] activityItems;

        // поле имени класса
        public string name;

        // вес активности из списка (дергать из файла). А int ли это тогда это вообще, потому что остальные что-то блин???
        public int activityListItemWeight;

        // вес активности относительно файла активностей определяется путём деления activityListItemWeight на сумму activityListItemWeight всех активностей в файле. А int ли это вообще???
        public int relativeActivtyListItemWeight;

        // вес активности относительно файла с логами определяется путём деления количества попаданий активности в этот самый лог на общее число записей в нём. А int ли это вообще???
        public int relativeLogFileItemWeight;

        // относительный невыбранный вес активности определяется путём вычитания relativeLogFileItemWeight из relativeActivtyListItemWeight. А int ли это вообще???
        public int nonSelectionRelativeItemWeight;

        // Допилить конструктор
        public ActivityItem()
        {
            
        }
    }
}