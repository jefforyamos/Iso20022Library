﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by ComponentGenerator for SettlementParties24.  ISO2002 ID# _corOAfpNEeCLrd06h-p51g.
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
public partial record SettlementParties24
     : IIsoXmlSerilizable<SettlementParties24>
{
    #nullable enable
    
    /// <summary>
    /// First receiving party in the settlement chain. In a plain vanilla settlement, it is the central securities depository where the receiving side of the transaction requests to receive the financial instrument.
    /// </summary>
    public PartyIdentification47? Depository { get; init; } 
    /// <summary>
    /// Party that interacts with the depository.
    /// </summary>
    public PartyIdentificationAndAccount51? Party1 { get; init; } 
    /// <summary>
    /// Party that interacts with the party1.
    /// </summary>
    public PartyIdentificationAndAccount51? Party2 { get; init; } 
    /// <summary>
    /// Party that interacts with the party2.
    /// </summary>
    public PartyIdentificationAndAccount51? Party3 { get; init; } 
    
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
        if (Depository is PartyIdentification47 DepositoryValue)
        {
            writer.WriteStartElement(null, "Dpstry", xmlNamespace );
            DepositoryValue.Serialize(writer, xmlNamespace);
            writer.WriteEndElement();
        }
        if (Party1 is PartyIdentificationAndAccount51 Party1Value)
        {
            writer.WriteStartElement(null, "Pty1", xmlNamespace );
            Party1Value.Serialize(writer, xmlNamespace);
            writer.WriteEndElement();
        }
        if (Party2 is PartyIdentificationAndAccount51 Party2Value)
        {
            writer.WriteStartElement(null, "Pty2", xmlNamespace );
            Party2Value.Serialize(writer, xmlNamespace);
            writer.WriteEndElement();
        }
        if (Party3 is PartyIdentificationAndAccount51 Party3Value)
        {
            writer.WriteStartElement(null, "Pty3", xmlNamespace );
            Party3Value.Serialize(writer, xmlNamespace);
            writer.WriteEndElement();
        }
    }
    public static SettlementParties24 Deserialize(XElement element)
    {
        throw new NotImplementedException();
    }
}
