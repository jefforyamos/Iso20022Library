﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by ComponentGenerator for SecuritiesAuditTrailSearchCriteria4.  ISO2002 ID# _QOJ0N5JKEeuAlLVx8pyt3w.
//

using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;
using System.Xml;
using System.Xml.Linq;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Describes search criteria for securities audit trail query.
/// </summary>
public partial record SecuritiesAuditTrailSearchCriteria4
     : IIsoXmlSerilizable<SecuritiesAuditTrailSearchCriteria4>
{
    #nullable enable
    
    /// <summary>
    /// Describes security to be queried.
    /// </summary>
    public SecurityIdentification39? FinancialInstrumentIdentification { get; init; } 
    /// <summary>
    /// Describes date period for querying information.
    /// </summary>
    public DatePeriodSearch1Choice_? DatePeriod { get; init; } 
    
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
        if (FinancialInstrumentIdentification is SecurityIdentification39 FinancialInstrumentIdentificationValue)
        {
            writer.WriteStartElement(null, "FinInstrmId", xmlNamespace );
            FinancialInstrumentIdentificationValue.Serialize(writer, xmlNamespace);
            writer.WriteEndElement();
        }
        if (DatePeriod is DatePeriodSearch1Choice_ DatePeriodValue)
        {
            writer.WriteStartElement(null, "DtPrd", xmlNamespace );
            DatePeriodValue.Serialize(writer, xmlNamespace);
            writer.WriteEndElement();
        }
    }
    public static SecuritiesAuditTrailSearchCriteria4 Deserialize(XElement element)
    {
        throw new NotImplementedException();
    }
}
