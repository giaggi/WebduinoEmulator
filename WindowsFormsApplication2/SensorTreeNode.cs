﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApplication2
{

    class SensorTreeNode : TreeNode
    {
        public String sensorNodeId;
        public String shieldNodeId;

        public SensorTreeNode(Sensor sensor)
        {
            this.Text = sensor.sensorname;
        }
    }
}
