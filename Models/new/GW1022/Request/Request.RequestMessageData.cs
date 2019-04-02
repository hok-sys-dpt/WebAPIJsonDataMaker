namespace BankVision.WebAPI.Models.GW1022.Request
{
    using System;
    using System.IO;
    using System.Xml.Serialization;
    using Newtonsoft.Json;
    using Newtonsoft.Json.Serialization;
    using System.ComponentModel;
    using System.Globalization;
    using System.Text;

    using BankVision.WebAPI.Models.Common;

    [TypeConverter(typeof(RequestMessageDataConverter))]
    [JsonConverter(typeof(RequestMessageDataConverterOfJsonNet))]
    public class RequestMessageData : IWisRequestSystemInfo
    {
        public WisRequestSystemInfo WisRequestSystemInfo { get; set; }
        public GaikokukawasesobaIchiranShokai GaikokukawasesobaIchiranShokai;

        public RequestMessageData Clone()
        {
            using (MemoryStream stream = new MemoryStream())
            {
                XmlSerializer serializer = new XmlSerializer(typeof(RequestMessageData));
                serializer.Serialize(stream, this);
                stream.Position = 0L;
                return (RequestMessageData)serializer.Deserialize(stream);
            }
        }
    }

    public class RequestMessageDataConverter : TypeConverter
    {
        public override bool CanConvertFrom(ITypeDescriptorContext context, Type sourceType)
        {
            if (sourceType == typeof(string))
            {
                return true;
            }

            return base.CanConvertFrom(context, sourceType);
        }

        public override object ConvertFrom(ITypeDescriptorContext context, CultureInfo culture, object value)
        {
            try
            {
                return JsonConvert.DeserializeObject<RequestMessageData>((string)value);
            }
            catch
            {
                return base.ConvertFrom(context, culture, value);
            }
        }
    }
    
    public class RequestMessageDataConverterOfJsonNet : JsonConverter
    {
        static readonly IContractResolver resolver = new RequestMessageDataConverterOfJsonNetResolver();

        class RequestMessageDataConverterOfJsonNetResolver : DefaultContractResolver
        {
            protected override JsonContract CreateContract(Type objectType)
            {
                if (typeof(RequestMessageData).IsAssignableFrom(objectType))
                {
                    var contract = this.CreateObjectContract(objectType);
                    contract.Converter = null;
                    return contract;
                }

                return base.CreateContract(objectType);
            }
        }

        public override bool CanConvert(Type objectType)
        {
            return typeof(RequestMessageData).IsAssignableFrom(objectType);
        }

        public override object ReadJson(JsonReader reader, Type objectType, object existingValue, JsonSerializer serializer)
        {
            var settings = new JsonSerializerSettings
            {
                ContractResolver = resolver,
                NullValueHandling = NullValueHandling.Ignore,
                MissingMemberHandling = MissingMemberHandling.Ignore,
                Error = delegate (object sender, Newtonsoft.Json.Serialization.ErrorEventArgs args)
                {
                    args.ErrorContext.Handled = true;
                }
            };
            return JsonSerializer.CreateDefault(settings).Deserialize(reader, objectType);
        }

        public override void WriteJson(JsonWriter writer, object value, JsonSerializer serializer)
        {
            JsonSerializer.CreateDefault(new JsonSerializerSettings { ContractResolver = resolver })
                .Serialize(writer, value);
        }
    }
}