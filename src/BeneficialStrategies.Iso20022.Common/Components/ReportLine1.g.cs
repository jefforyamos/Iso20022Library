﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by ComponentGenerator for ReportLine1.  ISO2002 ID# _ToDCydp-Ed-ak6NoX_4Aeg_-314950341.
//

using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;
using System.Xml;
using System.Xml.Linq;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Information about a payment against a purchase order.
/// </summary>
public partial record ReportLine1
     : IIsoXmlSerilizable<ReportLine1>
{
    #nullable enable
    
    /// <summary>
    /// Unique identification assigned by the matching application to the transaction.
    /// </summary>
    public required IsoMax35Text TransactionIdentification { get; init; } 
    /// <summary>
    /// Identifies the status of the transaction.
    /// </summary>
    public required TransactionStatus4 TransactionStatus { get; init; } 
    /// <summary>
    /// Unique identification of the purchase order, assigned by the buyer.
    /// </summary>
    public required DocumentIdentification7 PurchaseOrderReference { get; init; } 
    /// <summary>
    /// Total amount of the purchase order after taxes, adjustments and charges.
    /// </summary>
    public required IsoCurrencyAndAmount PurchaseOrderTotalNetAmount { get; init; } 
    /// <summary>
    /// Accumulated net amount, after adjustments, intended to be paid.
    /// </summary>
    public required IsoCurrencyAndAmount AccumulatedNetAmount { get; init; } 
    
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
        writer.WriteStartElement(null, "TxId", xmlNamespace );
        writer.WriteValue(SerializationFormatter.IsoMax35Text(TransactionIdentification)); // data type Max35Text System.String
        writer.WriteEndElement();
        writer.WriteStartElement(null, "TxSts", xmlNamespace );
        TransactionStatus.Serialize(writer, xmlNamespace);
        writer.WriteEndElement();
        writer.WriteStartElement(null, "PurchsOrdrRef", xmlNamespace );
        PurchaseOrderReference.Serialize(writer, xmlNamespace);
        writer.WriteEndElement();
        writer.WriteStartElement(null, "PurchsOrdrTtlNetAmt", xmlNamespace );
        writer.WriteValue(SerializationFormatter.IsoCurrencyAndAmount(PurchaseOrderTotalNetAmount)); // data type CurrencyAndAmount System.Decimal
        writer.WriteEndElement();
        writer.WriteStartElement(null, "AcmltdNetAmt", xmlNamespace );
        writer.WriteValue(SerializationFormatter.IsoCurrencyAndAmount(AccumulatedNetAmount)); // data type CurrencyAndAmount System.Decimal
        writer.WriteEndElement();
    }
    public static ReportLine1 Deserialize(XElement element)
    {
        throw new NotImplementedException();
    }
}
