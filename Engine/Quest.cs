using System;
using System.Collections.Generic;
using System.Text;

namespace Engine
{
    public class Quest
    {
        public int ID { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public int RewardExperiencePoints { get; set; }
        public int RewardGold { get; set; }
        public Item RewardItem { get; set; }
        public List<QuestCompletionItem> QuestCompletionItem { get; set; }

        public Quest(int id, string name, string description, int rewardExp, int rewardGold, Item rewardItem = null)
        {
            ID = id;
            Name = name;
            Description = description;
            RewardExperiencePoints = rewardExp;
            RewardGold = rewardGold;
            RewardItem = rewardItem;
            QuestCompletionItem = new List<QuestCompletionItem>();
        }
    }
}
