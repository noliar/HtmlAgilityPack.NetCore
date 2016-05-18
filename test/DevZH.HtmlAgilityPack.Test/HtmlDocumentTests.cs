using HtmlAgilityPack;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net.Http;
using System.Threading.Tasks;
using Xunit;

namespace HtmlAgilityPack
{
    public class HtmlDocumentTests 
    {
        private static HtmlDocument GetMshomeDocument()
        {
            var doc = new HtmlDocument();
            doc.Load("files/mshome.htm");
            return doc;
        }
        
        [Fact]
        public void CreateAttribute()
        {
            var doc = new HtmlDocument();
            var a = doc.CreateAttribute("href");
            Assert.Equal("href", a.Name);
        }

        [Fact]
        public void CreateAttributeWithText()
        {
            var doc = new HtmlDocument();
            var a = doc.CreateAttribute("href", "http://something.com");
            Assert.Equal("href", a.Name);
            Assert.Equal("http://something.com", a.Value);
        }

        [Fact]
        public void CreateAttributeWithEncodedText()
        {
            var doc = new HtmlDocument();
            var a = doc.CreateAttribute("href", "http://something.com\"&<>");
            Assert.Equal("href", a.Name);
            Assert.Equal("http://something.com\"&<>", a.Value);
        }

        [Fact]
        public void CreateElement()
        {
            var doc = new HtmlDocument();
            var a = doc.CreateElement("a");
            Assert.Equal("a", a.Name);
            Assert.Equal(HtmlNodeType.Element, a.NodeType);
        }

        [Fact]
        public void CreateTextNodeWithText()
        {
            var doc = new HtmlDocument();
            var a = doc.CreateTextNode("something");
            Assert.Equal("something", a.InnerText);
            Assert.Equal(HtmlNodeType.Text, a.NodeType);
        }

        [Fact]
        public void HtmlEncode()
        {
            var result = HtmlDocument.HtmlEncode("http://something.com\"&<>");
            Assert.Equal("http://something.com&quot;&amp;&lt;&gt;", result);
        }

        [Fact]
        public void TestParse()
        {
            var doc = GetMshomeDocument();
            Assert.True(doc.DocumentNode.Descendants().Count() > 0);
        }

        [Fact]
        public void TestParseSaveParse()
        {
            var doc = GetMshomeDocument();
            var doc1desc =
                doc.DocumentNode.Descendants().Where(x => !string.IsNullOrWhiteSpace(x.InnerText)).ToList();
            doc.Save("testsaveparse.html");

            var doc2 = new HtmlDocument();
            doc2.Load("testsaveparse.html");
            var doc2desc =
                doc2.DocumentNode.Descendants().Where(x => !string.IsNullOrWhiteSpace(x.InnerText)).ToList();
            Assert.Equal(doc1desc.Count, doc2desc.Count);
        }

        [Fact]
        public void TestRemoveUpdatesPreviousSibling()
        {
            var doc = GetMshomeDocument();
            var docDesc = doc.DocumentNode.Descendants().ToList();
            var toRemove = docDesc[1200];
            var toRemovePrevSibling = toRemove.PreviousSibling;
            var toRemoveNextSibling = toRemove.NextSibling;
            toRemove.Remove();
            Assert.Same(toRemovePrevSibling, toRemoveNextSibling.PreviousSibling);
        }

        [Fact]
        public void TestReplaceUpdatesSiblings()
        {
            var doc = GetMshomeDocument();
            var docDesc = doc.DocumentNode.Descendants().ToList();
            var toReplace = docDesc[1200];
            var toReplacePrevSibling = toReplace.PreviousSibling;
            var toReplaceNextSibling = toReplace.NextSibling;
            var newNode = doc.CreateElement("tr");
            toReplace.ParentNode.ReplaceChild(newNode, toReplace);
            Assert.Same(toReplacePrevSibling, newNode.PreviousSibling);
            Assert.Same(toReplaceNextSibling, newNode.NextSibling);
        }

        [Fact]
        public void TestInsertUpdateSiblings()
        {
            var doc = GetMshomeDocument();
            var newNode = doc.CreateElement("td");
            var toReplace = doc.DocumentNode.ChildNodes[2];
            var toReplacePrevSibling = toReplace.PreviousSibling;
            var toReplaceNextSibling = toReplace.NextSibling;
            doc.DocumentNode.ChildNodes.Insert(2, newNode);
            Assert.Same(newNode.NextSibling, toReplace);
            Assert.Same(newNode.PreviousSibling, toReplacePrevSibling);
            Assert.Same(toReplaceNextSibling, toReplace.NextSibling);
        }
    }
}
