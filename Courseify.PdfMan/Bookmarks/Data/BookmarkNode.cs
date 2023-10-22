using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Courseify.PdfMan.Bookmarks.Data;
public class BookmarkNode
{
    public required int Id { get; set; }
    public required string Title { get; set; }
    public int? PageNumber { get; set; }
    public string? Text { get; set; }
    public List<BookmarkNode> Children { get; set; } = new List<BookmarkNode>();

    public BookmarkNode? GetNextSibling(BookmarkNode root)
    {
        BookmarkNode? parent = GetParent(root);
        if (parent == null)
            return null;  // This is the root node or an orphaned node

        BookmarkNode? previousNode = null;
        foreach (var child in parent.Children)
        {
            if (previousNode != null && previousNode.Id == Id)
                return child;

            previousNode = child;
        }

        return null;
    }

    public BookmarkNode? GetParent(BookmarkNode root)
    {
        if (root.Children.Contains(this))
            return root;

        foreach (var child in root.Children)
        {
            var potentialParent = GetParent(child);
            if (potentialParent != null)
                return potentialParent;
        }

        return null;
    }

    public BookmarkNode? FindNodeById(int id)
    {
        if (Id == id)
            return this;

        foreach (var child in Children)
        {
            var found = child.FindNodeById(id);
            if (found != null)
                return found;
        }

        return null;
    }

}
