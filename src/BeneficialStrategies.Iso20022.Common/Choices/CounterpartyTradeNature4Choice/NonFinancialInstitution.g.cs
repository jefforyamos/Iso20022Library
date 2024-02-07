﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by ConcreteChoiceGenerator for NonFinancialInstitution.  ISO2002 ID# _6j9NM7sAEea-m5tPqiasmQ.
//

using BeneficialStrategies.Iso20022.Components;
using BeneficialStrategies.Iso20022.ExternalSchema;
using System.Xml;
using System.Xml.Linq;

namespace BeneficialStrategies.Iso20022.Choices.CounterpartyTradeNature4Choice;

/// <summary>
/// Indicates that reporting counterparty is a non financial institution.
/// </summary>
public partial record NonFinancialInstitution : CounterpartyTradeNature4Choice_
     , IIsoXmlSerilizable<NonFinancialInstitution>
{
    #nullable enable
    
    /// <summary>
    /// Taxonomy for non-financial counterparties. The categories correspond to the main sections of NACE classification as defined in the regulation.
    /// </summary>
    public IsoNACEDomainIdentifier? Sector { get; init; } 
    /// <summary>
    /// Information whether the reporting counterparty is above the clearing threshold referred to the regulation.
    /// </summary>
    public required IsoTrueFalseIndicator ClearingThreshold { get; init; } 
    /// <summary>
    /// Directly linked to commercial activity or treasury financing: Information on whether the contract is objectively measurable as directly linked to the reporting counterparty's commercial or treasury financing activity.
    /// </summary>
    public required IsoTrueFalseIndicator DirectlyLinkedActivity { get; init; } 
    
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
        if (Sector is IsoNACEDomainIdentifier SectorValue)
        {
            writer.WriteStartElement(null, "Sctr", xmlNamespace );
            writer.WriteValue(SerializationFormatter.IsoNACEDomainIdentifier(SectorValue)); // data type NACEDomainIdentifier System.String
            writer.WriteEndElement();
        }
        writer.WriteStartElement(null, "ClrThrshld", xmlNamespace );
        writer.WriteValue(SerializationFormatter.IsoTrueFalseIndicator(ClearingThreshold)); // data type TrueFalseIndicator System.String
        writer.WriteEndElement();
        writer.WriteStartElement(null, "DrctlyLkdActvty", xmlNamespace );
        writer.WriteValue(SerializationFormatter.IsoTrueFalseIndicator(DirectlyLinkedActivity)); // data type TrueFalseIndicator System.String
        writer.WriteEndElement();
    }
    public static new NonFinancialInstitution Deserialize(XElement element)
    {
        throw new NotImplementedException();
    }
}
