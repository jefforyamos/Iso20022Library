﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by ComponentGenerator for SettlementParties102.  ISO2002 ID# _U8pEwTDIEey42czAX58WGQ.
//

using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;
using System.Xml;
using System.Xml.Linq;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Specifies settlement parties (delivering/receiving).
/// </summary>
public partial record SettlementParties102
     : IIsoXmlSerilizable<SettlementParties102>
{
    #nullable enable
    
    /// <summary>
    /// First receiving party in the settlement chain. In a plain vanilla settlement, it is the central securities depository where the receiving side of the transaction requests to receive the financial instrument.
    /// </summary>
    public PartyIdentification143? Depository { get; init; } 
    /// <summary>
    /// Party that interacts with the depository.
    /// </summary>
    public PartyIdentificationAndAccount204? Party1 { get; init; } 
    /// <summary>
    /// Party that interacts with the party1.
    /// </summary>
    public PartyIdentificationAndAccount204? Party2 { get; init; } 
    /// <summary>
    /// Party that interacts with the party2.
    /// </summary>
    public PartyIdentificationAndAccount204? Party3 { get; init; } 
    
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
        if (Depository is PartyIdentification143 DepositoryValue)
        {
            writer.WriteStartElement(null, "Dpstry", xmlNamespace );
            DepositoryValue.Serialize(writer, xmlNamespace);
            writer.WriteEndElement();
        }
        if (Party1 is PartyIdentificationAndAccount204 Party1Value)
        {
            writer.WriteStartElement(null, "Pty1", xmlNamespace );
            Party1Value.Serialize(writer, xmlNamespace);
            writer.WriteEndElement();
        }
        if (Party2 is PartyIdentificationAndAccount204 Party2Value)
        {
            writer.WriteStartElement(null, "Pty2", xmlNamespace );
            Party2Value.Serialize(writer, xmlNamespace);
            writer.WriteEndElement();
        }
        if (Party3 is PartyIdentificationAndAccount204 Party3Value)
        {
            writer.WriteStartElement(null, "Pty3", xmlNamespace );
            Party3Value.Serialize(writer, xmlNamespace);
            writer.WriteEndElement();
        }
    }
    public static SettlementParties102 Deserialize(XElement element)
    {
        throw new NotImplementedException();
    }
}
