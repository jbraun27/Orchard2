using System.Collections.Generic;
using Newtonsoft.Json.Linq;

namespace Orchard.Core.Settings.Metadata.Records
{
    public class ContentTypeDefinitionRecord
    {
        public ContentTypeDefinitionRecord()
        {
            ContentTypePartDefinitionRecords = new List<ContentTypePartDefinitionRecord>();
        }

        public string Name { get; set; }
        public string DisplayName { get; set; }
        public bool Hidden { get; set; }
        public JObject Settings { get; set; }

        public IList<ContentTypePartDefinitionRecord> ContentTypePartDefinitionRecords { get; set; }
    }
}