﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by ConcreteChoiceGenerator for Structured.  ISO2002 ID# _Uys4Btp-Ed-ak6NoX_4Aeg_1723007680.
//

using BeneficialStrategies.Iso20022.Components;
using BeneficialStrategies.Iso20022.ExternalSchema;
using System.Xml;
using System.Xml.Linq;

namespace BeneficialStrategies.Iso20022.Choices.DataFormat1Choice;

/// <summary>
/// Specification of data in structured form.
/// </summary>
public partial record Structured : DataFormat1Choice_
     , IIsoXmlSerilizable<Structured>
{
    #nullable enable
    
    /// <summary>
    /// Name of the identification scheme.
    /// </summary>
    public required IsoMax35Text SchemeName { get; init; } 
    /// <summary>
    /// Entity that assigns the identification.
    /// </summary>
    public IsoMax35Text? Issuer { get; init; } 
    
    #nullable disable
    
    
    /// <summary>
    /// Used to format the various primative types during serialization.
    /// </summary>
    public static SerializationFormatter SerializationFormatter { get; set; } = SerializationFormatter.GlobalInstance;
    
    /// <summary>
    /// Serializes the state of this record according to Iso20022 specifications.
    /// </summary>
    public override void Serialize(XmlWriter writer, string xmlNamespace)
    {
        writer.WriteStartElement(null, "SchmeNm", xmlNamespace );
        writer.WriteValue(SerializationFormatter.IsoMax35Text(SchemeName)); // data type Max35Text System.String
        writer.WriteEndElement();
        if (Issuer is IsoMax35Text IssuerValue)
        {
            writer.WriteStartElement(null, "Issr", xmlNamespace );
            writer.WriteValue(SerializationFormatter.IsoMax35Text(IssuerValue)); // data type Max35Text System.String
            writer.WriteEndElement();
        }
    }
    public static new Structured Deserialize(XElement element)
    {
        throw new NotImplementedException();
    }
}
