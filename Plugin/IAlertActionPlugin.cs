using Core;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Plugin
{
    public interface IAlertActionPlugin
    {
        string Name { get; }
        string ShortName { get; }
        string Description { get; }
        AlertActionResult Action(Alert Alert);
    }

    public class AlertActionResult
    {
        public bool Succeeded { get; set; } = false;
        public string ErrorMessage { get; set; } = "";
    }
}
