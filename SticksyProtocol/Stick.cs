using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;

namespace SticksyProtocol
{
    public interface IStickContent { }

    [Serializable]
    public class CheckboxContent : IStickContent
    {
        public int id { get; set; } = -1;  //нужен только для БД (id = -1 у контента, созданного но не сохраненного в БД)
        public string text { get; set; } = string.Empty;
        public bool isChecked { get; set; } = false;
        public CheckboxContent(string text)
        {
            this.text = text;
            this.id = -1;
            this.isChecked = false;
        }
        public CheckboxContent(int id, string text, bool isChecked)
        {
            this.text = text;
            this.id = id;
            this.isChecked = isChecked;
        }
    }

    [Serializable]
    public class TextContent : IStickContent
    {
        public int id { get; set; } = -1;  //нужен только для БД (id = -1 у контента, созданного но не сохраненного в БД)
        public string text { get; set; } = string.Empty;
        public TextContent(string text)
        {
            this.text = text;
            this.id = -1;
        }
        public TextContent(int id, string text)
        {
            this.text = text;
            this.id = id;
        }
    }

    [Serializable]
    public class Stick
    {
        public int id { get; set; }
        public string title { get; set; }
        public List<IStickContent> content { get; set; }
        public List<string> tags { get; set; }
        public int idCreator { get; set; }
        public List<Friend> visiters { get; set; }
        public DateTime date { get; set; }
        public string color { get; set; }
        public Stick(int id, int idCreator)
        {
            this.id = id;
            this.idCreator = idCreator;
            this.visiters = new List<Friend>();
            this.tags = new List<string>();
            this.date = DateTime.Now;
            this.color = "White";
            this.content = new List<IStickContent>();
        }
    }
}
