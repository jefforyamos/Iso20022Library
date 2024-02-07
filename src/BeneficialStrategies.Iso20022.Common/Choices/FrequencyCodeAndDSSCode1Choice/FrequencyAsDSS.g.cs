﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by ConcreteChoiceGenerator for FrequencyAsDSS.  ISO2002 ID# _Q7Vk59p-Ed-ak6NoX_4Aeg_1533373125.
//

using BeneficialStrategies.Iso20022.Components;
using BeneficialStrategies.Iso20022.ExternalSchema;
using System.Xml;
using System.Xml.Linq;

namespace BeneficialStrategies.Iso20022.Choices.FrequencyCodeAndDSSCode1Choice;

/// <summary>
/// Frequency expressed as a data source scheme and a code used within the data source scheme.
/// </summary>
public partial record FrequencyAsDSS : FrequencyCodeAndDSSCode1Choice_
     , IIsoXmlSerilizable<FrequencyAsDSS>
{
    #nullable enable
    
    /// <summary>
    /// Entity that assigns the identification.
    /// </summary>
    public required IsoMax8Text Issuer { get; init; } 
    /// <summary>
    /// Proprietary information, often a code, issued by the data source scheme issuer.
    /// </summary>
    public required IsoMax35Text Information { get; init; } 
    
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
        writer.WriteStartElement(null, "Issr", xmlNamespace );
        writer.WriteValue(SerializationFormatter.IsoMax8Text(Issuer)); // data type Max8Text System.String
        writer.WriteEndElement();
        writer.WriteStartElement(null, "Inf", xmlNamespace );
        writer.WriteValue(SerializationFormatter.IsoMax35Text(Information)); // data type Max35Text System.String
        writer.WriteEndElement();
    }
    public static new FrequencyAsDSS Deserialize(XElement element)
    {
        throw new NotImplementedException();
    }
}
