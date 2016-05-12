using System;
using System.Collections.Generic;
using System.Text;

namespace HtmlAgilityPack
{
    public interface IHtmlBaseNode
    {
        string Name { get; set; }
        bool HasAttributes { get;  }
        HtmlAttributeCollection Attributes { get; }
        HtmlNodeCollection ChildNodes { get; }
        HtmlNodeType NodeType { get; }
        string InnerText { get; }
        HtmlNode ParentNode { get; }
        bool HasChildNodes { get; }
        HtmlNode NextSibling { get; }
        HtmlNode CloneNode(bool something);
        HtmlNode PreviousSibling { get; }
    }
}
