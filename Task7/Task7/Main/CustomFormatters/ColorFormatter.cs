using System.Drawing;
using MessagePack;
using MessagePack.Formatters;

public sealed class ColorFormatter : IMessagePackFormatter<Color>
{
    public void Serialize(ref MessagePackWriter writer, Color value, MessagePackSerializerOptions options)
    {
        writer.WriteInt32(value.ToArgb());
    }

    public Color Deserialize(ref MessagePackReader reader, MessagePackSerializerOptions options)
    {
        return Color.FromArgb(reader.ReadInt32());
    }
}