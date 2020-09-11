using System;
using System.Xml;

namespace DisqusToGithubIssues
{
    public static class XmlNodeExtensions
    {
        public static T NodeValue<T>(this XmlNode node)
        {
            return node.NodeValue<T>(default(T));
        }
        public static T NodeValue<T>(this XmlNode node, T def)
        {
            if (node == null)
            {
                return def;
            }
            try
            {
                var value = node.NodeValue();
                return (T)Convert.ChangeType(value, typeof(T));
            }
            catch (Exception)
            {
                return def;
            }
        }
        public static string NodeValue(this XmlNode node)
        {
            var value = node.FirstChild?.Value ?? String.Empty;
            return value.Trim();
        }
        public static T AttributeValue<T>(this XmlNode node, int index)
        {
            return node.AttributeValue(index, default(T));
        }
        public static T AttributeValue<T>(this XmlNode node, int index, T def)
        {
            if (node == null)
            {
                return def;
            }
            if (node.Attributes.Count == 0)
            {
                return def;
            }
            try
            {
                var value = node.AttributeValue(index);
                return (T)Convert.ChangeType(value, typeof(T));
            }
            catch (Exception)
            {
                return def;
            }
        }
        public static string AttributeValue(this XmlNode node, int index)
        {
            var value = node.Attributes[index]?.Value;
            return value.Trim();
        }
    }
}