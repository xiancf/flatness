using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace XCore

{
   public sealed class XTaskManage
    {
        private Dictionary<int, XTask> taskMap = new Dictionary<int, XTask>();
        private readonly static XTaskManage instance = new XTaskManage();
        public static XTaskManage Instance { get { return instance; } }
        public Dictionary <int,XTask> TaskMap { get { return taskMap; } }
        public void BindTask(int taskId,XTask task,string name)
        {
            if (taskMap .ContainsKey(taskId)==false)
            {
                task.TaskId = taskId;
                task.Name = name;
                taskMap.Add(taskId, task);
            }
        }
        public XTask FindTaskById(int taskId)
        {
            if (taskMap.ContainsKey(taskId))
            {
                return taskMap[taskId];
            }
            return null;
        }

    }
}
