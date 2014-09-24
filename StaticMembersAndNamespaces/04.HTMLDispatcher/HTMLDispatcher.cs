using System;

namespace HTMLDispatcher
{
    static class HTMLDispatcher
    {
        public static ElementBuilder CreateImage(string src, string alt, string title)
        {
            ElementBuilder image = new ElementBuilder("img", true);

            image.AddAttribute("src", src);
            image.AddAttribute("alt", alt);
            image.AddAttribute("title", title);

            return image;
        }

        public static ElementBuilder CreateURL(string url, string title, string text)
        {
            ElementBuilder urlTag = new ElementBuilder("a");

            urlTag.AddAttribute("href", url);
            urlTag.AddAttribute("title", title);
            urlTag.AddContent(text);

            return urlTag;
        }

        public static ElementBuilder CreateInput(string type, string name, string value)
        {
            ElementBuilder input = new ElementBuilder("input", true);

            input.AddAttribute("type", type);
            input.AddAttribute("name", name);
            input.AddAttribute("value", value);

            return input;
        }
    }
}
