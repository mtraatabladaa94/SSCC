﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using SSCC.Models.POCO;
using SSCC.Models.Database;

namespace SSCC.Controllers
{
    public class RuleMark
    {
        public IEnumerable<Mark> List()
        {
            using (var db = new ModelDb())
            {
                foreach (var item in db.Marks.AsEnumerable())
                {
                    yield return item;
                }
            }
        }
    }
}