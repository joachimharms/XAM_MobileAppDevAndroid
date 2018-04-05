using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using Android.App;
using Android.Content;
using Android.OS;
using Android.Runtime;
using Android.Views;
using Android.Widget;

namespace POIApp_C04_ListView
{
    public class POIListViewAdapter : BaseAdapter<PointOfInterest>
    {
        private readonly Activity context;
        private List<PointOfInterest> poiListData;

        public POIListViewAdapter(Activity context, List<PointOfInterest> poiListData)
            :base()
        {
            this.context = context;
            this.poiListData = poiListData;
        }



        public override PointOfInterest this[int index]
        {
            get
            {
                return this.poiListData[index];
            }
        }

        public override int Count
        {
            get
            {
                return this.poiListData.Count;
            }

        }

        public override long GetItemId(int position)
        {
            return position;
        }

        public override View GetView(int position, View convertView, ViewGroup parent)
        {

        }
    }
}