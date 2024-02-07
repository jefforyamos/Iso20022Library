﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by ComponentGenerator for AggregationTransaction1.  ISO2002 ID# _Yy7UkDDuEeO9waS4ina8CA.
//

using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;
using System.Xml;
using System.Xml.Linq;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Payment transaction with an aggregated amount.
/// </summary>
public partial record AggregationTransaction1
     : IIsoXmlSerilizable<AggregationTransaction1>
{
    #nullable enable
    
    /// <summary>
    /// Date and time of the first payment.
    /// </summary>
    public IsoISODateTime? FirstPaymentDateTime { get; init; } 
    /// <summary>
    /// Date and time of the last payment.
    /// </summary>
    public IsoISODateTime? LastPaymentDateTime { get; init; } 
    /// <summary>
    /// Total number of payments that has been aggregated.
    /// </summary>
    public IsoNumber? NumberOfPayments { get; init; } 
    /// <summary>
    /// Individual payment that has been aggregated.
    /// </summary>
    public DetailedAmount6? IndividualPayment { get; init; } 
    
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
        if (FirstPaymentDateTime is IsoISODateTime FirstPaymentDateTimeValue)
        {
            writer.WriteStartElement(null, "FrstPmtDtTm", xmlNamespace );
            writer.WriteValue(SerializationFormatter.IsoISODateTime(FirstPaymentDateTimeValue)); // data type ISODateTime System.DateTime
            writer.WriteEndElement();
        }
        if (LastPaymentDateTime is IsoISODateTime LastPaymentDateTimeValue)
        {
            writer.WriteStartElement(null, "LastPmtDtTm", xmlNamespace );
            writer.WriteValue(SerializationFormatter.IsoISODateTime(LastPaymentDateTimeValue)); // data type ISODateTime System.DateTime
            writer.WriteEndElement();
        }
        if (NumberOfPayments is IsoNumber NumberOfPaymentsValue)
        {
            writer.WriteStartElement(null, "NbOfPmts", xmlNamespace );
            writer.WriteValue(SerializationFormatter.IsoNumber(NumberOfPaymentsValue)); // data type Number System.UInt64
            writer.WriteEndElement();
        }
        if (IndividualPayment is DetailedAmount6 IndividualPaymentValue)
        {
            writer.WriteStartElement(null, "IndvPmt", xmlNamespace );
            IndividualPaymentValue.Serialize(writer, xmlNamespace);
            writer.WriteEndElement();
        }
    }
    public static AggregationTransaction1 Deserialize(XElement element)
    {
        throw new NotImplementedException();
    }
}
