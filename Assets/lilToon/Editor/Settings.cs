using System.Globalization;
using UnityEditor;

namespace lilToon
{
    internal class Settings : ScriptableSingleton<Settings>
    {
        public string language = CultureInfo.CurrentCulture.Name;

        internal void Save() => Save(true);
    }
}
