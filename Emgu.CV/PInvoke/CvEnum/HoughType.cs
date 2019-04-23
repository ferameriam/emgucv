//----------------------------------------------------------------------------
//  Copyright (C) 2004-2019 by EMGU Corporation. All rights reserved.       
//----------------------------------------------------------------------------

using System;

namespace Emgu.CV.CvEnum
{
    /// <summary>
    /// Hough detection type
    /// </summary>
    public enum HoughType
    {
        /*
        /// <summary>
        /// Classical or standard Hough transform. Every line is represented by two floating-point numbers (rho, theta), where rho is a distance between (0,0) point and the line, and theta is the angle between x-axis and the normal to the line. Thus, the matrix must be (the created sequence will be) of CV_32FC2 type
        /// </summary>
        CV_HOUGH_STANDARD = 0,
        /// <summary>
        /// Probabilistic Hough transform (more efficient in case if picture contains a few long linear segments). It returns line segments rather than the whole lines. Every segment is represented by starting and ending points, and the matrix must be (the created sequence will be) of CV_32SC4 type
        /// </summary>
        CV_HOUGH_PROBABILISTIC = 1,
        /// <summary>
        /// Multi-scale variant of classical Hough transform. The lines are encoded the same way as in CV_HOUGH_STANDARD
        /// </summary>
        CV_HOUGH_MULTI_SCALE = 2,*/
        /// <summary>
        /// Gradient
        /// </summary>
        Gradient = 3
    }
}