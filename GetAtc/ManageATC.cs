using Eve;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using System;
using System.Collections.Generic;
using System.Device.Location;

namespace GetAtc
{
    public class Infos
    {
        public static string Callsign
        { get; set; }            
    }

    public class GetXMLInfos
    {

        public class Clients
        {
            /// <summary>
            /// Gets or sets the unique Id.
            /// </summary>
            /// <value>The unique identifier.</value>
            [JsonProperty("_id")]
            [Remote(Meta.DocumentId)]
            public string UniqueId { get; set; }

            /// <summary>
            /// Gets or sets the ETag.
            /// </summary>
            /// <value>The ETag.</value>
            [JsonProperty("_etag")]
            [Remote(Meta.ETag)]
            public string ETag { get; set; }

            /// <summary>
            /// Gets or sets the last update date and time.
            /// </summary>
            /// <value>The last updated date and time.</value>
            [JsonProperty("_updated")]
            [Remote(Meta.LastUpdated)]
            public DateTime Updated { get; set; }

            /// <summary>
            /// Gets or sets the creation date.
            /// </summary>
            /// <value>The creation date.</value>
            [JsonProperty("_created")]
            [Remote(Meta.DateCreated)]
            public DateTime Created { get; set; }

            /// <summary>
            /// Gets or sets the delete state.
            /// </summary>
            /// <value>The creation date.</value>
            [JsonProperty("_deleted")]
            [Remote(Meta.Deleted)]
            public bool Deleted { get; set; }

            [JsonProperty("cid")]
            public string CID { get; set; }

            [JsonProperty("callsign")]
            public string callsign { get; set; }

            [JsonProperty("frequency")]
            public string frequency { get; set; }

            [JsonProperty("realname")]
            public string realname { get; set; }

            [JsonProperty("location")]
            [JsonConverter(typeof(SingleOrArrayConverter<string>))]
            public List<string> location { get; set; }

        }

        class SingleOrArrayConverter<T> : JsonConverter
        {
            public override bool CanConvert(Type objectType)
            {
                return (objectType == typeof(List<T>));
            }

            public override object ReadJson(JsonReader reader, Type objectType, object existingValue, JsonSerializer serializer)
            {
                JToken token = JToken.Load(reader);
                if (token.Type == JTokenType.Array)
                {
                    return token.ToObject<List<T>>();
                }
                return new List<T> { token.ToObject<T>() };
            }

            public override bool CanWrite
            {
                get { return false; }
            }

            public override void WriteJson(JsonWriter writer, object value, JsonSerializer serializer)
            {
                throw new NotImplementedException();
            }
        }
    }

}
