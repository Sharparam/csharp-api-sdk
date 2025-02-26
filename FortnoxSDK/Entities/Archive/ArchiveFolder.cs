using System;
using Fortnox.SDK.Serialization;
using Newtonsoft.Json;
using System.Collections.Generic;

namespace Fortnox.SDK.Entities
{
    [Entity(SingularName = "Folder", PluralName = "Folders")]
    public class ArchiveFolder
    {

        ///<summary> Direct URL to the record </summary>
        [ReadOnly]
        [JsonProperty("@url")]
        public Uri Url { get; private set; }

        ///<summary> Unique email for the folder </summary>
        [ReadOnly]
        [JsonProperty]
        public string Email { get; private set; }

        ///<summary> List of files </summary>
        [ReadOnly]
        [JsonProperty]
        public IList<ArchiveFile> Files { get; private set; }

        ///<summary> List of folders </summary>
        [ReadOnly]
        [JsonProperty]
        public IList<ArchiveFolder> Folders { get; private set; }

        ///<summary> Id of the folder </summary>
        [ReadOnly]
        [JsonProperty]
        public string Id { get; private set; }

        ///<summary> Name of the folder </summary>
        [JsonProperty]
        public string Name { get; set; }
    }
}