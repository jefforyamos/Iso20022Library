﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by ConcreteChoiceGenerator for UKDomesticSortCode.  ISO2002 ID# _VwSCZ7NIEeejueAciesPMA.
//

using BeneficialStrategies.Iso20022.Components;
using BeneficialStrategies.Iso20022.ExternalSchema;
using System.Xml;
using System.Xml.Linq;

namespace BeneficialStrategies.Iso20022.Choices.ClearingSystemMemberIdentification4Choice;

/// <summary>
/// United Kingdom (UK) Sort Code - identifies British financial institutions on the British national clearing systems. The sort code is assigned by the Association for Payments and Clearing Services (APACS).
/// </summary>
public partial record UKDomesticSortCode : ClearingSystemMemberIdentification4Choice_
     , IIsoXmlSerilizable<UKDomesticSortCode>
{
    #nullable enable
    
    /// <summary>
    /// Contains the main value for the container.
    /// United Kingdom (UK) Sort Code. Identifies British financial institutions on the British national clearing systems. The sort code is assigned by the Association for Payments and Clearing Services (APACS).
    /// </summary>
    public required IsoUKDomesticSortCodeIdentifier Value { get; init; } 
    
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
        writer.WriteStartElement(null, "GBSC", xmlNamespace );
        writer.WriteValue(SerializationFormatter.IsoUKDomesticSortCodeIdentifier(Value)); // data type UKDomesticSortCodeIdentifier System.String
        writer.WriteEndElement();
    }
    public static new UKDomesticSortCode Deserialize(XElement element)
    {
        throw new NotImplementedException();
    }
}
