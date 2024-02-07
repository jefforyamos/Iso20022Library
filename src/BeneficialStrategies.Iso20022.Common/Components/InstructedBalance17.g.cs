﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by ComponentGenerator for InstructedBalance17.  ISO2002 ID# _pf2NhTi7Eeydid5dcNPKvg.
//

using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;
using System.Xml;
using System.Xml.Linq;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Provides information about total instructed balance.
/// </summary>
public partial record InstructedBalance17
     : IIsoXmlSerilizable<InstructedBalance17>
{
    #nullable enable
    
    /// <summary>
    /// Provides information about the total instructed balance.
    /// </summary>
    public required BalanceFormat14Choice_ TotalInstructedBalance { get; init; } 
    /// <summary>
    /// Daily total of all accepted instructions for given day.  Cover protect instructions will be included in this total balance.
    /// </summary>
    public SignedQuantityFormat13? TotalAcceptedInstructionBalance { get; init; } 
    /// <summary>
    /// Daily total of cancelled instructions for a given day.
    /// </summary>
    public SignedQuantityFormat13? TotalCancelledInstructionBalance { get; init; } 
    /// <summary>
    /// Daily total of pending instructions in pending status.  It includes cancel pending instructions.
    /// </summary>
    public SignedQuantityFormat13? TotalPendingInstructionBalance { get; init; } 
    /// <summary>
    /// Daily total of rejected instructions.
    /// </summary>
    public SignedQuantityFormat13? TotalRejectedInstructionBalance { get; init; } 
    /// <summary>
    /// Daily total of all protect instructions sent in a given day.
    /// </summary>
    public SignedQuantityFormat13? TotalProtectInstructionBalance { get; init; } 
    /// <summary>
    /// Provide instructed balance breakdown information per option.
    /// </summary>
    public InstructedCorporateActionOption18? OptionDetails { get; init; } 
    
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
        writer.WriteStartElement(null, "TtlInstdBal", xmlNamespace );
        TotalInstructedBalance.Serialize(writer, xmlNamespace);
        writer.WriteEndElement();
        if (TotalAcceptedInstructionBalance is SignedQuantityFormat13 TotalAcceptedInstructionBalanceValue)
        {
            writer.WriteStartElement(null, "TtlAccptdInstrBal", xmlNamespace );
            TotalAcceptedInstructionBalanceValue.Serialize(writer, xmlNamespace);
            writer.WriteEndElement();
        }
        if (TotalCancelledInstructionBalance is SignedQuantityFormat13 TotalCancelledInstructionBalanceValue)
        {
            writer.WriteStartElement(null, "TtlCancInstrBal", xmlNamespace );
            TotalCancelledInstructionBalanceValue.Serialize(writer, xmlNamespace);
            writer.WriteEndElement();
        }
        if (TotalPendingInstructionBalance is SignedQuantityFormat13 TotalPendingInstructionBalanceValue)
        {
            writer.WriteStartElement(null, "TtlPdgInstrBal", xmlNamespace );
            TotalPendingInstructionBalanceValue.Serialize(writer, xmlNamespace);
            writer.WriteEndElement();
        }
        if (TotalRejectedInstructionBalance is SignedQuantityFormat13 TotalRejectedInstructionBalanceValue)
        {
            writer.WriteStartElement(null, "TtlRjctdInstrBal", xmlNamespace );
            TotalRejectedInstructionBalanceValue.Serialize(writer, xmlNamespace);
            writer.WriteEndElement();
        }
        if (TotalProtectInstructionBalance is SignedQuantityFormat13 TotalProtectInstructionBalanceValue)
        {
            writer.WriteStartElement(null, "TtlPrtctInstrBal", xmlNamespace );
            TotalProtectInstructionBalanceValue.Serialize(writer, xmlNamespace);
            writer.WriteEndElement();
        }
        if (OptionDetails is InstructedCorporateActionOption18 OptionDetailsValue)
        {
            writer.WriteStartElement(null, "OptnDtls", xmlNamespace );
            OptionDetailsValue.Serialize(writer, xmlNamespace);
            writer.WriteEndElement();
        }
    }
    public static InstructedBalance17 Deserialize(XElement element)
    {
        throw new NotImplementedException();
    }
}
