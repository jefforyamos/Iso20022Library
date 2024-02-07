﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by ComponentGenerator for AcquirerProtocolParameters5.  ISO2002 ID# _C08NITY6EeOYzMAJn8nuYA.
//

using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;
using System.Xml;
using System.Xml.Linq;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Acceptor parameters dedicated to the acquirer protocol.
/// </summary>
public partial record AcquirerProtocolParameters5
     : IIsoXmlSerilizable<AcquirerProtocolParameters5>
{
    #nullable enable
    
    /// <summary>
    /// Mode for the financial capture of the transaction by the acquirer.
    /// </summary>
    public required FinancialCapture1Code FinancialCapture { get; init; } 
    /// <summary>
    /// Configuration of the batch transfers.
    /// </summary>
    public ExchangeConfiguration4? BatchTransfer { get; init; } 
    /// <summary>
    /// Configuration parameters of completion exchanges.
    /// </summary>
    public ExchangeConfiguration5? CompletionExchange { get; init; } 
    /// <summary>
    /// Configuration of the cancellation exchanges.
    /// </summary>
    public CancellationProcess1Code? CancellationExchange { get; init; } 
    
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
        writer.WriteStartElement(null, "FinCaptr", xmlNamespace );
        writer.WriteValue(FinancialCapture.ToString()); // Enum value
        writer.WriteEndElement();
        if (BatchTransfer is ExchangeConfiguration4 BatchTransferValue)
        {
            writer.WriteStartElement(null, "BtchTrf", xmlNamespace );
            BatchTransferValue.Serialize(writer, xmlNamespace);
            writer.WriteEndElement();
        }
        if (CompletionExchange is ExchangeConfiguration5 CompletionExchangeValue)
        {
            writer.WriteStartElement(null, "CmpltnXchg", xmlNamespace );
            CompletionExchangeValue.Serialize(writer, xmlNamespace);
            writer.WriteEndElement();
        }
        if (CancellationExchange is CancellationProcess1Code CancellationExchangeValue)
        {
            writer.WriteStartElement(null, "CxlXchg", xmlNamespace );
            writer.WriteValue(CancellationExchangeValue.ToString()); // Enum value
            writer.WriteEndElement();
        }
    }
    public static AcquirerProtocolParameters5 Deserialize(XElement element)
    {
        throw new NotImplementedException();
    }
}
