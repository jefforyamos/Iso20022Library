﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by ComponentGenerator for IndividualOrderConfirmationStatusAndReason1.  ISO2002 ID# _RMoJOdp-Ed-ak6NoX_4Aeg_-1768968908.
//

using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;
using System.Xml;
using System.Xml.Linq;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Status report of the individual orders confirmation that was previously received.
/// </summary>
public partial record IndividualOrderConfirmationStatusAndReason1
     : IIsoXmlSerilizable<IndividualOrderConfirmationStatusAndReason1>
{
    #nullable enable
    
    /// <summary>
    /// Reference assigned to a set of orders or trades in order to link them together.
    /// </summary>
    public IsoMax35Text? MasterReference { get; init; } 
    /// <summary>
    /// Unique and unambiguous identifier for an order, as assigned by the instructing party.
    /// </summary>
    public required IsoMax35Text OrderReference { get; init; } 
    /// <summary>
    /// Unique and unambiguous investor's identification of an order. This reference can typically be used in a hub scenario to give the reference of the order as assigned by the underlying client.
    /// </summary>
    public IsoMax35Text? ClientReference { get; init; } 
    /// <summary>
    /// Unique and unambiguous identifier for an order execution, as assigned by a confirming party.
    /// </summary>
    public IsoMax35Text? DealReference { get; init; } 
    /// <summary>
    /// Status of the order confirmation is rejected.
    /// </summary>
    public ValueList<ConfirmationRejectedStatus1> ConfirmationRejected { get; init; } = [];
    /// <summary>
    /// Status of the order confirmation amendment is rejected.
    /// </summary>
    public ValueList<ConfirmationRejectedStatus1> AmendmentRejected { get; init; } = [];
    /// <summary>
    /// Status of the order confirmation is accepted or received or sent to next party or there is a communication problem with next party. There is no reason attached.
    /// </summary>
    public required OrderConfirmationStatus1Code Status { get; init; } 
    /// <summary>
    /// Party that initiates the status of the order confirmation.
    /// </summary>
    public PartyIdentification2Choice_? StatusInitiator { get; init; } 
    /// <summary>
    /// Account information of the individual order confirmation for which the status is given.
    /// </summary>
    public InvestmentAccount13? InvestmentAccountDetails { get; init; } 
    /// <summary>
    /// Financial instrument information of the individual order confirmation for which the status is given.
    /// </summary>
    public FinancialInstrument10? FinancialInstrumentDetails { get; init; } 
    
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
        if (MasterReference is IsoMax35Text MasterReferenceValue)
        {
            writer.WriteStartElement(null, "MstrRef", xmlNamespace );
            writer.WriteValue(SerializationFormatter.IsoMax35Text(MasterReferenceValue)); // data type Max35Text System.String
            writer.WriteEndElement();
        }
        writer.WriteStartElement(null, "OrdrRef", xmlNamespace );
        writer.WriteValue(SerializationFormatter.IsoMax35Text(OrderReference)); // data type Max35Text System.String
        writer.WriteEndElement();
        if (ClientReference is IsoMax35Text ClientReferenceValue)
        {
            writer.WriteStartElement(null, "ClntRef", xmlNamespace );
            writer.WriteValue(SerializationFormatter.IsoMax35Text(ClientReferenceValue)); // data type Max35Text System.String
            writer.WriteEndElement();
        }
        if (DealReference is IsoMax35Text DealReferenceValue)
        {
            writer.WriteStartElement(null, "DealRef", xmlNamespace );
            writer.WriteValue(SerializationFormatter.IsoMax35Text(DealReferenceValue)); // data type Max35Text System.String
            writer.WriteEndElement();
        }
        writer.WriteStartElement(null, "ConfRjctd", xmlNamespace );
        ConfirmationRejected.Serialize(writer, xmlNamespace);
        writer.WriteEndElement();
        writer.WriteStartElement(null, "AmdmntRjctd", xmlNamespace );
        AmendmentRejected.Serialize(writer, xmlNamespace);
        writer.WriteEndElement();
        writer.WriteStartElement(null, "Sts", xmlNamespace );
        writer.WriteValue(Status.ToString()); // Enum value
        writer.WriteEndElement();
        if (StatusInitiator is PartyIdentification2Choice_ StatusInitiatorValue)
        {
            writer.WriteStartElement(null, "StsInitr", xmlNamespace );
            StatusInitiatorValue.Serialize(writer, xmlNamespace);
            writer.WriteEndElement();
        }
        if (InvestmentAccountDetails is InvestmentAccount13 InvestmentAccountDetailsValue)
        {
            writer.WriteStartElement(null, "InvstmtAcctDtls", xmlNamespace );
            InvestmentAccountDetailsValue.Serialize(writer, xmlNamespace);
            writer.WriteEndElement();
        }
        if (FinancialInstrumentDetails is FinancialInstrument10 FinancialInstrumentDetailsValue)
        {
            writer.WriteStartElement(null, "FinInstrmDtls", xmlNamespace );
            FinancialInstrumentDetailsValue.Serialize(writer, xmlNamespace);
            writer.WriteEndElement();
        }
    }
    public static IndividualOrderConfirmationStatusAndReason1 Deserialize(XElement element)
    {
        throw new NotImplementedException();
    }
}
