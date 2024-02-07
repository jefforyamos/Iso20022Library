﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by ComponentGenerator for CorporateActionDate7.  ISO2002 ID# _Ta7z2tp-Ed-ak6NoX_4Aeg_1877231589.
//

using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;
using System.Xml;
using System.Xml.Linq;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Specifies corporate action dates.
/// </summary>
public partial record CorporateActionDate7
     : IIsoXmlSerilizable<CorporateActionDate7>
{
    #nullable enable
    
    /// <summary>
    /// Date/Time of the posting (credit or debit) to the account.
    /// </summary>
    public required DateAndDateTimeChoice_ PostingDate { get; init; } 
    /// <summary>
    /// Date/time at which assets become available to the account owner (in a credit entry), or cease to be available to the account owner (in a debit entry).
    /// </summary>
    public DateAndDateTimeChoice_? ValueDate { get; init; } 
    /// <summary>
    /// Date/time at which a foreign exchange rate will be determined.
    /// </summary>
    public DateAndDateTimeChoice_? ForeignExchangeRateFixingDate { get; init; } 
    /// <summary>
    /// Date on which a payment can be made, for example, if payment date is a non-business day or to indicate the first payment date of an offer.
    /// </summary>
    public DateAndDateTimeChoice_? EarliestPaymentDate { get; init; } 
    /// <summary>
    /// Date on which the distribution is due to take place (cash and/or securities).
    /// </summary>
    public DateAndDateTimeChoice_? PaymentDate { get; init; } 
    
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
        writer.WriteStartElement(null, "PstngDt", xmlNamespace );
        PostingDate.Serialize(writer, xmlNamespace);
        writer.WriteEndElement();
        if (ValueDate is DateAndDateTimeChoice_ ValueDateValue)
        {
            writer.WriteStartElement(null, "ValDt", xmlNamespace );
            ValueDateValue.Serialize(writer, xmlNamespace);
            writer.WriteEndElement();
        }
        if (ForeignExchangeRateFixingDate is DateAndDateTimeChoice_ ForeignExchangeRateFixingDateValue)
        {
            writer.WriteStartElement(null, "FXRateFxgDt", xmlNamespace );
            ForeignExchangeRateFixingDateValue.Serialize(writer, xmlNamespace);
            writer.WriteEndElement();
        }
        if (EarliestPaymentDate is DateAndDateTimeChoice_ EarliestPaymentDateValue)
        {
            writer.WriteStartElement(null, "EarlstPmtDt", xmlNamespace );
            EarliestPaymentDateValue.Serialize(writer, xmlNamespace);
            writer.WriteEndElement();
        }
        if (PaymentDate is DateAndDateTimeChoice_ PaymentDateValue)
        {
            writer.WriteStartElement(null, "PmtDt", xmlNamespace );
            PaymentDateValue.Serialize(writer, xmlNamespace);
            writer.WriteEndElement();
        }
    }
    public static CorporateActionDate7 Deserialize(XElement element)
    {
        throw new NotImplementedException();
    }
}
