﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by ComponentGenerator for AccountStatusUpdateInstruction1.  ISO2002 ID# _et6_QHi5EeaRm5xIK6nGuQ.
//

using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;
using System.Xml;
using System.Xml.Linq;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Instruction for a change to an account status and reason for the change.
/// </summary>
public partial record AccountStatusUpdateInstruction1
     : IIsoXmlSerilizable<AccountStatusUpdateInstruction1>
{
    #nullable enable
    
    /// <summary>
    /// Type of status change instructed for the account status.
    /// </summary>
    public required AccountStatusUpdateInstruction1Choice_ UpdateInstruction { get; init; } 
    /// <summary>
    /// Reason for the instruction to change the account status.
    /// </summary>
    public AccountStatusUpdateInstructionReason1Choice_? UpdateInstructionReason { get; init; } 
    
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
        writer.WriteStartElement(null, "UpdInstr", xmlNamespace );
        UpdateInstruction.Serialize(writer, xmlNamespace);
        writer.WriteEndElement();
        if (UpdateInstructionReason is AccountStatusUpdateInstructionReason1Choice_ UpdateInstructionReasonValue)
        {
            writer.WriteStartElement(null, "UpdInstrRsn", xmlNamespace );
            UpdateInstructionReasonValue.Serialize(writer, xmlNamespace);
            writer.WriteEndElement();
        }
    }
    public static AccountStatusUpdateInstruction1 Deserialize(XElement element)
    {
        throw new NotImplementedException();
    }
}
