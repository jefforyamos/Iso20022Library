﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by ComponentGenerator for StoredValueResponse5.  ISO2002 ID# _9IcKYU4AEey_VecAUE-C9Q.
//

using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;
using System.Xml;
using System.Xml.Linq;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Response data to a Stored Value request.
/// </summary>
public partial record StoredValueResponse5
     : IIsoXmlSerilizable<StoredValueResponse5>
{
    #nullable enable
    
    /// <summary>
    /// Sale System identification of the transaction in an unambiguous way.
    /// </summary>
    public TransactionIdentifier1? SaleTransactionIdentification { get; init; } 
    /// <summary>
    /// Unique identification of a POI transaction.
    /// </summary>
    public required TransactionIdentifier1 POITransactionIdentification { get; init; } 
    /// <summary>
    /// Result of loading/reloading a stored value card.
    /// </summary>
    public StoredValueData5? Result { get; init; } 
    /// <summary>
    /// Customer or Merchant payment receipt.
    /// </summary>
    public PaymentReceipt4? Receipt { get; init; } 
    
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
        if (SaleTransactionIdentification is TransactionIdentifier1 SaleTransactionIdentificationValue)
        {
            writer.WriteStartElement(null, "SaleTxId", xmlNamespace );
            SaleTransactionIdentificationValue.Serialize(writer, xmlNamespace);
            writer.WriteEndElement();
        }
        writer.WriteStartElement(null, "POITxId", xmlNamespace );
        POITransactionIdentification.Serialize(writer, xmlNamespace);
        writer.WriteEndElement();
        if (Result is StoredValueData5 ResultValue)
        {
            writer.WriteStartElement(null, "Rslt", xmlNamespace );
            ResultValue.Serialize(writer, xmlNamespace);
            writer.WriteEndElement();
        }
        if (Receipt is PaymentReceipt4 ReceiptValue)
        {
            writer.WriteStartElement(null, "Rct", xmlNamespace );
            ReceiptValue.Serialize(writer, xmlNamespace);
            writer.WriteEndElement();
        }
    }
    public static StoredValueResponse5 Deserialize(XElement element)
    {
        throw new NotImplementedException();
    }
}
