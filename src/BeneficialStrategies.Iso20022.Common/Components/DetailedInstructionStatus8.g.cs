﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by ComponentGenerator for DetailedInstructionStatus8.  ISO2002 ID# _RCy3w9p-Ed-ak6NoX_4Aeg_1948673401.
//

using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;
using System.Xml;
using System.Xml.Linq;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Status applying to individual instructions of a MeetingInstruction.
/// </summary>
public partial record DetailedInstructionStatus8
     : IIsoXmlSerilizable<DetailedInstructionStatus8>
{
    #nullable enable
    
    /// <summary>
    /// Identifies the detailed instruction within an instruction message.
    /// </summary>
    public required IsoMax35Text InstructionIdentification { get; init; } 
    /// <summary>
    /// Identifies the safekeeping account.
    /// </summary>
    public IsoMax35Text? AccountIdentification { get; init; } 
    /// <summary>
    /// Identifies the subaccount of the safekeeping account.
    /// </summary>
    public IsoMax35Text? SubAccountIdentification { get; init; } 
    /// <summary>
    /// Status applying to individual instructions of a MeetingInstruction.
    /// </summary>
    public required InstructionStatus4Choice_ InstructionStatus { get; init; } 
    
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
        writer.WriteStartElement(null, "InstrId", xmlNamespace );
        writer.WriteValue(SerializationFormatter.IsoMax35Text(InstructionIdentification)); // data type Max35Text System.String
        writer.WriteEndElement();
        if (AccountIdentification is IsoMax35Text AccountIdentificationValue)
        {
            writer.WriteStartElement(null, "AcctId", xmlNamespace );
            writer.WriteValue(SerializationFormatter.IsoMax35Text(AccountIdentificationValue)); // data type Max35Text System.String
            writer.WriteEndElement();
        }
        if (SubAccountIdentification is IsoMax35Text SubAccountIdentificationValue)
        {
            writer.WriteStartElement(null, "SubAcctId", xmlNamespace );
            writer.WriteValue(SerializationFormatter.IsoMax35Text(SubAccountIdentificationValue)); // data type Max35Text System.String
            writer.WriteEndElement();
        }
        writer.WriteStartElement(null, "InstrSts", xmlNamespace );
        InstructionStatus.Serialize(writer, xmlNamespace);
        writer.WriteEndElement();
    }
    public static DetailedInstructionStatus8 Deserialize(XElement element)
    {
        throw new NotImplementedException();
    }
}
