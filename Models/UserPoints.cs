using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Reflection;
using System.Threading.Tasks;

namespace UFPCore.Models
{
    public class UserPoints
    {
        public object this[string propertyName]
        {
            get
            {
                Type myType = typeof(UserPoints);
                PropertyInfo myPropInfo = myType.GetProperty(propertyName);
                return myPropInfo.GetValue(this, null);
            }
            set
            {
                Type myType = typeof(UserPoints);
                PropertyInfo myPropInfo = myType.GetProperty(propertyName);
                myPropInfo.SetValue(this, value, null);

            }

        }
        [Key]
        public string UFPId { get; set; }
        public float CurrentScore { get; set; }
        public float Update01 { get; set; }
        public float Update02 { get; set; }
        public float Update03 { get; set; }
        public float Update04 { get; set; }
        public float Update05 { get; set; }
        public float Update06 { get; set; }
        public float Update07 { get; set; }
        public float Update08 { get; set; }
        public float Update09 { get; set; }
        public float Update10 { get; set; }
        public float Update11 { get; set; }
        public float Update12 { get; set; }
        public float Update13 { get; set; }
        public float Update14 { get; set; }
        public float Update15 { get; set; }
        public float Update16 { get; set; }
        public float Update17 { get; set; }
        public float Update18 { get; set; }
        public float Update19 { get; set; }
        public float Update20 { get; set; }
        public float Update21 { get; set; }
        public float Update22 { get; set; }
        public float Update23 { get; set; }
        public float Update24 { get; set; }
        public float Update25 { get; set; }
        public float Update26 { get; set; }
        public float Update27 { get; set; }
        public float Update28 { get; set; }
        public float Update29 { get; set; }
        public float Update30 { get; set; }
        public float Update31 { get; set; }
        public float Update32 { get; set; }
        public float Update33 { get; set; }
        public float Update34 { get; set; }
        public float Update35 { get; set; }
        public float Update36 { get; set; }
        public float Update37 { get; set; }
        public float Update38 { get; set; }
    }
}
