﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by ComponentGenerator for CorporateSectorCriteria3.  ISO2002 ID# _tkArEdGgEeaQk737TH1Fzw.
//

using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;
using System.Xml;
using System.Xml.Linq;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Taxonomy for financial and non financial counterparties.
/// </summary>
public partial record CorporateSectorCriteria3
     : IIsoXmlSerilizable<CorporateSectorCriteria3>
{
    #nullable enable
    
    /// <summary>
    /// Indicates that reporting counterparty is a financial institution.
    /// </summary>
    public FinancialPartySectorType1Code? FinancialInstitutionSector { get; init; } 
    /// <summary>
    /// Indicates that reporting counterparty is a non financial institution.
    /// </summary>
    public NonFinancialPartySector1Code? NonFinancialInstitutionSector { get; init; } 
    /// <summary>
    /// Indicates that reporting counterparty is another type of counterparty as defined by specific regulations (e.g. a CCP) and the detailed sector is not reported.
    /// </summary>
    public NotReported1Code? NotReported { get; init; } 
    
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
        if (FinancialInstitutionSector is FinancialPartySectorType1Code FinancialInstitutionSectorValue)
        {
            writer.WriteStartElement(null, "FISctr", xmlNamespace );
            writer.WriteValue(FinancialInstitutionSectorValue.ToString()); // Enum value
            writer.WriteEndElement();
        }
        if (NonFinancialInstitutionSector is NonFinancialPartySector1Code NonFinancialInstitutionSectorValue)
        {
            writer.WriteStartElement(null, "NFISctr", xmlNamespace );
            writer.WriteValue(NonFinancialInstitutionSectorValue.ToString()); // Enum value
            writer.WriteEndElement();
        }
        if (NotReported is NotReported1Code NotReportedValue)
        {
            writer.WriteStartElement(null, "NotRptd", xmlNamespace );
            writer.WriteValue(NotReportedValue.ToString()); // Enum value
            writer.WriteEndElement();
        }
    }
    public static CorporateSectorCriteria3 Deserialize(XElement element)
    {
        throw new NotImplementedException();
    }
}
