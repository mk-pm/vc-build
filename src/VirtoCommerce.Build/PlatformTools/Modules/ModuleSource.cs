using Newtonsoft.Json;
using PlatformTools;

namespace PlatformTools.Modules
{
    [JsonConverter(typeof(ModuleSourceConverter))]
    public abstract class ModuleSource
    {
        public abstract string Name { get; set; }
    }
}

