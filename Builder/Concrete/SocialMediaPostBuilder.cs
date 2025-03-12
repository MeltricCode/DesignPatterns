using Builder.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Builder.Concrete
{
    public class SocialMediaPostBuilder
    {

        private SocialMediaPost _post = new();


        public SocialMediaPostBuilder AddTitle(string title)
        {
            _post.Title = title;
            return this;
        }

        public SocialMediaPostBuilder AddContent(string content)
        {
            _post.Content = content;
            return this;
        }

        public SocialMediaPostBuilder AddAuthor(string author)
        {
            _post.Author = author;
            return this;
        }

        public SocialMediaPostBuilder AddDatePosted(DateTime datePosted)
        {
            _post.DatePosted = datePosted;
            return this;
        }

        public SocialMediaPostBuilder AddTags(List<string> tags)
        {
            _post.Tags = tags;
            return this;
        }

        public SocialMediaPostBuilder AddImageUri(Uri uri)
        {
            _post.ImageUri = uri;
            return this;
        }

        public SocialMediaPostBuilder AddLinks(List<string> links)
        {
            _post.Links = links;
            return this;
        }

        public SocialMediaPost Build()
        {
            return _post;
        }


    }
}
