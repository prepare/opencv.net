﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;

namespace OpenCV.Net.Native
{
    static partial class NativeMethods
    {
        const string photoLib = "opencv_photo246";

        [DllImport(photoLib, CallingConvention = CallingConvention.Cdecl)]
        internal static extern void cvInpaint(CvArr src, CvArr inpaint_mask, CvArr dst, double inpaintRange, InpaintMethod flags);
    }
}