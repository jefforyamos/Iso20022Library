﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by ComponentGenerator for IndividualOrderConfirmationStatusAndReason2.  ISO2002 ID# _ArbrJTbtEead9bDRE_1DAQ.
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
public partial record IndividualOrderConfirmationStatusAndReason2
     : IIsoXmlSerilizable<IndividualOrderConfirmationStatusAndReason2>
{
    #nullable enable
    
    /// <summary>
    /// Reference assigned to a set of orders or trades in order to link them together.
    /// </summary>
    public IsoMax35Text? MasterReference { get; init; } 
    /// <summary>
    /// Unique and unambiguous identifier for the order, as assigned by the instructing party.
    /// </summary>
    public required IsoMax35Text OrderReference { get; init; } 
    /// <summary>
    /// Status of the order confirmation cancellation.
    /// </summary>
    public required ConfirmationStatus1Choice_ Confirmation { get; init; } 
    /// <summary>
    /// Unique and unambiguous investor's identification of an order. This reference can typically be used in a hub scenario to give the reference of the order as assigned by the underlying client.
    /// </summary>
    public IsoMax35Text? ClientReference { get; init; } 
    /// <summary>
    /// Unique and unambiguous identifier for the order execution, as assigned by the confirming party.
    /// </summary>
    public IsoMax35Text? DealReference { get; init; } 
    /// <summary>
    /// Party that initiates the status of the order confirmation.
    /// </summary>
    public PartyIdentification113? StatusInitiator { get; init; } 
    /// <summary>
    /// Account information of the individual order confirmation for which the status is given.
    /// </summary>
    public InvestmentAccount58? InvestmentAccountDetails { get; init; } 
    /// <summary>
    /// Financial instrument information of the individual order confirmation for which the status is given.
    /// </summary>
    public FinancialInstrument57? FinancialInstrumentDetails { get; init; } 
    
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
        writer.WriteStartElement(null, "Conf", xmlNamespace );
        Confirmation.Serialize(writer, xmlNamespace);
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
        if (StatusInitiator is PartyIdentification113 StatusInitiatorValue)
        {
            writer.WriteStartElement(null, "StsInitr", xmlNamespace );
            StatusInitiatorValue.Serialize(writer, xmlNamespace);
            writer.WriteEndElement();
        }
        if (InvestmentAccountDetails is InvestmentAccount58 InvestmentAccountDetailsValue)
        {
            writer.WriteStartElement(null, "InvstmtAcctDtls", xmlNamespace );
            InvestmentAccountDetailsValue.Serialize(writer, xmlNamespace);
            writer.WriteEndElement();
        }
        if (FinancialInstrumentDetails is FinancialInstrument57 FinancialInstrumentDetailsValue)
        {
            writer.WriteStartElement(null, "FinInstrmDtls", xmlNamespace );
            FinancialInstrumentDetailsValue.Serialize(writer, xmlNamespace);
            writer.WriteEndElement();
        }
    }
    public static IndividualOrderConfirmationStatusAndReason2 Deserialize(XElement element)
    {
        throw new NotImplementedException();
    }
}
