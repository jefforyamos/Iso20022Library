﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by ComponentGenerator for SettlementParties83.  ISO2002 ID# _SsHfY_fWEeiNZp_PtLohLw.
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
public partial record SettlementParties83
     : IIsoXmlSerilizable<SettlementParties83>
{
    #nullable enable
    
    /// <summary>
    /// First party in the settlement chain. In a plain vanilla settlement, it is the Central Securities Depository where the counterparty requests to receive the financial instrument or from where the counterparty delivers the financial instruments.
    /// </summary>
    public PartyIdentification162? Depository { get; init; } 
    /// <summary>
    /// Party that, in a settlement chain interacts with the depository.
    /// </summary>
    public PartyIdentificationAndAccount188? Party1 { get; init; } 
    /// <summary>
    /// Party that, in a settlement chain interacts with the party 1.
    /// </summary>
    public PartyIdentificationAndAccount188? Party2 { get; init; } 
    /// <summary>
    /// Party that, in a settlement chain interacts with the party 2.
    /// </summary>
    public PartyIdentificationAndAccount188? Party3 { get; init; } 
    /// <summary>
    /// Party that, in a settlement chain interacts with the party 3.
    /// </summary>
    public PartyIdentificationAndAccount188? Party4 { get; init; } 
    /// <summary>
    /// Party that, in a settlement chain interacts with the party 4.
    /// </summary>
    public PartyIdentificationAndAccount188? Party5 { get; init; } 
    
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
        if (Depository is PartyIdentification162 DepositoryValue)
        {
            writer.WriteStartElement(null, "Dpstry", xmlNamespace );
            DepositoryValue.Serialize(writer, xmlNamespace);
            writer.WriteEndElement();
        }
        if (Party1 is PartyIdentificationAndAccount188 Party1Value)
        {
            writer.WriteStartElement(null, "Pty1", xmlNamespace );
            Party1Value.Serialize(writer, xmlNamespace);
            writer.WriteEndElement();
        }
        if (Party2 is PartyIdentificationAndAccount188 Party2Value)
        {
            writer.WriteStartElement(null, "Pty2", xmlNamespace );
            Party2Value.Serialize(writer, xmlNamespace);
            writer.WriteEndElement();
        }
        if (Party3 is PartyIdentificationAndAccount188 Party3Value)
        {
            writer.WriteStartElement(null, "Pty3", xmlNamespace );
            Party3Value.Serialize(writer, xmlNamespace);
            writer.WriteEndElement();
        }
        if (Party4 is PartyIdentificationAndAccount188 Party4Value)
        {
            writer.WriteStartElement(null, "Pty4", xmlNamespace );
            Party4Value.Serialize(writer, xmlNamespace);
            writer.WriteEndElement();
        }
        if (Party5 is PartyIdentificationAndAccount188 Party5Value)
        {
            writer.WriteStartElement(null, "Pty5", xmlNamespace );
            Party5Value.Serialize(writer, xmlNamespace);
            writer.WriteEndElement();
        }
    }
    public static SettlementParties83 Deserialize(XElement element)
    {
        throw new NotImplementedException();
    }
}
