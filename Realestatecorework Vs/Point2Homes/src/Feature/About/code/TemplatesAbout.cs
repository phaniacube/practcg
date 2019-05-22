using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using Sitecore.Data;

namespace Point2Homes.Feature.About
{
    public class TemplatesAbout
    {
        public struct About
        {
            public static readonly ID ID = new ID("{A2A32328-0B36-4DDB-9F52-0BB0A4A84981}");

            public struct Property
            {
                public static readonly ID ID = new ID("{689134F4-9D27-4CF6-95C1-EE708045CE8B}");

                public struct Fields
                {
                    public static readonly ID Title = new ID("{E3B51A8C-8A25-4088-BDAE-A4A69FC81063}");
                    public static readonly ID PropertyDetail = new ID("{759362DC-7C64-412A-8022-837B77384811}");

                }
            }
        }

        public struct AboutPropertyDetails
        {
            public static readonly ID ID = new ID("{6656DDB7-E8D9-451D-835A-C6F69544C10A}");

            public struct PropertyDetails
            {
                public static readonly ID ID = new ID("{338A1A3A-FDFF-4620-A593-B745E58DF1DA}");

                public struct Fields
                {
                    public static readonly ID PropertyTitle = new ID("{66171C49-B590-455E-9545-5CDE7252E4F5}");
                  
                    public static readonly ID PropertyDate = new ID("{26753ADE-DCB5-4CCC-8A4B-12924D9F322E}");
                    public static readonly ID PropertySummary = new ID("{A5EFCD71-8636-44AF-B1C5-EB14EC4A693F}");
                    public static readonly ID PropertyImage = new ID("{E762CFD1-F006-4AB1-BC47-20BB3C8EBA3D}");

                }
            }
        }
    }
}