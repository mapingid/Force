﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Force
{
  class Point2DClass
  {
    public int[] x;
    public int y;
    public string value => $"x:{x[0]} y:{y}";
  }
}