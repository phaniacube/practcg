using Sitecore.Data;

namespace Point2Homes.Feature.Header
{
    public struct Templates
    {
        public struct Header
        {
            public static readonly ID ID = new ID("{24AA61D0-23C9-42C2-BE79-7196858C1B4C}");

            public struct Fields
            {
                public static readonly ID LogoText = new ID("{6A1B7260-BB0E-44CD-9A28-B4B43B2CA622}");
                public static readonly ID LogoLink = new ID("{1561A699-892C-4173-AC5D-AFF79C211A8A}");
                public static readonly ID PrimaryNavigation = new ID("{DEBDB905-0380-4264-B0EF-DDF2C94E73F2}");
                public static readonly ID WatermarkText = new ID("{4441A503-D503-4E7B-AC66-4C8B2F2E41A8}");
                public static readonly ID SearchButtonText = new ID("{9AF5ACFD-8894-425E-8929-B0DBB7122724}");
                public static readonly ID HomeMenu = new ID("{4599DBEB-0F6B-4571-B161-21FBB6857220}");
                public static readonly ID AboutMenu = new ID("{76FD610D-C66A-41E2-958F-DCD0668409D9}");
                public static readonly ID ServicesMenu = new ID("{96C901B3-97BA-4C20-9A59-A0A56F91DA18}");            
                public static readonly ID PropertiesMenu = new ID("{6D0FAB2E-CAAC-4099-8C6D-E8E7B77708B0}");
                public static readonly ID PagesMenu = new ID("{C37DDEF4-4551-4109-8EEE-598FDF44EC89}");
                public static readonly ID PagesSubMenu1 = new ID("{567E5F35-7C79-478B-B9DC-0DCC7F7A2990}");
                public static readonly ID PagesSubMenu2 = new ID("{1F039344-4C0F-4287-8C39-33B43A6DDCD2}");
                public static readonly ID PagesSubMenu3 = new ID("{FF081EDE-054E-460E-A0A1-39BB67A7B158}");
                public static readonly ID ContactMenu = new ID("{6741608C-869A-4A97-9922-3C88B095C190}");
                public static readonly ID Pages = new ID("{953C75D8-133C-477A-A1FE-F25E6EFCC057}");
            }
        }

        public struct PagesMenu
        {
            public static readonly ID ID = new ID("{3F54AA5B-EC5E-4F06-85E4-F6B3666CE85F}");

            public struct Fields
            {
                public static readonly ID SubPageName = new ID("{26973C85-AB35-4999-A4B3-B8480CE7A703}");
                public static readonly ID SubPageLink = new ID("{D4D0BAFF-E26B-4FD6-8CBD-09456E60DCBF}");
            }
        }
    }
}