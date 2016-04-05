using System;
using System.Collections.Generic;
using System.Text;
using System.IO;
using ESRI.ArcGIS.Geometry;
using ESRI.ArcGIS.Carto;

namespace ExtentCmd
{
    public class CmdExtent : ESRI.ArcGIS.Desktop.AddIns.Button
    {
        public CmdExtent()
        {
        }

        protected override void OnClick()
        {
            IEnvelope ext = ((IActiveView)ArcMap.Document.ActiveView).Extent;
            FCoords fc = new FCoords(ext.XMin, ext.YMin, ext.XMax, ext.YMax);
            fc.ShowDialog();

            ArcMap.Application.CurrentTool = null;
        }
        protected override void OnUpdate()
        {
            Enabled = ArcMap.Application != null;
        }
    }

}
