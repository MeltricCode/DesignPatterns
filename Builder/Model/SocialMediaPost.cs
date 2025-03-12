using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Builder.Model
{
    public class SocialMediaPost
    {
        public string Title { get; set; }
        public string Content { get; set; }
        public string Author { get; set; }
        public DateTime DatePosted { get; set; }
        public List<string> Tags { get; set; }
        public Uri ImageUri { get; set; }
        public List<string> Links { get; set; }


        public override string ToString()
        {
            var properties = typeof(SocialMediaPost).GetProperties();

            string propertyNames = "";
            foreach (var prop in properties)
            {
                if (prop.PropertyType.IsGenericType && prop.PropertyType.GetGenericTypeDefinition() == typeof(List<>))
                {
                    var values = prop.GetValue(this);

                    if(values is List<string> listValue)
                    {
                        propertyNames += $"{prop.Name}: [{string.Join(", ", listValue)}], ";
                    }
                }
                else
                {
                    propertyNames += $"{prop.Name}: {prop.GetValue(this)?.ToString()}, ";
                }
            }
            propertyNames = propertyNames.TrimEnd(',',' ');

            return propertyNames;
        }
    }
}
