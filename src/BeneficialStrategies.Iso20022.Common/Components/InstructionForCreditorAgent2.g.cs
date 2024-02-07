﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by ComponentGenerator for InstructionForCreditorAgent2.  ISO2002 ID# _TOHf1Np-Ed-ak6NoX_4Aeg_1659539851.
//

using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;
using System.Xml;
using System.Xml.Linq;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Further information related to the processing of the payment instruction that may need to be acted upon by the creditor's agent. The instruction may relate to a level of service, or may be an instruction that has to be executed by the creditor's agent, or may be information required by the creditor's agent.
/// </summary>
public partial record InstructionForCreditorAgent2
     : IIsoXmlSerilizable<InstructionForCreditorAgent2>
{
    #nullable enable
    
    /// <summary>
    /// Coded information related to the processing of the payment instruction, provided by the initiating party, and intended for the creditor's agent.
    /// </summary>
    public Instruction5Code? Code { get; init; } 
    /// <summary>
    /// Further information complementing the coded instruction or instruction to the creditor's agent that is bilaterally agreed or specific to a user community.
    /// </summary>
    public IsoMax140Text? InstructionInformation { get; init; } 
    
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
        if (Code is Instruction5Code CodeValue)
        {
            writer.WriteStartElement(null, "Cd", xmlNamespace );
            writer.WriteValue(CodeValue.ToString()); // Enum value
            writer.WriteEndElement();
        }
        if (InstructionInformation is IsoMax140Text InstructionInformationValue)
        {
            writer.WriteStartElement(null, "InstrInf", xmlNamespace );
            writer.WriteValue(SerializationFormatter.IsoMax140Text(InstructionInformationValue)); // data type Max140Text System.String
            writer.WriteEndElement();
        }
    }
    public static InstructionForCreditorAgent2 Deserialize(XElement element)
    {
        throw new NotImplementedException();
    }
}
