﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by ComponentGenerator for DeliveringPartiesAndAccount9.  ISO2002 ID# _K_E78R6fEeOolf0-cMYhrw.
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
public partial record DeliveringPartiesAndAccount9
     : IIsoXmlSerilizable<DeliveringPartiesAndAccount9>
{
    #nullable enable
    
    /// <summary>
    /// Party that sells goods or services, or a financial instrument.
    /// </summary>
    public InvestmentAccount41? DelivererDetails { get; init; } 
    /// <summary>
    /// Party that acts on behalf of the seller of securities when the seller does not have a direct relationship with the delivering agent.
    /// </summary>
    public PartyIdentificationAndAccount5? DeliverersCustodianDetails { get; init; } 
    /// <summary>
    /// Party that the deliverer's custodian uses to effect the delivery of a security, when the deliverer's custodian does not have a direct relationship with the delivering agent.
    /// </summary>
    public PartyIdentificationAndAccount5? DeliverersIntermediaryDetails { get; init; } 
    /// <summary>
    /// Party that delivers securities to the receiving agent at the place of settlement, eg, central securities depository.
    /// </summary>
    public required PartyIdentificationAndAccount4 DeliveringAgentDetails { get; init; } 
    /// <summary>
    /// Identifies the securities settlement system to be used.
    /// </summary>
    public IsoMax35Text? SecuritiesSettlementSystem { get; init; } 
    /// <summary>
    /// Place where settlement of the securities takes place.
    /// </summary>
    public PartyIdentification21? PlaceOfSettlementDetails { get; init; } 
    
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
        if (DelivererDetails is InvestmentAccount41 DelivererDetailsValue)
        {
            writer.WriteStartElement(null, "DlvrrDtls", xmlNamespace );
            DelivererDetailsValue.Serialize(writer, xmlNamespace);
            writer.WriteEndElement();
        }
        if (DeliverersCustodianDetails is PartyIdentificationAndAccount5 DeliverersCustodianDetailsValue)
        {
            writer.WriteStartElement(null, "DlvrrsCtdnDtls", xmlNamespace );
            DeliverersCustodianDetailsValue.Serialize(writer, xmlNamespace);
            writer.WriteEndElement();
        }
        if (DeliverersIntermediaryDetails is PartyIdentificationAndAccount5 DeliverersIntermediaryDetailsValue)
        {
            writer.WriteStartElement(null, "DlvrrsIntrmyDtls", xmlNamespace );
            DeliverersIntermediaryDetailsValue.Serialize(writer, xmlNamespace);
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
        if (PlaceOfSettlementDetails is PartyIdentification21 PlaceOfSettlementDetailsValue)
        {
            writer.WriteStartElement(null, "PlcOfSttlmDtls", xmlNamespace );
            PlaceOfSettlementDetailsValue.Serialize(writer, xmlNamespace);
            writer.WriteEndElement();
        }
    }
    public static DeliveringPartiesAndAccount9 Deserialize(XElement element)
    {
        throw new NotImplementedException();
    }
}
