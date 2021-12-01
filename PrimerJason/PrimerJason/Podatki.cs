﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PrimerJason
{

    public class Ucilnica
    {
        public List<Class1> Property1 { get; set; }
    }

    public class Class1
    {
        public int id { get; set; }
        public string name { get; set; }
        public int visible { get; set; }
        public string summary { get; set; }
        public int summaryformat { get; set; }
        public int section { get; set; }
        public int hiddenbynumsections { get; set; }
        public bool uservisible { get; set; }
        public Module[] modules { get; set; }
    }

    public class Module
    {
        public int id { get; set; }
        public string url { get; set; }
        public string name { get; set; }
        public int instance { get; set; }
        public int visible { get; set; }
        public bool uservisible { get; set; }
        public int visibleoncoursepage { get; set; }
        public string modicon { get; set; }
        public string modname { get; set; }
        public string modplural { get; set; }
        public object availability { get; set; }
        public int indent { get; set; }
        public string onclick { get; set; }
        public object afterlink { get; set; }
        public string customdata { get; set; }
        public int completion { get; set; }
        public Content[] contents { get; set; }
        public Contentsinfo contentsinfo { get; set; }
        public Completiondata completiondata { get; set; }
        public string description { get; set; }
    }

    public class Contentsinfo
    {
        public int filescount { get; set; }
        public int filessize { get; set; }
        public int lastmodified { get; set; }
        public string[] mimetypes { get; set; }
        public string repositorytype { get; set; }
    }

    public class Completiondata
    {
        public int state { get; set; }
        public int timecompleted { get; set; }
        public object overrideby { get; set; }
        public bool valueused { get; set; }
    }

    public class Content
    {
        public string type { get; set; }
        public string filename { get; set; }
        public string filepath { get; set; }
        public int filesize { get; set; }
        public string fileurl { get; set; }
        public int? timecreated { get; set; }
        public int timemodified { get; set; }
        public int? sortorder { get; set; }
        public string mimetype { get; set; }
        public bool isexternalfile { get; set; }
        public int? userid { get; set; }
        public string author { get; set; }
        public string license { get; set; }
    }

}
