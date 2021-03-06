﻿// -----------------------------------------------------------------------
// <copyright file="BoundingBox.cs" company="">
// Triangle.NET code by Christian Woltering, http://triangle.codeplex.com/
// </copyright>
// -----------------------------------------------------------------------

namespace TriangleNet.Geometry
{
    using System;

    /// <summary>
    /// A simple bounding box class.
    /// </summary>
    public class BoundingBox
    {
        double xmin, ymin, xmax, ymax, zmin, zmax;

        /// <summary>
        /// Initializes a new instance of the <see cref="BoundingBox" /> class.
        /// </summary>
        public BoundingBox()
        {
            xmin = double.MaxValue;
            ymin = double.MaxValue;
            xmax = -double.MaxValue;
            ymax = -double.MaxValue;
            zmin = -double.MaxValue;
            zmax = -double.MaxValue;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="BoundingBox" /> class
        /// with predefined bounds.
        /// </summary>
        /// <param name="xmin">Minimum x value.</param>
        /// <param name="ymin">Minimum y value.</param>
        /// <param name="xmax">Maximum x value.</param>
        /// <param name="ymax">Maximum y value.</param>
        public BoundingBox(double xmin, double ymin, double xmax, double ymax, double zmin, double zmax)
        {
            this.xmin = xmin;
            this.ymin = ymin;
            this.xmax = xmax;
            this.ymax = ymax;
            this.zmin = zmin;
            this.zmax = zmax;
        }

        /// <summary>
        /// Gets the minimum x value (left boundary).
        /// </summary>
        public double Xmin
        {
            get { return xmin; }
        }

        /// <summary>
        /// Gets the minimum y value (bottom boundary).
        /// </summary>
        public double Ymin
        {
            get { return ymin; }
        }

        /// <summary>
        /// Gets the maximum x value (right boundary).
        /// </summary>
        public double Xmax
        {
            get { return xmax; }
        }

        /// <summary>
        /// Gets the maximum y value (top boundary).
        /// </summary>
        public double Ymax
        {
            get { return ymax; }
        }
        /// <summary>
        /// Gets the maximum Z value (right boundary).
        /// </summary>
        public double Zmax
        {
            get { return zmax; }
        }

        /// <summary>
        /// Gets the min Z value (top boundary).
        /// </summary>
        public double Zmin
        {
            get { return zmin; }
        }
        /// <summary>
        /// Gets the width of the bounding box.
        /// </summary>
        public double Width
        {
            get { return xmax - xmin; }
        }

        /// <summary>
        /// Gets the height of the bounding box.
        /// </summary>
        public double Height
        {
            get { return ymax - ymin; }
        }

        /// <summary>
        /// Update bounds.
        /// </summary>
        /// <param name="x">X coordinate.</param>
        /// <param name="y">Y coordinate.</param>
        public void Update(double x, double y, double z)
        {
            xmin = Math.Min(xmin, x);
            ymin = Math.Min(ymin, y);
            xmax = Math.Max(xmax, x);
            ymax = Math.Max(ymax, y);
            zmin = Math.Min(zmin, z);
            zmax = Math.Max(zmax, z);
        }

        /// <summary>
        /// Scale bounds.
        /// </summary>
        /// <param name="dx">Add dx to left and right bounds.</param>
        /// <param name="dy">Add dy to top and bottom bounds.</param>
        public void Scale(double dx, double dy, double dz)
        {
            xmin -= dx;
            xmax += dx;
            ymin -= dy;
            ymax += dy;
            zmin -= dz;
            zmax += dz;
        }

        /// <summary>
        /// Check if given point is inside bounding box.
        /// </summary>
        /// <param name="pt">Point to check.</param>
        /// <returns>Return true, if bounding box contains given point.</returns>
        public bool Contains(Point pt)
        {
            return ((pt.x >= xmin) && (pt.x <= xmax) && (pt.y >= ymin) && (pt.y <= ymax));
        }
    }
}
