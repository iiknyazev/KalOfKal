using Newtonsoft.Json.Linq;
using Newtonsoft.Json;
using System;

public class FieldItemConverter : JsonCreationConverter<IFieldItem>
{
    protected override IFieldItem Create(Type objectType, JObject jObject)
    {
        switch ((jObject["CellType"] ?? throw new ArgumentNullException(nameof(jObject))).Value<int>())
        {
            case 0:
                return new Obstacle();
            case 1:
                return new Empty();
            case 2:
                return new Star();
            case 3:
                return new Dynamite();
            case 4:
                return new PortalGate();
            case 5:
                return new Piston();
            case 6:
                return new Mucus();
            default:
                throw new ArgumentException(nameof(jObject));
        }
    }
}
public abstract class JsonCreationConverter<T> : JsonConverter
{
    protected abstract T Create(Type objectType, JObject jObject);

    public override bool CanConvert(Type objectType)
    {
        return typeof(T) == objectType;
    }

    public override object ReadJson(JsonReader reader, Type objectType, object existingValue, JsonSerializer serializer)
    {
        try
        {
            var jObject = JObject.Load(reader);
            var target = Create(objectType, jObject) ?? throw new ArgumentNullException();
            serializer.Populate(jObject.CreateReader(), target);
            return target;
        }
        catch (JsonReaderException)
        {
            throw new ArgumentException();
        }
    }

    public override void WriteJson(JsonWriter writer, object value, JsonSerializer serializer)
    {
        throw new NotImplementedException();
    }
}