using System;
using System.Text;

namespace HTMLDispatcher
{
    class ElementBuilder
    {
        private string element;
        private string attributes = "";
        private string content = "";

        private bool single;

        public ElementBuilder(string element, bool single = false)
        {
            this.single = single;
            this.Element = element;
        }

        public string Element
        {
            get { return this.element; }
            set
            {
                if (string.IsNullOrEmpty(value) || value.Length == 0)
                {
                    throw new ArgumentNullException("Invaid HTML tag!");
                }
                this.element = value;
            }
        }

        public void AddAttribute(string name, string value)
        {
            this.attributes += " " + name + "=\"" + value + "\"";
        }

        public void AddContent(string content)
        {
            if (single == true)
            {
                throw new Exception("Can't add content to single tags.");
            }
            this.content += content;
        }

        public static string operator *(ElementBuilder element, int count)
        {
            StringBuilder result = new StringBuilder();

            for (int i = 0; i < count; i++)
            {
                result.Append(element.ToString());
            }

            return result.ToString();
        }

        public override string ToString()
        {
            string tag = "<";

            tag += this.Element + this.attributes;

            if (single == true)
            {
                tag += " />";
            }
            else
            {
                tag += ">" + this.content + "</" + this.Element + ">";
            }

            return tag;
        }
    }
}