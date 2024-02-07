﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by ConcreteChoiceGenerator for DeliveringSettlementParties.  ISO2002 ID# _TgtUwSqSEeyR9JrVGfaMKw.
//

using BeneficialStrategies.Iso20022.Components;
using BeneficialStrategies.Iso20022.ExternalSchema;
using System.Xml;
using System.Xml.Linq;

namespace BeneficialStrategies.Iso20022.Choices.SettlementParties35Choice;

/// <summary>
/// Chain of parties involved in the settlement of a transaction, including receipts and deliveries, book transfers, treasury deals, or other activities, resulting in the movement of a security or amount of money from one account to another.
/// </summary>
public partial record DeliveringSettlementParties : SettlementParties35Choice_
     , IIsoXmlSerilizable<DeliveringSettlementParties>
{
    #nullable enable
    
    /// <summary>
    /// First party in the settlement chain. In a plain vanilla settlement, it is the Central Securities Depository where the counterparty requests to receive the financial instrument or from where the counterparty delivers the financial instruments.
    /// </summary>
    public required PartyIdentification239Choice_ Depository { get; init; } 
    /// <summary>
    /// Party that, in a settlement chain interacts with the depository.
    /// </summary>
    public required PartyIdentificationAndAccount200 Party1 { get; init; } 
    /// <summary>
    /// Party that, in a settlement chain interacts with the party 1.
    /// </summary>
    public PartyIdentificationAndAccount201? Party2 { get; init; } 
    
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
        writer.WriteStartElement(null, "Dpstry", xmlNamespace );
        Depository.Serialize(writer, xmlNamespace);
        writer.WriteEndElement();
        writer.WriteStartElement(null, "Pty1", xmlNamespace );
        Party1.Serialize(writer, xmlNamespace);
        writer.WriteEndElement();
        if (Party2 is PartyIdentificationAndAccount201 Party2Value)
        {
            writer.WriteStartElement(null, "Pty2", xmlNamespace );
            Party2Value.Serialize(writer, xmlNamespace);
            writer.WriteEndElement();
        }
    }
    public static new DeliveringSettlementParties Deserialize(XElement element)
    {
        throw new NotImplementedException();
    }
}
