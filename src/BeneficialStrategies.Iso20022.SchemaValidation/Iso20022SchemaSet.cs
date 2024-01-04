using System.Reflection;
using System.Xml;
using System.Xml.Schema;

namespace BeneficialStrategies.Iso20022.SchemaValidation;

public class Iso20022SchemaSet : XmlSchemaSet
{
    public Iso20022SchemaSet() : base(new NameTable())
    {
        var assembly = Assembly.GetExecutingAssembly();
        var xsdResources = assembly.GetManifestResourceNames().Where( n => n.ToLowerInvariant().EndsWith(".xsd"));
        foreach(var resourceName in xsdResources)
        {
            using Stream stream = assembly.GetManifestResourceStream(resourceName) ?? throw new FileNotFoundException(resourceName);
            using var schemaReader = XmlReader.Create(stream);
            Add(null, schemaReader);
        }
    }
}
