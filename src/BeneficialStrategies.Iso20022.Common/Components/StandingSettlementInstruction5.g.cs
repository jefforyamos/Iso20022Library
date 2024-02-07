﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by ComponentGenerator for StandingSettlementInstruction5.  ISO2002 ID# _idvrs-aOEd-q8fx_Zl_34A.
//

using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;
using System.Xml;
using System.Xml.Linq;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Details of the standing settlement instruction to be applied.
/// </summary>
public partial record StandingSettlementInstruction5
     : IIsoXmlSerilizable<StandingSettlementInstruction5>
{
    #nullable enable
    
    /// <summary>
    /// Specifies what settlement standing instruction database is to be used to derive the settlement parties involved in the transaction.
    /// </summary>
    public required SettlementStandingInstructionDatabase1Choice_ SettlementStandingInstructionDatabase { get; init; } 
    /// <summary>
    /// Identification of the buyer or seller in a standing settlement instruction enabling to derive the Standing Settlement Instruction.
    /// </summary>
    public required Counterparty5Choice_ Counterparty { get; init; } 
    /// <summary>
    /// Vendor of the Settlement Standing Instruction database requested to be consulted.
    /// </summary>
    public PartyIdentification45Choice_? Vendor { get; init; } 
    /// <summary>
    /// Delivering parties, other than the seller, needed for deriving the standing settlement instruction (for example, depository) or provided for information purposes (for example, instructing party settlement chain).
    /// </summary>
    public SettlementParties14? OtherDeliveringSettlementParties { get; init; } 
    /// <summary>
    /// Receiving parties, other than the buyer, needed for deriving the standing settlement instruction (for example, depository) or provided for information purposes (for example, instructing party settlement chain).
    /// </summary>
    public SettlementParties14? OtherReceivingSettlementParties { get; init; } 
    
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
        writer.WriteStartElement(null, "SttlmStgInstrDB", xmlNamespace );
        SettlementStandingInstructionDatabase.Serialize(writer, xmlNamespace);
        writer.WriteEndElement();
        writer.WriteStartElement(null, "CtrPty", xmlNamespace );
        Counterparty.Serialize(writer, xmlNamespace);
        writer.WriteEndElement();
        if (Vendor is PartyIdentification45Choice_ VendorValue)
        {
            writer.WriteStartElement(null, "Vndr", xmlNamespace );
            VendorValue.Serialize(writer, xmlNamespace);
            writer.WriteEndElement();
        }
        if (OtherDeliveringSettlementParties is SettlementParties14 OtherDeliveringSettlementPartiesValue)
        {
            writer.WriteStartElement(null, "OthrDlvrgSttlmPties", xmlNamespace );
            OtherDeliveringSettlementPartiesValue.Serialize(writer, xmlNamespace);
            writer.WriteEndElement();
        }
        if (OtherReceivingSettlementParties is SettlementParties14 OtherReceivingSettlementPartiesValue)
        {
            writer.WriteStartElement(null, "OthrRcvgSttlmPties", xmlNamespace );
            OtherReceivingSettlementPartiesValue.Serialize(writer, xmlNamespace);
            writer.WriteEndElement();
        }
    }
    public static StandingSettlementInstruction5 Deserialize(XElement element)
    {
        throw new NotImplementedException();
    }
}
