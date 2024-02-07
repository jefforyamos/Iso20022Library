﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by ComponentGenerator for BranchAndFinancialInstitutionIdentification3.  ISO2002 ID# _TFUwNdp-Ed-ak6NoX_4Aeg_-107465569.
//

using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;
using System.Xml;
using System.Xml.Linq;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Unique and unambiguous identifier of a financial institution or a branch of a financial institution, as assigned under an internationally recognised or proprietary identification scheme.
/// </summary>
public partial record BranchAndFinancialInstitutionIdentification3
     : IIsoXmlSerilizable<BranchAndFinancialInstitutionIdentification3>
{
    #nullable enable
    
    /// <summary>
    /// Unique and unambiguous identifier of a financial institution, as assigned under an internationally recognised or proprietary identification scheme.
    /// </summary>
    public required FinancialInstitutionIdentification5Choice_ FinancialInstitutionIdentification { get; init; } 
    /// <summary>
    /// Information identifying a specific branch of a financial institution.||Usage: this component should be used in case the identification information in the financial institution component does not provide identification up to branch level.
    /// </summary>
    public BranchData? BranchIdentification { get; init; } 
    
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
        writer.WriteStartElement(null, "FinInstnId", xmlNamespace );
        FinancialInstitutionIdentification.Serialize(writer, xmlNamespace);
        writer.WriteEndElement();
        if (BranchIdentification is BranchData BranchIdentificationValue)
        {
            writer.WriteStartElement(null, "BrnchId", xmlNamespace );
            BranchIdentificationValue.Serialize(writer, xmlNamespace);
            writer.WriteEndElement();
        }
    }
    public static BranchAndFinancialInstitutionIdentification3 Deserialize(XElement element)
    {
        throw new NotImplementedException();
    }
}
