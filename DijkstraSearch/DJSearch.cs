using System;
using System.Collections.Generic;
using System.Text;

namespace DijkstraSearch
{
    public class DJSearch
    {
        private Person searchResult = null;
        private string positionType = "";
        private Dictionary<string, Person> Searched = new Dictionary<string, Person>();
        private Dictionary<string, Person> Persons = new Dictionary<string, Person>();
        private Dictionary<string, string[]> Relations = new Dictionary<string, string[]>();

        public DJSearch()
        {
            Persons.Add("larry", new Person { Name = "larry", Age = 26, Sex = 1, PositionType = "C#", TitleLevel = 3 });
            Persons.Add("aaron", new Person { Name = "aaron", Age = 46, Sex = 1, PositionType = "C#", TitleLevel = 4 });
            Persons.Add("bonnie", new Person { Name = "bonnie", Age = 30, Sex = 2, PositionType = "Translator", TitleLevel = 2 });
            Persons.Add("charles", new Person { Name = "charles", Age = 36, Sex = 1, PositionType = "DevOps", TitleLevel = 4 });
            Persons.Add("ping", new Person { Name = "ping", Age = 34, Sex = 2, PositionType = "PM", TitleLevel = 3 });
            Persons.Add("jonne", new Person { Name = "jonne", Age = 35, Sex = 1, PositionType = "Java", TitleLevel = 4 });
            Persons.Add("simth", new Person { Name = "simth", Age = 32, Sex = 1, PositionType = "HardwareDev", TitleLevel = 3 });
            Persons.Add("liuyan", new Person { Name = "liuyan", Age = 28, Sex = 1, PositionType = "Web", TitleLevel = 2 });
            Persons.Add("pengxiaojuan", new Person { Name = "pengxiaojuan", Age = 30, Sex = 2, PositionType = "Design", TitleLevel = 3 });
            Persons.Add("huangting", new Person { Name = "huangting", Age = 22, Sex = 2, PositionType = "PicProcess", TitleLevel = 2 });
            Persons.Add("xx1", new Person { Name = "xx1", Age = 32, Sex = 1, PositionType = "CameraMan", TitleLevel = 4 });

            Relations.Add("larry", new string[] { "aaron", "bonnie", "liuyan", "huangting" });
            Relations.Add("aaron", new string[] { "larry", "bonnie", "charles", "ping" });
            Relations.Add("bonnie", new string[] { "larry", "aaron", "jonne", "simth" });
            Relations.Add("charles", new string[] { "aaron" });
            Relations.Add("ping", new string[] { "aaron" });

            Relations.Add("jonne", new string[] { "bonnie" });
            Relations.Add("simth", new string[] { "bonnie" });

            Relations.Add("liuyan", new string[] { "larry", "pengxiaojuan", "huangting" });
            Relations.Add("pengxiaojuan", new string[] { "larry", "pengxiaojuan", "huangting" });
            Relations.Add("huangting", new string[] { "larry", "liuyan", "xx1" });
            Relations.Add("xx1", new string[] { "huangting" });
        }



    }


    public class Person
    {
        public string Name { get; set; }
        public int Age { get; set; }
        public int Sex { get; set; }
        public string PositionType { get; set; }
        public int TitleLevel { get; set; }
    }

}
