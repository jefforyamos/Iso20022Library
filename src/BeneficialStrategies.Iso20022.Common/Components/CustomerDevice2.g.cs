﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by ComponentGenerator for CustomerDevice2.  ISO2002 ID# _c9QGQEamEeeIjf8aP9KbJA.
//

using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;
using System.Xml;
using System.Xml.Linq;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Details of the customer device.
/// </summary>
public partial record CustomerDevice2
     : IIsoXmlSerilizable<CustomerDevice2>
{
    #nullable enable
    
    /// <summary>
    /// Information about the customer device.
    /// </summary>
    public Device1? Device { get; init; } 
    /// <summary>
    /// Identification of the customer device.
    /// </summary>
    public IsoMax70Text? Identification { get; init; } 
    /// <summary>
    /// Provider of the customer device.
    /// </summary>
    public IsoMax35Text? Provider { get; init; } 
    
    #nullable disable
    
    
    /// <summary>
    /// Used to format the various primative types during serialization.
    /// </summary>
    public static SerializationFormatter SerializationFormatter { get; set; } = SerializationFormatter.GlobalInstance;
    
    /// <summary>
    /// Serializes the state of this record according to Iso20022 specifications.
    /// </summary>
    public void Serialize(XmlWriter writer, string xmlNamespace)
    {
        if (Device is Device1 DeviceValue)
        {
            writer.WriteStartElement(null, "Dvc", xmlNamespace );
            DeviceValue.Serialize(writer, xmlNamespace);
            writer.WriteEndElement();
        }
        if (Identification is IsoMax70Text IdentificationValue)
        {
            writer.WriteStartElement(null, "Id", xmlNamespace );
            writer.WriteValue(SerializationFormatter.IsoMax70Text(IdentificationValue)); // data type Max70Text System.String
            writer.WriteEndElement();
        }
        if (Provider is IsoMax35Text ProviderValue)
        {
            writer.WriteStartElement(null, "Prvdr", xmlNamespace );
            writer.WriteValue(SerializationFormatter.IsoMax35Text(ProviderValue)); // data type Max35Text System.String
            writer.WriteEndElement();
        }
    }
    public static CustomerDevice2 Deserialize(XElement element)
    {
        throw new NotImplementedException();
    }
}
