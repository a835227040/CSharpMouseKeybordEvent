using System;
using System.Windows.Forms;
namespace CSharpMouseKeybordEvent
{
    public class MouseEvent
    {
        public int MouseX
        {
            set { }
            get { return _MouseX; }
        }
        public int MouseY
        {
            set { }
            get { return _MouseY; }
        }
        private int _MouseX;
        private int _MouseY;
        public MouseEvent()
        {

        }
        /// <summary>
        /// 设置鼠标的坐标值，左上角为(0,0) 右下角为(分辨率x,分辨率y)
        /// </summary>
        /// <param name="x">鼠标的x值</param>
        /// <param name="y">鼠标的y值</param>
        public void SetMousePos(int x,int y)
        {

        }
        /// <summary>
        /// 设置鼠标的x坐标值，左上角为(0,0) 右下角为(分辨率x,分辨率y)
        /// </summary>
        /// <param name="x">鼠标的x值</param>
        public void SetMouseX(int x)
        {

        }
        /// <summary>
        /// 设置鼠标的y坐标值，左上角为(0,0) 右下角为(分辨率x,分辨率y)
        /// </summary>
        /// <param name="y">鼠标的y值</param>
        public void SetMouseY(int y)
        {

        }
        /// <summary>
        /// 设置鼠标的位置(根据WinForm窗口)
        /// </summary>
        /// <param name="window">需要相对的窗口</param>
        /// <param name="x">鼠标的x坐标</param>
        /// <param name="y">鼠标的y坐标</param>
        public void SetMousePosFromWindow(Form window,int x,int y)
        {

        }
        /// <summary>
        /// 设置鼠标的位置(根据控件的位置)
        /// </summary>
        /// <param name="window">需要相对的控件</param>
        /// <param name="x">鼠标的x坐标</param>
        /// <param name="y">鼠标的y坐标</param>
        public void SetMousePosFromWindow(Control control, int x, int y)
        {

        }
        /// <summary>
        /// 设置鼠标的位置(根据窗口/控件句柄)
        /// </summary>
        /// <param name="window">窗口句柄</param>
        /// <param name="x">鼠标的x坐标</param>
        /// <param name="y">鼠标的y坐标</param>
        public void SetMousePosFromWindow(IntPtr hWnd, int x, int y)
        {

        }
        /// <summary>
        /// 按照偏移量移动鼠标,负数向左(上),正数向右(下)
        /// <para/>如果遇到滚动失败(遇到屏幕边缘)，该函数会停止运行并返回false
        /// <para/>滚动失败的情况下，【不会】移动鼠标位置
        /// </summary>
        /// 
        /// <param name="x"></param>
        /// <param name="y"></param>
        /// <returns></returns>
        public bool SetMousePosOffset(int x,int y)
        {
            return true;
        }
        /// <summary>
        /// 按照偏移量移动鼠标,负数向左(上),正数向右(下)
        /// <para/>如果目标偏移量已经超出屏幕范围，函数会修正坐标，使其不会超过屏幕范围。
        /// <para/>无论是否执行成功，该函数总是会移动鼠标指针。除非传入了(0,0)，或鼠标指针已在屏幕四个角。
        /// </summary>
        /// <param name="x"></param>
        /// <param name="y"></param>
        public void SetMousePosOffsetEx(int x,int y)
        {

        }
        /// <summary>
        /// 按照偏移量移动鼠标,距离只能为正数，输入负数会抛出异常,角度为角度制[0°,360°)
        /// <para/>参数输入的角度值超出此范围时,函数会修正角度值到有效值.
        /// </summary>
        /// <param name="distance"></param>
        /// <param name="regAngle">角度值</param>
        /// <exception cref="MissingMemberException"></exception>
        public void SetMousePosOffsetAngle(float distance, float regAngle)
        {

        }
        /// <summary>
        /// 模拟右键双击
        /// </summary>
        public void RightDoubleClick()
        {

        }
        /// <summary>
        /// 模拟左键双击
        /// </summary>
        public void LeftDoubleClick()
        {

        }
        /// <summary>
        /// 模拟右键单击
        /// </summary>
        public void RightClick()
        {

        }
        /// <summary>
        /// 模拟左键单击
        /// </summary>
        public void LeftClick()
        {

        }
        /// <summary>
        /// 指定地点模拟左键双击后将鼠标指针移回原来位置，左上角为(0,0) 右下角为(分辨率x,分辨率y)
        /// </summary>
        /// <param name="x">要指定的x坐标</param>
        /// <param name="y">要指定的y坐标</param>
        public void LeftDoubleClick(int x,int y)
        {

        }
        /// <summary>
        /// 指定地点模拟左键单击后将鼠标指针移回原来位置，左上角为(0,0) 右下角为(分辨率x,分辨率y)
        /// </summary>
        /// <param name="x">要指定的x坐标</param>
        /// <param name="y">要指定的y坐标</param>
        public void LeftClick(int x,int y)
        {

        }
        /// <summary>
        /// 指定地点模拟右键单击后将鼠标指针移回原来位置，左上角为(0,0) 右下角为(分辨率x,分辨率y)
        /// </summary>
        /// <param name="x">要指定的x坐标</param>
        /// <param name="y">要指定的y坐标</param>
        public void RightClick(int x, int y)
        {

        }
        /// <summary>
        /// 模拟左键多次点击，注意number不能为负数
        /// </summary>
        /// <param name="number"></param>
        /// <exception cref="MissingMemberException">参数为负数时，将抛出该异常</exception>
        public void RepeatLeftClick(int number)
        {

        }
        /// <summary>
        /// 模拟右键多次点击，注意number不能为负数
        /// </summary>
        /// <param name="number"></param>
        /// <exception cref="MissingMemberException">参数为负数时，将抛出该异常</exception>
        public void RepeatRightClick(int number)
        {

        }
        /// <summary>
        /// 点击一下滚轮
        /// </summary>
        public void ClickWheel()
        {

        }
        /// <summary>
        /// 向上滑动滚轮
        /// </summary>
        /// <param name="delta">滚动量,默认120</param>
        public void UpWheel(int delta=120)
        {

        }
        /// <summary>
        /// 向下滑动滚轮
        /// </summary>
        /// <param name="delta"></param>
        public void DownWheel(int delta = 120)
        {

        }
        
    }
}
