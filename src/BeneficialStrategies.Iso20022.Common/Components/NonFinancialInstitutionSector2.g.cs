﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by ComponentGenerator for NonFinancialInstitutionSector2.  ISO2002 ID# _QSs_AcDyEeW6TPUXKSV6dQ.
//

using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;
using System.Xml;
using System.Xml.Linq;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Provides detailed information concerning non financial counterparties.
/// </summary>
public partial record NonFinancialInstitutionSector2
     : IIsoXmlSerilizable<NonFinancialInstitutionSector2>
{
    #nullable enable
    
    /// <summary>
    /// Taxonomy for non-financial counterparties. The categories correspond to the main sections of NACE classification as defined in the regulation.
    /// </summary>
    public IsoNACEDomainIdentifier? Sector { get; init; } 
    /// <summary>
    /// Information whether the reporting counterparty is above the clearing threshold.
    /// </summary>
    public IsoTrueFalseIndicator? ClearingThreshold { get; init; } 
    /// <summary>
    /// Directly linked to commercial activity or treasury financing: Information on whether the contract is objectively measurable as directly linked to the reporting counterparty's commercial or treasury financing activity.
    /// </summary>
    public IsoTrueFalseIndicator? DirectlyLinkedActivity { get; init; } 
    
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
        if (Sector is IsoNACEDomainIdentifier SectorValue)
        {
            writer.WriteStartElement(null, "Sctr", xmlNamespace );
            writer.WriteValue(SerializationFormatter.IsoNACEDomainIdentifier(SectorValue)); // data type NACEDomainIdentifier System.String
            writer.WriteEndElement();
        }
        if (ClearingThreshold is IsoTrueFalseIndicator ClearingThresholdValue)
        {
            writer.WriteStartElement(null, "ClrThrshld", xmlNamespace );
            writer.WriteValue(SerializationFormatter.IsoTrueFalseIndicator(ClearingThresholdValue)); // data type TrueFalseIndicator System.String
            writer.WriteEndElement();
        }
        if (DirectlyLinkedActivity is IsoTrueFalseIndicator DirectlyLinkedActivityValue)
        {
            writer.WriteStartElement(null, "DrctlyLkdActvty", xmlNamespace );
            writer.WriteValue(SerializationFormatter.IsoTrueFalseIndicator(DirectlyLinkedActivityValue)); // data type TrueFalseIndicator System.String
            writer.WriteEndElement();
        }
    }
    public static NonFinancialInstitutionSector2 Deserialize(XElement element)
    {
        throw new NotImplementedException();
    }
}
