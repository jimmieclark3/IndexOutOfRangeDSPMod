using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DSPTransportStat.Translation
{
    static class Strings
    {
        private static readonly Dictionary<string, string> _translations = new Dictionary<string, string>
            {
                { "Transport Stations", "物流运输站" },
                { "Current:", "当前：" },
                { "Max:", "最大：" },
                { "Location & Name", "位置和名称" },
                { "ASC", "升序" },
                { "DESC", "降序" },
                { "Item Slots", "物品槽位" },
                { "Search:", "搜索：" },
                { "Search", "搜索" },
                { "Config Panel", "配置面板" },
                { "Home Panel", "主页" },
                { "Allow Item Transfer", "允许存取物品" },
                { "Planetary Station", "行星物流站" },
                { "Interstellar Station", "星际物流站" },
                { "Collector", "采集站" },
                { "Item Filter", "过滤物品" },
                { "Local/Remote", "行星/星际" },
                { "All", "全部" },
                { "Local", "行星" },
                { "Remote", "星际" },
                { "Supply/Demand", "需求/供应" },
                { "No Order", "无订单" },
                { "Planetary Collector", "行星采集站" },
                { "Orbital Collector", "轨道采集站" },
                { "Local Storage", "本地仓储" },
                { "Local Supply", "本地供应" },
                { "Local Demand", "本地需求" },
                { "Remote Storage", "星际仓储" },
                { "Remote Supply", "星际供应" },
                { "Remote Demand", "星际需求" },
                // ... add other translations
            };

        public static string Translate(this string text)
        {
            if (_translations.TryGetValue(text, out var translation))
            {
                return translation;
            }

            return text; // or some default action
        }


        static public class TransportStationsWindow
        {
            static public string Title => "Transport Stations".Translate();

            static public string CurrentLabel => "Current:".Translate();
            static public string MaxLabel => "Max:".Translate();
            static public string LocationAndName => "Location & Name".Translate();
            static public string ASC => "ASC".Translate();
            static public string DESC => "DESC".Translate();
            static public string ItemSlots => "Item Slots".Translate();
            static public string SearchLabel => "Search:".Translate();
            static public string SearchButton => "Search".Translate();
            static public string ItemConfigPanel => "Config Panel".Translate();
            static public string ItemHomePanel => "Home Panel".Translate();
            static public string AllowItemTransferLabel => "Allow Item Transfer".Translate();


            static public class ParameterPanel
            {
                static public string ToggleInPlanetLabel => "Planetary Station".Translate();
                static public string ToggleInterstellarLabel => "Interstellar Station".Translate();
                static public string ToggleCollectorLabel => "Collector".Translate();
                static public string ItemFilterLabel => "Item Filter".Translate();
                static public string UsageTypeFilterLabel => "Local/Remote".Translate();
                static public string UsageTypeFilterToggleAllLabel => "All".Translate();
                static public string UsageTypeFilterToggleLocalLabel => "Local".Translate();
                static public string UsageTypeFilterToggleRemoteLabel => "Remote".Translate();
                static public string UsageDirectionFilterLabel => "Supply/Demand".Translate();
                static public string UsageDirectionFilterToggleAllLabel => "All".Translate();
                static public string UsageDirectionFilterToggleSupplyLabel => "Supply".Translate();
                static public string UsageDirectionFilterToggleDemandLabel => "Demand".Translate();
                static public string UsageDirectionFilterToggleStorageLabel => "Storage".Translate();
            }
        }

        static public class Common
        {
            static public string NoOrder => "No Order".Translate();
            static public class StationType
            {
                static public string InPlanet => "Planetary Station".Translate();

                static public string InPlanetCollector => "Planetary Collector".Translate();

                static public string Interstellar => "Interstellar Station".Translate();

                static public string InterstellarCollector => "Orbital Collector".Translate();
            }

            // ...

            static public class StationStoreLogic
            {
                static public string InPlanetStorage => "Local Storage".Translate();

                static public string InPlanetSupply => "Local Supply".Translate();

                static public string InPlanetDemand => "Local Demand".Translate();

                static public string InterstellarStorage => "Remote Storage".Translate();

                static public string InterstellarSupply => "Remote Supply".Translate();

                static public string InterstellarDemand => "Remote Demand".Translate();
            }

        }
    }
}
