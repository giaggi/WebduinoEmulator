﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApplication2
{
    
    class ActuatorTreeNode : TreeNode
    {
        public String shieldNodeId;
        public String actuatorNodeId;

        public ActuatorTreeNode(Sensor adapter)
        {
            this.Text = adapter.sensorname;
        }
    }
}
