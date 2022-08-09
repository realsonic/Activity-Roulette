using System;
using System.IO;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Activity_Roulette.Classes
{
    class ActivityItemsList
    {
        // Контейнер текущих активностей
        public static Dictionary<string, ActivityItem> activityItemsContainer;
        // Общий вес файла активностей
        private static float overallActivityListWeight;

        public ActivityItemsList()
        {
            Dictionary<string, ActivityItem> Container = new Dictionary<string, ActivityItem>();
            foreach (string line in File.ReadLines(Roulette.activityListPath))
            {
                ActivityItem activity = new ActivityItem(line);
                Container.Add(activity.name, activity);
            }
            activityItemsContainer = Container;
        }
        public Dictionary<string, ActivityItem> GetActivityItemsContainer()
        {
            return activityItemsContainer;
        }
        public void SetOverallActivityListWeight(Dictionary<string, ActivityItem> Container)
        {
            int sum = 0;
            foreach (KeyValuePair<string, ActivityItem> activity in Container)
            {
                sum += activity.Value.activityListItemWeight;
            }
            overallActivityListWeight = sum;
        }
        public float GetOverallActivityListWeight()
        {
            return overallActivityListWeight;
        }
    }

}
