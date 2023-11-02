using System;

namespace Lab
{
    class Mydate
    {
        public DateTime data { get; set; }
        public Mydate()
        {
            data = DateTime.Now;
        }
        public void TDP()
        {
            this.data.AddDays(7);
        }public void TDT()
        {
            this.data.AddDays(-7);
        }
        /*public DateTime getData()
        {
            return data;
        }
        public void setData(DateTime nowa)
        {
            data = nowa;
        }*/
    }
}
