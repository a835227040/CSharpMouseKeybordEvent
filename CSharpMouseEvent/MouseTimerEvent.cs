using System;
using System.Collections.Generic;
using System.Text;

namespace CSharpMouseKeybordEvent
{
    /// <summary>
    /// 周期性的模拟鼠标事件
    /// </summary>
    public class MouseTimerEvent
    {
        public int Millisecond
        {
            get { return _Millisecond; }
            set { _Millisecond = value; }
        }
        private int _Millisecond;
        /// <summary>
        /// 按照指定的间隔封装一个周期性鼠标事件，并直接开始。
        /// </summary>
        /// <param name="Millisecond">周期，毫秒为单位</param>
        /// <param name="eventType">周期事件类型</param>
        /// <param name="isRepeat">是否重复? 如果不重复，可以当做是延迟事件</param>
        /// <returns></returns>
        public static MouseTimerEvent TimerStart(int Millisecond, MouseEventType eventType,bool isRepeat)
        {
            return null;
        }
        public MouseTimerEvent()
        {

        }
        /// <summary>
        /// 开始模拟
        /// </summary>
        public void Start()
        {

        }
        /// <summary>
        /// 结束模拟，结束模拟会释放掉所有占用的资源，如果要暂时停止，请使用<see cref="Pause"/>函数。
        /// </summary>
        public void End()
        {

        }
        /// <summary>
        /// 暂停模拟
        /// </summary>
        public void Pause()
        {

        }
    }
}
