﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by ComponentGenerator for ReceivingPartiesAndAccount13.  ISO2002 ID# _I-FT8SSIEeWdoOFYMt-Lzw.
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
public partial record ReceivingPartiesAndAccount13
     : IIsoXmlSerilizable<ReceivingPartiesAndAccount13>
{
    #nullable enable
    
    /// <summary>
    /// Party that buys goods or services, or a financial instrument.
    /// </summary>
    public InvestmentAccount55? ReceiverDetails { get; init; } 
    /// <summary>
    /// Party that acts on behalf of the buyer of securities when the buyer does not have a direct relationship with the receiving agent.
    /// </summary>
    public PartyIdentificationAndAccount124? ReceiversCustodianDetails { get; init; } 
    /// <summary>
    /// Party that the receiver's custodian uses to effect the receipt of a security, when the receiver's custodian does not have a direct relationship with the receiving agent.
    /// </summary>
    public PartyIdentificationAndAccount124? ReceiversIntermediary1Details { get; init; } 
    /// <summary>
    /// Party that interacts with the receiver’s intermediary.
    /// </summary>
    public PartyIdentificationAndAccount124? ReceiversIntermediary2Details { get; init; } 
    /// <summary>
    /// Party that receives securities from the delivering agent via the place of settlement, for example, securities central depository.
    /// </summary>
    public required PartyIdentificationAndAccount123 ReceivingAgentDetails { get; init; } 
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
        if (ReceiverDetails is InvestmentAccount55 ReceiverDetailsValue)
        {
            writer.WriteStartElement(null, "RcvrDtls", xmlNamespace );
            ReceiverDetailsValue.Serialize(writer, xmlNamespace);
            writer.WriteEndElement();
        }
        if (ReceiversCustodianDetails is PartyIdentificationAndAccount124 ReceiversCustodianDetailsValue)
        {
            writer.WriteStartElement(null, "RcvrsCtdnDtls", xmlNamespace );
            ReceiversCustodianDetailsValue.Serialize(writer, xmlNamespace);
            writer.WriteEndElement();
        }
        if (ReceiversIntermediary1Details is PartyIdentificationAndAccount124 ReceiversIntermediary1DetailsValue)
        {
            writer.WriteStartElement(null, "RcvrsIntrmy1Dtls", xmlNamespace );
            ReceiversIntermediary1DetailsValue.Serialize(writer, xmlNamespace);
            writer.WriteEndElement();
        }
        if (ReceiversIntermediary2Details is PartyIdentificationAndAccount124 ReceiversIntermediary2DetailsValue)
        {
            writer.WriteStartElement(null, "RcvrsIntrmy2Dtls", xmlNamespace );
            ReceiversIntermediary2DetailsValue.Serialize(writer, xmlNamespace);
            writer.WriteEndElement();
        }
        writer.WriteStartElement(null, "RcvgAgtDtls", xmlNamespace );
        ReceivingAgentDetails.Serialize(writer, xmlNamespace);
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
    public static ReceivingPartiesAndAccount13 Deserialize(XElement element)
    {
        throw new NotImplementedException();
    }
}
