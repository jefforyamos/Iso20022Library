﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by ComponentGenerator for BalanceTransferReference1.  ISO2002 ID# _60SyMQ2aEeSNWNtJlXOAhg.
//

using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;
using System.Xml;
using System.Xml.Linq;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Reference to enable the receiving account servicer to reconcile the payment with the message.
/// </summary>
public partial record BalanceTransferReference1
     : IIsoXmlSerilizable<BalanceTransferReference1>
{
    #nullable enable
    
    /// <summary>
    /// Used by the debtor in a suitable reference field of a payment message sent over an alternative payment channel to enable the creditor to match the payment with the payment request.
    /// </summary>
    public required IsoMax35Text BalanceTransferReference { get; init; } 
    
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
        writer.WriteStartElement(null, "BalTrfRef", xmlNamespace );
        writer.WriteValue(SerializationFormatter.IsoMax35Text(BalanceTransferReference)); // data type Max35Text System.String
        writer.WriteEndElement();
    }
    public static BalanceTransferReference1 Deserialize(XElement element)
    {
        throw new NotImplementedException();
    }
}
