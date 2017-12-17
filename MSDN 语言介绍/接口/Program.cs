using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace 接口
{
    interface IControl
    {
        void Paint();
    }

    interface ITextBox : IControl
    {
        void SetText(string text);
    }

    interface IListBox : IControl
    {
        void SetItems(string[] items);
    }

    interface IComboBox : ITextBox, IListBox { }

    interface IDataBound
    {
        void Bind(Binder b);
    }

    public class Binder
    {

    }

    //public class EditBox : IControl, IDataBound
    //{
    //    public void Paint() { }

    //    public void Bind(Binder b) { }
    //}

    public class EditBox : IControl, IDataBound
    {
        void IControl.Paint() { }

        void IDataBound.Bind(Binder b) { }
    }

    class Program
    {
        static void Main()
        {
            //EditBox editBox = new EditBox();
            //IControl control = editBox;
            //IDataBound dataBound = editBox;

            //object obj = new EditBox();
            //IControl control = (IControl)obj;
            //IDataBound dataBound = (IDataBound)obj;

            EditBox editBox = new EditBox();
            editBox.Paint();
            IControl control = editBox;
            control.Paint();
        }
    }
}
