using Designer.Classes;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Text;

namespace Topology
{
    [Route("api/")]
    public class MainController : Controller
    {
        [HttpGet]
        public IEnumerable<string> Get()
        {
            return null;
        }


        [HttpGet("GetPalette")]
        public IEnumerable<Component> GetPalette()
        {
            List<Component> result = new List<Component>()
            {
                new Component()
                {
                    DisplayName = "Ворота",
                    ClassName = "Gate",
                    GroupName = "Склад",
                    Frame = new Frame(0, 0, 300, 3000),
                    Graphics = new Shape[] {new Rectangle(0, 0, 300, 3000)},
                    DefaultSize = new Frame(0, 0, 300, 3000),
                    MinSize = new Frame(0, 0, 100, 2000),
                    MaxSize = new Frame(0, 0, 1000, 6000),
                    DefaultText = "Ворота",
                    Properties = new ObjectProp[]
                    {
                        new ObjectProp("Номер ворот", "Nr", "Общее", "String", new ExternalMethod("", ""),
                            new ExternalMethod("", "")),
                        new ObjectProp("Штрихкод", "Barcode", "Общее", "String", new ExternalMethod("", ""),
                            new ExternalMethod("", ""))
                    },
                    OnDblClick = new ExternalMethod("", ""),
                    OnChange = new ExternalMethod("", ""),
                },

                new Component()
                {
                    DisplayName = "Стеллаж",
                    ClassName = "Rack",
                    GroupName = "Склад",
                    Frame = new Frame(0, 0, 300, 3000),
                    Graphics = new Shape[] {new Rectangle(0, 0, 1000, 2708)},
                    DefaultSize = new Frame(0, 0, 1000, 2708),
                    MinSize = new Frame(0, 0, 1000, 2708),
                    MaxSize = new Frame(0, 0, 1000, 2708),
                    DefaultText = "Стеллаж",
                    Properties = new ObjectProp[]
                    {
                        new ObjectProp("Номер", "Nr", "Общее", "String", new ExternalMethod("", ""),
                            new ExternalMethod("", "")),
                        new ObjectProp("Штрихкод", "Barcode", "Общее", "String", new ExternalMethod("", ""),
                            new ExternalMethod("", ""))
                    },
                    OnDblClick = new ExternalMethod("", ""),
                    OnChange = new ExternalMethod("", ""),
                }
            };

            return result;
        }


        [HttpPost]
        public string Post([FromBody] string value)
        {
            return "OK";
        }
    }
}