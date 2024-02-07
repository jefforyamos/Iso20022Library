﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by ComponentGenerator for SettlementParties59.  ISO2002 ID# _1D0EgY-1Eeaoj_JbcpWKgg.
//

using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;
using System.Xml;
using System.Xml.Linq;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Chain of parties involved in the settlement of a transaction, including receipts and deliveries, book transfers, treasury deals, or other activities, resulting in the movement of a security or amount of money from one account to another.
/// </summary>
public partial record SettlementParties59
     : IIsoXmlSerilizable<SettlementParties59>
{
    #nullable enable
    
    /// <summary>
    /// First party in the settlement chain. In a plain vanilla settlement, it is the Central Securities Depository where the counterparty requests to receive the financial instrument or from where the counterparty delivers the financial instruments.
    /// </summary>
    public PartyIdentification118? Depository { get; init; } 
    /// <summary>
    /// Party that, in a settlement chain interacts with the depository.
    /// </summary>
    public PartyIdentificationAndAccount155? Party1 { get; init; } 
    /// <summary>
    /// Party that, in a settlement chain interacts with the party 1.
    /// </summary>
    public PartyIdentificationAndAccount155? Party2 { get; init; } 
    /// <summary>
    /// Party that, in a settlement chain interacts with the party 2.
    /// </summary>
    public PartyIdentificationAndAccount155? Party3 { get; init; } 
    /// <summary>
    /// Party that, in a settlement chain interacts with the party 3.
    /// </summary>
    public PartyIdentificationAndAccount155? Party4 { get; init; } 
    /// <summary>
    /// Party that, in a settlement chain interacts with the party 4.
    /// </summary>
    public PartyIdentificationAndAccount155? Party5 { get; init; } 
    
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
        if (Depository is PartyIdentification118 DepositoryValue)
        {
            writer.WriteStartElement(null, "Dpstry", xmlNamespace );
            DepositoryValue.Serialize(writer, xmlNamespace);
            writer.WriteEndElement();
        }
        if (Party1 is PartyIdentificationAndAccount155 Party1Value)
        {
            writer.WriteStartElement(null, "Pty1", xmlNamespace );
            Party1Value.Serialize(writer, xmlNamespace);
            writer.WriteEndElement();
        }
        if (Party2 is PartyIdentificationAndAccount155 Party2Value)
        {
            writer.WriteStartElement(null, "Pty2", xmlNamespace );
            Party2Value.Serialize(writer, xmlNamespace);
            writer.WriteEndElement();
        }
        if (Party3 is PartyIdentificationAndAccount155 Party3Value)
        {
            writer.WriteStartElement(null, "Pty3", xmlNamespace );
            Party3Value.Serialize(writer, xmlNamespace);
            writer.WriteEndElement();
        }
        if (Party4 is PartyIdentificationAndAccount155 Party4Value)
        {
            writer.WriteStartElement(null, "Pty4", xmlNamespace );
            Party4Value.Serialize(writer, xmlNamespace);
            writer.WriteEndElement();
        }
        if (Party5 is PartyIdentificationAndAccount155 Party5Value)
        {
            writer.WriteStartElement(null, "Pty5", xmlNamespace );
            Party5Value.Serialize(writer, xmlNamespace);
            writer.WriteEndElement();
        }
    }
    public static SettlementParties59 Deserialize(XElement element)
    {
        throw new NotImplementedException();
    }
}
