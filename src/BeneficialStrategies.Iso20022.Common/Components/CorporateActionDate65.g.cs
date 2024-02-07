﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by ComponentGenerator for CorporateActionDate65.  ISO2002 ID# _wZOj8bQZEeeKRKrD60ELBQ.
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
public partial record CorporateActionDate65
     : IIsoXmlSerilizable<CorporateActionDate65>
{
    #nullable enable
    
    /// <summary>
    /// Date/time of the posting (credit or debit) to the account.
    /// </summary>
    public required DateAndDateTime2Choice_ PostingDate { get; init; } 
    /// <summary>
    /// Date/time when calculating economic benefit for a cash amount.
    /// </summary>
    public DateAndDateTime2Choice_? ValueDate { get; init; } 
    /// <summary>
    /// Date/time at which a foreign exchange rate will be determined.
    /// </summary>
    public DateAndDateTime2Choice_? ForeignExchangeRateFixingDate { get; init; } 
    /// <summary>
    /// Date/time on which a payment can be made, for example, if the payment date is a non-business day or to indicate the first payment date of an offer.
    /// </summary>
    public DateAndDateTime2Choice_? EarliestPaymentDate { get; init; } 
    /// <summary>
    /// Date on which the distribution is due to take place (cash and/or securities).
    /// </summary>
    public DateAndDateTime2Choice_? PaymentDate { get; init; } 
    
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
        if (ValueDate is DateAndDateTime2Choice_ ValueDateValue)
        {
            writer.WriteStartElement(null, "ValDt", xmlNamespace );
            ValueDateValue.Serialize(writer, xmlNamespace);
            writer.WriteEndElement();
        }
        if (ForeignExchangeRateFixingDate is DateAndDateTime2Choice_ ForeignExchangeRateFixingDateValue)
        {
            writer.WriteStartElement(null, "FXRateFxgDt", xmlNamespace );
            ForeignExchangeRateFixingDateValue.Serialize(writer, xmlNamespace);
            writer.WriteEndElement();
        }
        if (EarliestPaymentDate is DateAndDateTime2Choice_ EarliestPaymentDateValue)
        {
            writer.WriteStartElement(null, "EarlstPmtDt", xmlNamespace );
            EarliestPaymentDateValue.Serialize(writer, xmlNamespace);
            writer.WriteEndElement();
        }
        if (PaymentDate is DateAndDateTime2Choice_ PaymentDateValue)
        {
            writer.WriteStartElement(null, "PmtDt", xmlNamespace );
            PaymentDateValue.Serialize(writer, xmlNamespace);
            writer.WriteEndElement();
        }
    }
    public static CorporateActionDate65 Deserialize(XElement element)
    {
        throw new NotImplementedException();
    }
}
