﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by ConcreteChoiceGenerator for SecuritiesFinancingTransactionIdentification.  ISO2002 ID# _UR6fLdp-Ed-ak6NoX_4Aeg_664442061.
//

using BeneficialStrategies.Iso20022.Components;
using BeneficialStrategies.Iso20022.ExternalSchema;
using System.Xml;
using System.Xml.Linq;

namespace BeneficialStrategies.Iso20022.Choices.References4Choice;

/// <summary>
/// Unambiguous identification of the underlying securities financing transaction (not the underlying securities financing trade) as assigned by the instructing party.
/// </summary>
public partial record SecuritiesFinancingTransactionIdentification : References4Choice_
     , IIsoXmlSerilizable<SecuritiesFinancingTransactionIdentification>
{
    #nullable enable
    
    /// <summary>
    /// Provides unambiguous transaction identification information.
    /// </summary>
    public required IsoMax35Text TransactionIdentification { get; init; } 
    /// <summary>
    /// Specifies if the movement on a securities account results from a deliver or a receive instruction.
    /// </summary>
    public ReceiveDelivery1Code? SecuritiesMovementType { get; init; } 
    /// <summary>
    /// Specifies how the transaction is to be settled, for example, against payment.
    /// </summary>
    public DeliveryReceiptType2Code? Payment { get; init; } 
    
    #nullable disable
    
    
    /// <summary>
    /// Used to format the various primative types during serialization.
    /// </summary>
    public static SerializationFormatter SerializationFormatter { get; set; } = SerializationFormatter.GlobalInstance;
    
    /// <summary>
    /// Serializes the state of this record according to Iso20022 specifications.
    /// </summary>
    public override void Serialize(XmlWriter writer, string xmlNamespace)
    {
        writer.WriteStartElement(null, "TxId", xmlNamespace );
        writer.WriteValue(SerializationFormatter.IsoMax35Text(TransactionIdentification)); // data type Max35Text System.String
        writer.WriteEndElement();
        if (SecuritiesMovementType is ReceiveDelivery1Code SecuritiesMovementTypeValue)
        {
            writer.WriteStartElement(null, "SctiesMvmntTp", xmlNamespace );
            writer.WriteValue(SecuritiesMovementTypeValue.ToString()); // Enum value
            writer.WriteEndElement();
        }
        if (Payment is DeliveryReceiptType2Code PaymentValue)
        {
            writer.WriteStartElement(null, "Pmt", xmlNamespace );
            writer.WriteValue(PaymentValue.ToString()); // Enum value
            writer.WriteEndElement();
        }
    }
    public static new SecuritiesFinancingTransactionIdentification Deserialize(XElement element)
    {
        throw new NotImplementedException();
    }
}
