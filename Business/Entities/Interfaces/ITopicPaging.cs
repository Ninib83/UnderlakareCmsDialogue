﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UnderlakareCmsDialogue.Business.Entities.Interfaces
{
    public interface ITopicPaging : IPaging
    {
        IEnumerable<ITopic> Topics { get; }
    }
}
