﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;

namespace SticksyProtocol
{
    public interface IStickContent { }

    [Serializable]
    public class TextCheck : IStickContent
    {
        public int id { get; set; }  //нужен только для БД
        public string text { get; set; }
        public bool isChecked { get; set; }
        public TextCheck()
        {
            id = -1;   //задача, созданная в стике, но еще не сохраненная в базу
            text = "";
            isChecked = false;
        }       
    }



    [Serializable]
    public class Stick
    {
        public int id { get; set; }
        public string title { get; set; }
        public List<TextCheck> content { get; set; }
        public List<string> tags { get; set; }
        public int idCreator { get; set; }
        public List<Friend> idVisiters { get; set; }
        public DateTime date { get; set; }
        public string color { get; set; }
        public Stick(int id, int idCreator)
        {
            this.id = id;
            this.idCreator = idCreator;
            this.idVisiters = new List<Friend>();
            this.tags = new List<string>();
            this.date = DateTime.Now;
            this.color = "White";
        }
    }
}
