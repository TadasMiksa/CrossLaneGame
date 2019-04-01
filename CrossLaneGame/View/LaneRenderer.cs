using CrossLaneGame.GUI;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CrossLaneGame.View
{
    class LaneRenderer //lane(road)rendering
    {
        private List<LaneForm> _laneForms = new List<LaneForm>();

        public LaneRenderer()
        {
            for (int i = 2; i < 8; i = i + 2)
            {
                _laneForms.Add(new LaneForm(1, i, 38, 3, '-'));
            }
        }

        public void RenderLanes()
        {
            foreach (LaneForm item in _laneForms)
            {
                item.Render();
            }
        }
    }
}
