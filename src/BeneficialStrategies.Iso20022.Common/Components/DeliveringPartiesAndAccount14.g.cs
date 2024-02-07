﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by ComponentGenerator for DeliveringPartiesAndAccount14.  ISO2002 ID# _2SSjYSSsEeWEdM0tuoNJdg.
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
public partial record DeliveringPartiesAndAccount14
     : IIsoXmlSerilizable<DeliveringPartiesAndAccount14>
{
    #nullable enable
    
    /// <summary>
    /// Party that acts on behalf of the seller of securities when the seller does not have a direct relationship with the delivering agent.
    /// </summary>
    public PartyIdentificationAndAccount124? DeliverersCustodianDetails { get; init; } 
    /// <summary>
    /// Party that the deliverer's custodian uses to effect the delivery of a security, when the deliverer's custodian does not have a direct relationship with the delivering agent.
    /// </summary>
    public PartyIdentificationAndAccount124? DeliverersIntermediary1Details { get; init; } 
    /// <summary>
    /// Party that interacts with the deliverer's intermediary.
    /// </summary>
    public PartyIdentificationAndAccount124? DeliverersIntermediary2Details { get; init; } 
    /// <summary>
    /// Party that delivers securities to the receiving agent at the place of settlement, for example, central securities depository.
    /// </summary>
    public required PartyIdentificationAndAccount124 DeliveringAgentDetails { get; init; } 
    /// <summary>
    /// Identifies the securities settlement system to be used.
    /// </summary>
    public IsoMax35Text? SecuritiesSettlementSystem { get; init; } 
    /// <summary>
    /// Place where settlement of the securities takes place.
    /// </summary>
    public PartyIdentification97? PlaceOfSettlementDetails { get; init; } 
    
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
        if (DeliverersCustodianDetails is PartyIdentificationAndAccount124 DeliverersCustodianDetailsValue)
        {
            writer.WriteStartElement(null, "DlvrrsCtdnDtls", xmlNamespace );
            DeliverersCustodianDetailsValue.Serialize(writer, xmlNamespace);
            writer.WriteEndElement();
        }
        if (DeliverersIntermediary1Details is PartyIdentificationAndAccount124 DeliverersIntermediary1DetailsValue)
        {
            writer.WriteStartElement(null, "DlvrrsIntrmy1Dtls", xmlNamespace );
            DeliverersIntermediary1DetailsValue.Serialize(writer, xmlNamespace);
            writer.WriteEndElement();
        }
        if (DeliverersIntermediary2Details is PartyIdentificationAndAccount124 DeliverersIntermediary2DetailsValue)
        {
            writer.WriteStartElement(null, "DlvrrsIntrmy2Dtls", xmlNamespace );
            DeliverersIntermediary2DetailsValue.Serialize(writer, xmlNamespace);
            writer.WriteEndElement();
        }
        writer.WriteStartElement(null, "DlvrgAgtDtls", xmlNamespace );
        DeliveringAgentDetails.Serialize(writer, xmlNamespace);
        writer.WriteEndElement();
        if (SecuritiesSettlementSystem is IsoMax35Text SecuritiesSettlementSystemValue)
        {
            writer.WriteStartElement(null, "SctiesSttlmSys", xmlNamespace );
            writer.WriteValue(SerializationFormatter.IsoMax35Text(SecuritiesSettlementSystemValue)); // data type Max35Text System.String
            writer.WriteEndElement();
        }
        if (PlaceOfSettlementDetails is PartyIdentification97 PlaceOfSettlementDetailsValue)
        {
            writer.WriteStartElement(null, "PlcOfSttlmDtls", xmlNamespace );
            PlaceOfSettlementDetailsValue.Serialize(writer, xmlNamespace);
            writer.WriteEndElement();
        }
    }
    public static DeliveringPartiesAndAccount14 Deserialize(XElement element)
    {
        throw new NotImplementedException();
    }
}
