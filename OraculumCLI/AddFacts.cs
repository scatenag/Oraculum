﻿using Oraculum;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Management.Automation;
using System.Text;
using System.Threading.Tasks;

namespace OraculumCLI
{
    [Cmdlet(VerbsCommon.Add, "Facts")]
    public class AddFacts : Cmdlet
    {
        [Parameter(Mandatory = true)]
        public Oraculum.Oraculum? Oraculum { get; set; }

        [Parameter(Mandatory = true)]
        public Fact[]? Facts { get; set; }

        protected override void ProcessRecord()
        {
            base.ProcessRecord();
            var j = Oraculum.AddFact(Facts);
            j.Wait();
            WriteObject(j.Result);
        }
    }
}
