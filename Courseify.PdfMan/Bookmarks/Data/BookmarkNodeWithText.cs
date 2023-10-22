using System;
using System.Collections.Generic;
using System.Diagnostics.CodeAnalysis;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Courseify.PdfMan.Bookmarks.Data
{
    public class BookmarkNodeWithText : BookmarkNode
    {
        public required string Text { get; set; }
        public BookmarkNodeWithText()
        {
            
        }

        [SetsRequiredMembers]
        public BookmarkNodeWithText(BookmarkNode node, string text)
        {
            this.Id = node.Id;
            this.PageNumber = node.PageNumber;
            this.Children = node.Children;
            this.Title = node.Title;
            this.Text = text;
        }
    }
}
