﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by ComponentGenerator for NameAndAddress1.  ISO2002 ID# _VFxlA9p-Ed-ak6NoX_4Aeg_-1749124756.
//

using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;
using System.Xml;
using System.Xml.Linq;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Information that locates and identifies a specific address, as defined by postal services.
/// </summary>
public partial record NameAndAddress1
     : IIsoXmlSerilizable<NameAndAddress1>
{
    #nullable enable
    
    /// <summary>
    /// Name by which a party is known and which is usually used to identify that party.
    /// </summary>
    public IsoMax35Text? Name { get; init; } 
    /// <summary>
    /// Postal address of a party.
    /// </summary>
    public required LongPostalAddress1Choice_ Address { get; init; } 
    
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
        if (Name is IsoMax35Text NameValue)
        {
            writer.WriteStartElement(null, "Nm", xmlNamespace );
            writer.WriteValue(SerializationFormatter.IsoMax35Text(NameValue)); // data type Max35Text System.String
            writer.WriteEndElement();
        }
        writer.WriteStartElement(null, "Adr", xmlNamespace );
        Address.Serialize(writer, xmlNamespace);
        writer.WriteEndElement();
    }
    public static NameAndAddress1 Deserialize(XElement element)
    {
        throw new NotImplementedException();
    }
}
