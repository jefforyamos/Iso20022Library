﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by ConcreteChoiceGenerator for SecuritiesFinancingConfirmationIdentification.  ISO2002 ID# _ts-sNQ34EeKN_Y-2Awiamw.
//

using BeneficialStrategies.Iso20022.Components;
using BeneficialStrategies.Iso20022.ExternalSchema;
using System.Xml;
using System.Xml.Linq;

namespace BeneficialStrategies.Iso20022.Choices.References37Choice;

/// <summary>
/// Unambiguous identification of the confirmation to be cancelled.
/// </summary>
public partial record SecuritiesFinancingConfirmationIdentification : References37Choice_
     , IIsoXmlSerilizable<SecuritiesFinancingConfirmationIdentification>
{
    #nullable enable
    
    /// <summary>
    /// Provides unambiguous transaction identification information.
    /// </summary>
    public required IsoMax35Text TransactionIdentification { get; init; } 
    /// <summary>
    /// Specifies if the movement on a securities account results from a deliver or a receive instruction.
    /// </summary>
    public required ReceiveDelivery1Code SecuritiesMovementType { get; init; } 
    /// <summary>
    /// Specifies how the transaction is to be settled, for example, against payment.
    /// </summary>
    public required DeliveryReceiptType2Code Payment { get; init; } 
    
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
        writer.WriteStartElement(null, "SctiesMvmntTp", xmlNamespace );
        writer.WriteValue(SecuritiesMovementType.ToString()); // Enum value
        writer.WriteEndElement();
        writer.WriteStartElement(null, "Pmt", xmlNamespace );
        writer.WriteValue(Payment.ToString()); // Enum value
        writer.WriteEndElement();
    }
    public static new SecuritiesFinancingConfirmationIdentification Deserialize(XElement element)
    {
        throw new NotImplementedException();
    }
}
