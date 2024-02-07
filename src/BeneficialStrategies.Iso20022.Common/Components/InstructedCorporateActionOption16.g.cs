﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by ComponentGenerator for InstructedCorporateActionOption16.  ISO2002 ID# _pUFZCx9QEeuFz_FaCzCLgQ.
//

using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;
using System.Xml;
using System.Xml.Linq;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Provides corporate action option details about total instructed balance.
/// </summary>
public partial record InstructedCorporateActionOption16
     : IIsoXmlSerilizable<InstructedCorporateActionOption16>
{
    #nullable enable
    
    /// <summary>
    /// Number identifying the available corporate action options.
    /// </summary>
    public IsoExact3NumericText? OptionNumber { get; init; } 
    /// <summary>
    /// Specifies the corporate action options available to the account owner.
    /// </summary>
    public required CorporateActionOption36Choice_ OptionType { get; init; } 
    /// <summary>
    /// Balance of instructed position.
    /// </summary>
    public required BalanceFormat7Choice_ InstructedBalance { get; init; } 
    /// <summary>
    /// Indicates the default action related to a corporate action event.
    /// </summary>
    public DefaultProcessingOrStandingInstruction1Choice_? DefaultAction { get; init; } 
    /// <summary>
    /// Daily total of accepted instructions received for a given option.
    /// </summary>
    public SignedQuantityFormat9? OptionAcceptedInstructedBalance { get; init; } 
    /// <summary>
    /// Daily total of cancelled instructions for a given option.
    /// </summary>
    public SignedQuantityFormat9? OptionCancelledInstructionBalance { get; init; } 
    /// <summary>
    /// Daily total of pending instructions in pending status for a given option.  It includes cancel pending instructions. 
    /// </summary>
    public SignedQuantityFormat9? OptionPendingInstructionBalance { get; init; } 
    /// <summary>
    /// Daily total of rejected instructions for a given option.
    /// </summary>
    public SignedQuantityFormat9? OptionRejectedInstructionBalance { get; init; } 
    /// <summary>
    /// Daily total of all protect instructions for a given option.
    /// </summary>
    public SignedQuantityFormat9? OptionProtectInstructionBalance { get; init; } 
    /// <summary>
    /// Provides information about the deadlines related to a corporate action option.
    /// </summary>
    public required CorporateActionEventDeadlines4 EventDeadlines { get; init; } 
    /// <summary>
    /// Instructions details received for the given option.
    /// </summary>
    public OptionInstructionDetails6? OptionInstructionDetails { get; init; } 
    
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
        if (OptionNumber is IsoExact3NumericText OptionNumberValue)
        {
            writer.WriteStartElement(null, "OptnNb", xmlNamespace );
            writer.WriteValue(SerializationFormatter.IsoExact3NumericText(OptionNumberValue)); // data type Exact3NumericText System.String
            writer.WriteEndElement();
        }
        writer.WriteStartElement(null, "OptnTp", xmlNamespace );
        OptionType.Serialize(writer, xmlNamespace);
        writer.WriteEndElement();
        writer.WriteStartElement(null, "InstdBal", xmlNamespace );
        InstructedBalance.Serialize(writer, xmlNamespace);
        writer.WriteEndElement();
        if (DefaultAction is DefaultProcessingOrStandingInstruction1Choice_ DefaultActionValue)
        {
            writer.WriteStartElement(null, "DfltActn", xmlNamespace );
            DefaultActionValue.Serialize(writer, xmlNamespace);
            writer.WriteEndElement();
        }
        if (OptionAcceptedInstructedBalance is SignedQuantityFormat9 OptionAcceptedInstructedBalanceValue)
        {
            writer.WriteStartElement(null, "OptnAccptdInstdBal", xmlNamespace );
            OptionAcceptedInstructedBalanceValue.Serialize(writer, xmlNamespace);
            writer.WriteEndElement();
        }
        if (OptionCancelledInstructionBalance is SignedQuantityFormat9 OptionCancelledInstructionBalanceValue)
        {
            writer.WriteStartElement(null, "OptnCancInstrBal", xmlNamespace );
            OptionCancelledInstructionBalanceValue.Serialize(writer, xmlNamespace);
            writer.WriteEndElement();
        }
        if (OptionPendingInstructionBalance is SignedQuantityFormat9 OptionPendingInstructionBalanceValue)
        {
            writer.WriteStartElement(null, "OptnPdgInstrBal", xmlNamespace );
            OptionPendingInstructionBalanceValue.Serialize(writer, xmlNamespace);
            writer.WriteEndElement();
        }
        if (OptionRejectedInstructionBalance is SignedQuantityFormat9 OptionRejectedInstructionBalanceValue)
        {
            writer.WriteStartElement(null, "OptnRjctdInstrBal", xmlNamespace );
            OptionRejectedInstructionBalanceValue.Serialize(writer, xmlNamespace);
            writer.WriteEndElement();
        }
        if (OptionProtectInstructionBalance is SignedQuantityFormat9 OptionProtectInstructionBalanceValue)
        {
            writer.WriteStartElement(null, "OptnPrtctInstrBal", xmlNamespace );
            OptionProtectInstructionBalanceValue.Serialize(writer, xmlNamespace);
            writer.WriteEndElement();
        }
        writer.WriteStartElement(null, "EvtDdlns", xmlNamespace );
        EventDeadlines.Serialize(writer, xmlNamespace);
        writer.WriteEndElement();
        if (OptionInstructionDetails is OptionInstructionDetails6 OptionInstructionDetailsValue)
        {
            writer.WriteStartElement(null, "OptnInstrDtls", xmlNamespace );
            OptionInstructionDetailsValue.Serialize(writer, xmlNamespace);
            writer.WriteEndElement();
        }
    }
    public static InstructedCorporateActionOption16 Deserialize(XElement element)
    {
        throw new NotImplementedException();
    }
}
