namespace ScanIP
{
    class PortList
    {
        private int start;
        private int stop;
        private int ports;
        private int index;
        private int[] ListPorts;
        private int portMethod;

        public PortList(int starts, int stops)
        {
            start = starts;
            stop = stops;
            ports = start;
        }

        public PortList(int[] portsList, int met)
        {
            ListPorts = portsList;
            portMethod = met;
            ports = ListPorts[0];
            index = 0;
        }

        public bool MorePortsx()
        {
            return (stop - ports) >= 0;
        }

        public bool MorePorts()
        {
            //ListPorts[1] is start port
            return (ListPorts[1] - ports) >= 0;
        }

        public int NextPort()
        {
            //portMethod 2 is range
            if (portMethod == 2)
            {
                if (MorePorts())
                {
                    return ports++;
                }
                return -1;
            }
            else
            {
                if (index < ListPorts.Length)
                {
                    int tmp = ListPorts[index];
                    index++;
                    return tmp;
                }
                return -1;
            }
        }

        public int NextPort(int last)
        {
            if (MorePorts())
            {
                return ports++;
            }
            return -1;
        }
    }
}
