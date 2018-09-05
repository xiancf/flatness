using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace XCore
{
   public  class XTask
    {
        private event Action<string, Color> OnStep;
        private event Action<int, int> OnCount;
        private Thread thread;
        private string name;
        private int taskId;
        private int stationId;
        private string logPath;
        private XMove move;
        private XSetDo setDo;
        private XWaitDi waitDi;       
        private XStation station;
        private Dictionary<int, XDi> diMap = new Dictionary<int, XDi>();
        private Dictionary<int, XDo> doMap = new Dictionary<int, XDo>();
        private Dictionary<int, XAxis> axisMap = new Dictionary<int, XAxis>();
        private Dictionary<int, XAxis> positionMap = new Dictionary<int, XAxis>();
        
        //public XTask(string logPath)
        //{
        //    this.logPath = logPath;
        //}
        public string Name
        {
            get
            {
                return name;
            }

            set
            {
                name = value;
            }
        }

        public int TaskId
        {
            get
            {
                return taskId;
            }

            set
            {
                taskId = value;
            }
        }
        public int StationId
        {
            get { return stationId; }
            set
            {
                this.stationId = value;

            }
        }
        public string LogPath
        {
            get { return logPath; }
            set { logPath = value; }
        }
        public Dictionary<int,XDi> DiMap { get { return diMap; } }
        public Dictionary<int,XDo> DoMap { get { return doMap; } }
        public Dictionary<int,XAxis> AxisMap { get { return axisMap; } }
        public Dictionary<int,XAxis> PositipnMap { get { return positionMap; } }
        public void RegisterAxis(int setAxisId)
        {
            if (axisMap.ContainsKey(setAxisId))
            {
                return;
            }
            axisMap.Add(setAxisId, XDevice.Instance.FindAxisById(setAxisId));
            XDevice.Instance.FindAxisById(setAxisId).TaskId = taskId;
        }
        public string SetStepStr { get; set; }
        public bool TaskHomeOK { get; set; }

        public void SetStep(string step,Color color)     //给事件OnSter设置参数
        {
            SetStepStr = step;
            if (OnStep != null)
            {
                OnStep(step, color);
            }
        }
        public void SetCount(int currentnum,int total)    ////给事件OnCount设置参数
        {
            if (OnCount!=null)
            {
                OnCount(currentnum, total);
            }
        }

        public void Start(object runMode)        //Task任务开始
        {
            if(thread!=null)
            {
                thread.Abort();
            }
            thread = new Thread(new ParameterizedThreadStart(Running)); //thread线程执行的方法为Running()
            thread.IsBackground = true;
            thread.Start();
        }
        public virtual void  Running(object runMode) { }
    }
}
