﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by ComponentGenerator for ExpectedExecutionDetails1.  ISO2002 ID# _VGhL7tp-Ed-ak6NoX_4Aeg_-1557006265.
//

using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;
using System.Xml;
using System.Xml.Linq;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Expected trade date and expected settlement date of the order execution.
/// </summary>
public partial record ExpectedExecutionDetails1
     : IIsoXmlSerilizable<ExpectedExecutionDetails1>
{
    #nullable enable
    
    /// <summary>
    /// Expected date or expected date and time at which a price will be applied according to the terms of the prospectus.
    /// </summary>
    public DateAndDateTimeChoice_? ExpectedTradeDateTime { get; init; } 
    /// <summary>
    /// Expected date at which the financial instruments will be exchanged against cash.
    /// </summary>
    public IsoISODate? ExpectedSettlementDate { get; init; } 
    
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
        if (ExpectedTradeDateTime is DateAndDateTimeChoice_ ExpectedTradeDateTimeValue)
        {
            writer.WriteStartElement(null, "XpctdTradDtTm", xmlNamespace );
            ExpectedTradeDateTimeValue.Serialize(writer, xmlNamespace);
            writer.WriteEndElement();
        }
        if (ExpectedSettlementDate is IsoISODate ExpectedSettlementDateValue)
        {
            writer.WriteStartElement(null, "XpctdSttlmDt", xmlNamespace );
            writer.WriteValue(SerializationFormatter.IsoISODate(ExpectedSettlementDateValue)); // data type ISODate System.DateOnly
            writer.WriteEndElement();
        }
    }
    public static ExpectedExecutionDetails1 Deserialize(XElement element)
    {
        throw new NotImplementedException();
    }
}
