//------------------------------------------------------------------------------
// <auto-generated>
//     此代码已从模板生成。
//
//     手动更改此文件可能导致应用程序出现意外的行为。
//     如果重新生成代码，将覆盖对此文件的手动更改。
// </auto-generated>
//------------------------------------------------------------------------------

namespace PeoplesManagment.Models
{
    using System;
    using System.Collections.Generic;
    
    public partial class Peoples
    {
        public int id { get; set; }
        public string username { get; set; }
        public string usedname { get; set; }
        public Nullable<int> gender { get; set; }
        /// <summary>
        /// 出生日期
        /// </summary>
        public string birthday { get; set; }
        public string nation { get; set; }
        public string political { get; set; }
        public string idcard { get; set; }
        public string natives { get; set; }
        public Nullable<int> populate { get; set; }
        public string address { get; set; }
        public string military { get; set; }
        public string marriage { get; set; }
        public string education { get; set; }
        public string phone { get; set; }
        public string photo { get; set; }
        public string ftype { get; set; }
        public Nullable<int> fid { get; set; }
        public string fship { get; set; }
    }
}